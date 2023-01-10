using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsLib.Models
{
    public class PhoneType
    {
        public readonly int PhoneTypeId;
        public string Label;

        internal PhoneType(int phoneTypeId, string label)
        {
            PhoneTypeId = phoneTypeId;
            Label = label;
        }

        public static IEnumerable<PhoneType> GetPhoneTypes()
        {
            var reader = Database.Execute("SELECT phoneTypeId, label FROM PhoneType;").ExecuteReader();

            List<PhoneType> phoneTypes = new();

            while (reader.Read())
            {
                phoneTypes.Add(new PhoneType(reader.GetInt32(0), reader.GetString(1)));
            }

            reader.Close();
            return phoneTypes;
        }

        public static PhoneType GetPhoneTypeById(int companyId)
        {
            var cmd = Database.Execute($"SELECT phoneTypeId, label FROM PhoneType WHERE phoneTypeId = @id;");

            cmd.Parameters.AddWithValue("id", companyId);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var phoneType = new PhoneType(reader.GetInt32(0), reader.GetString(1));
                reader.Close();
                return phoneType;
            }

            throw new Exception("phonetype does not exist");
        }

        public static PhoneType Create(string label)
        {
            var cmd = Database.Execute($"INSERT INTO PhoneType (label) VALUES (@label)");

            cmd.Parameters.AddWithValue("label", label);

            cmd.ExecuteNonQuery();

            int phoneTypeId = (int)cmd.LastInsertedId;

            return new PhoneType(phoneTypeId, label);
        }

        public void Save()
        {
            var cmd = Database.Execute("UPDATE PhoneType SET label = @label WHERE phoneTypeId = @id");

            cmd.Parameters.AddWithValue("label", Label);
            cmd.Parameters.AddWithValue("id", PhoneTypeId);

            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            var cmd = Database.Execute("DELETE FROM PhoneType WHERE phoneTypeId = @id");

            cmd.Parameters.AddWithValue("id", PhoneTypeId);

            cmd.ExecuteNonQuery();
        }
    }
}
