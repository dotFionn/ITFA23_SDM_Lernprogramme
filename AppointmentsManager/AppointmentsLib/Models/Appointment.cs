using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsLib.Models
{
    public class Appointment
    {
        public readonly int AppointmentId;
        public Contact Contact;
        public DateTime Time;
        public string Description;

        internal Appointment(int appointmentId, int contactId, string time, string description)
        {
            AppointmentId = appointmentId;
            Contact = Contact.GetContactById(contactId);
            Time = DateTime.Parse(time);
            Description = description;
        }

        public static IEnumerable<Appointment> GetAppointments()
        {
            var reader = Database.Execute("SELECT appointmentId, contactId, time, description FROM Appointment;").ExecuteReader();

            List<Appointment> appointments = new();

            while (reader.Read())
            {
                appointments.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3)));
            }

            reader.Close();
            return appointments;
        }

        public static Appointment GetAppointmentById(int appointmentId)
        {
            var cmd = Database.Execute($"SELECT appointmentId, contactId, time, description FROM Appointment WHERE appointmentId = @id;");

            cmd.Parameters.AddWithValue("id", appointmentId);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var appointment = new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
                reader.Close();
                return appointment;
            }

            throw new Exception("salutation does not exist");
        }

        public static Appointment Create(int contactId, DateTime time, string description)
        {
            var cmd = Database.Execute($"INSERT INTO Appointment (contactId, time, description) VALUES (@contact, @time, @description)");

            cmd.Parameters.AddWithValue("contact", contactId);
            cmd.Parameters.AddWithValue("time", time);
            cmd.Parameters.AddWithValue("description", description);

            cmd.ExecuteNonQuery();

            int appointmentId = (int)cmd.LastInsertedId;

            return new Appointment(appointmentId, contactId, time.ToString(), description);
        }

        public void Save()
        {
            var cmd = Database.Execute("UPDATE Appointment SET contactId = @contact, time = @time, description = @description WHERE appointmentId = @id");

            cmd.Parameters.AddWithValue("contact", Contact.ContactId);
            cmd.Parameters.AddWithValue("time", Time);
            cmd.Parameters.AddWithValue("description", Description);

            cmd.Parameters.AddWithValue("id", AppointmentId);

            cmd.ExecuteNonQuery();
        }

        public void Delete()
        {
            var cmd = Database.Execute("DELETE FROM Appointment WHERE appointmentId = @id");

            cmd.Parameters.AddWithValue("id", AppointmentId);

            cmd.ExecuteNonQuery();
        }
    }
}
