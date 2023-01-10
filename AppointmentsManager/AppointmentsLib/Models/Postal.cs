using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsLib.Models
{
    public class Postal
    {
        public readonly int PostalId;
        public string Label;

        internal Postal(int postalId, string label)
        {
            PostalId = postalId;
            Label = label;
        }

        public static IEnumerable<Postal> GetPostals()
        {
            var reader = Database.Execute("SELECT postalId, label FROM Postal;").ExecuteReader();

            List<Postal> postals = new();

            while (reader.Read())
            {
                postals.Add(new Postal(reader.GetInt32(0), reader.GetString(1)));
            }

            reader.Close();
            return postals;
        }

        public static Postal GetPostalById(int postalId)
        {
            var cmd = Database.Execute($"SELECT postalId, label FROM Postal WHERE postalId = @id;");

            cmd.Parameters.AddWithValue("id", postalId);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var postal = new Postal(reader.GetInt32(0), reader.GetString(1));
                reader.Close();
                return postal;
            }

            throw new Exception("postal does not exist");
        }

        public static Postal Create(string label)
        {
            var cmd = Database.Execute($"INSERT INTO Postal (label) VALUES (@label)");

            cmd.Parameters.AddWithValue("label", label);

            cmd.ExecuteNonQuery();

            int postalId = (int)cmd.LastInsertedId;

            return new Postal(postalId, label);
        }

        public void Save()
        {
            var cmd = Database.Execute("UPDATE Postal SET label = @label WHERE postalId = @id");

            cmd.Parameters.AddWithValue("label", Label);
            cmd.Parameters.AddWithValue("id", PostalId);

            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            var cmd = Database.Execute("DELETE FROM Postal WHERE postalId = @id");

            cmd.Parameters.AddWithValue("id", PostalId);

            cmd.ExecuteNonQuery();
        }
    }
}
