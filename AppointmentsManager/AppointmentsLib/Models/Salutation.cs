using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsLib.Models
{
    public class Salutation
    {
        public readonly int SalutationId;
        public string Label;

        internal Salutation(int salutationId, string label)
        {
            SalutationId = salutationId;
            Label = label;
        }

        public static IEnumerable<Salutation> GetSalutations()
        {
            var reader = Database.Execute("SELECT salutationId, label FROM Salutation;").ExecuteReader();

            List<Salutation> salutations = new();

            while (reader.Read())
            {
                salutations.Add(new Salutation(reader.GetInt32(0), reader.GetString(1)));
            }

            reader.Close();
            return salutations;
        }

        public static Salutation GetSalutationById(int salutationId)
        {
            var cmd = Database.Execute($"SELECT salutationId, label FROM Salutation WHERE salutationId = @id;");

            cmd.Parameters.AddWithValue("id", salutationId);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var salutation = new Salutation(reader.GetInt32(0), reader.GetString(1));
                reader.Close();
                return salutation;
            }

            throw new Exception("salutation does not exist");
        }

        public static Salutation Create(string label)
        {
            var cmd = Database.Execute($"INSERT INTO Salutation (label) VALUES (@label)");

            cmd.Parameters.AddWithValue("label", label);

            cmd.ExecuteNonQuery();

            int salutationId = (int)cmd.LastInsertedId;

            return new Salutation(salutationId, label);
        }

        public void Save()
        {
            var cmd = Database.Execute("UPDATE Salutation SET label = @label WHERE salutationId = @id");

            cmd.Parameters.AddWithValue("label", Label);
            cmd.Parameters.AddWithValue("id", SalutationId);

            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            var cmd = Database.Execute("DELETE FROM Salutation WHERE salutationId = @id");

            cmd.Parameters.AddWithValue("id", SalutationId);

            cmd.ExecuteNonQuery();
        }
    }
}
