using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsLib.Models
{
    public class Contact
    {
        private static string primaryKey = "contactId";
        private static List<string> fields = new()
        {
            "salutationId",
            "firstname",
            "surname",
            "street",
            "postalId",
            "phone",
            "phoneTypeId",
            "mobil",
            "companyId",
            "department"
        };

        public readonly int ContactId;
        public Salutation Salutation;
        public string FirstName;
        public string LastName;
        public string Street;
        public Postal Postal;
        public string Phone;
        public PhoneType PhoneType;
        public string Mobil;
        public Company Company;
        public string Department;

        internal Contact(int contactId, int salutationId, string firstName, string lastName, string street, int postalId, string phone, int phoneTypeId, string mobil, int companyId, string department)
        {
            ContactId = contactId;
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            Phone = phone;
            Mobil = mobil;
            Department = department;

            Company = Company.GetCompanyById(companyId);
        }

        public static IEnumerable<Contact> GetContacts()
        {
            var reader = Database.Execute($"SELECT {primaryKey}, {string.Join(", ", fields.ToArray())} FROM Contact;").ExecuteReader();

            List<Contact> contacts = new();

            while (reader.Read())
            {
                contacts.Add(new Contact(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9)));
            }

            reader.Close();
            return contacts;
        }

        public static Contact GetContactById(int contactId)
        {
            var cmd = Database.Execute($"SELECT {primaryKey}, {string.Join(", ", fields.ToArray())} FROM Contact WHERE {primaryKey} = @id;");

            cmd.Parameters.AddWithValue("id", contactId);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var contact = new Contact(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9));
                reader.Close();
                return contact;
            }

            throw new Exception("contact does not exist");
        }

        public static Contact Create(int salutationId, string firstName, string lastName, string street, int postalId, string phone, int phoneTypeId, string mobil, int companyId, string department)
        {
            var cmd = Database.Execute($"INSERT INTO Contact ({string.Join(", ", fields.ToArray())}) VALUES ({string.Join(", ", fields.Select(delegate(string name) { return $"@{name}"; }).ToArray())})");

            cmd.Parameters.AddWithValue("salutationId", salutationId);
            cmd.Parameters.AddWithValue("firstname", firstName);
            cmd.Parameters.AddWithValue("surname", lastName);
            cmd.Parameters.AddWithValue("street", street);
            cmd.Parameters.AddWithValue("postalId", postalId);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("phoneTypeId", phoneTypeId);
            cmd.Parameters.AddWithValue("mobil", mobil);
            cmd.Parameters.AddWithValue("companyId", companyId);
            cmd.Parameters.AddWithValue("department", department);

            cmd.ExecuteNonQuery();

            int contactId = (int)cmd.LastInsertedId;

            return new Contact(contactId, salutationId, firstName, lastName, street, postalId, phone, phoneTypeId, mobil, companyId, department);
        }

        public void Save()
        {
            var cmd = Database.Execute($"UPDATE Company SET {string.Join(", ", fields.Select(delegate(string name) { return $"@{name}"; }).ToArray())} WHERE {primaryKey} = @id");

            cmd.Parameters.AddWithValue("id", ContactId);
            cmd.Parameters.AddWithValue("salutationId", Salutation.SalutationId); // Salutation.salutationId
            cmd.Parameters.AddWithValue("firstname", FirstName);
            cmd.Parameters.AddWithValue("surname", LastName);
            cmd.Parameters.AddWithValue("street", Street);
            cmd.Parameters.AddWithValue("postalId", Postal.PostalId); // Postal.postalId
            cmd.Parameters.AddWithValue("phone", Phone);
            cmd.Parameters.AddWithValue("phoneTypeId", PhoneType.PhoneTypeId); // PhoneType.phoneTypeId
            cmd.Parameters.AddWithValue("mobil", Mobil);
            cmd.Parameters.AddWithValue("companyId", Company.CompanyId);
            cmd.Parameters.AddWithValue("department", Department);

            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            var cmd = Database.Execute($"DELETE FROM Contact WHERE {primaryKey} = @id");

            cmd.Parameters.AddWithValue("id", ContactId);

            cmd.ExecuteNonQuery();
        }
    }
}
