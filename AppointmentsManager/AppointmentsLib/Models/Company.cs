using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;

namespace AppointmentsLib.Models
{
    public class Company
    {
        public readonly int CompanyId;
        public string Label;

        internal Company(int companyId, string label)
        {
            CompanyId = companyId;
            Label = label;
        }
        
        public static IEnumerable<Company> GetCompanies()
        {
            var reader = Database.Execute("SELECT companyId, label FROM Company;").ExecuteReader();

            List<Company> companies = new();

            while (reader.Read())
            {
                companies.Add(new Company(reader.GetInt32(0), reader.GetString(1)));
            }

            reader.Close();
            return companies;
        }

        public static Company GetCompanyById(int companyId)
        {
            var cmd = Database.Execute($"SELECT companyId, label FROM Company WHERE companyId = @id;");

            cmd.Parameters.AddWithValue("id", companyId);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var company = new Company(reader.GetInt32(0), reader.GetString(1));
                reader.Close();
                return company;
            }

            throw new Exception("company does not exist");
        }

        public static Company Create(string label)
        {
            var cmd = Database.Execute($"INSERT INTO Company (label) VALUES (@label)");

            cmd.Parameters.AddWithValue("label", label);

            cmd.ExecuteNonQuery();

            int companyId = (int)cmd.LastInsertedId;

            return new Company(companyId, label);
        }

        public void Save()
        {
            var cmd = Database.Execute("UPDATE Company SET label = @label WHERE companyId = @companyId");

            cmd.Parameters.AddWithValue("label", Label);
            cmd.Parameters.AddWithValue("companyId", CompanyId);

            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            var cmd = Database.Execute("DELETE FROM Company WHERE companyId = @companyId");

            cmd.Parameters.AddWithValue("companyId", CompanyId);

            cmd.ExecuteNonQuery();
        }
    }
}
