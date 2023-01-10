using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;

namespace AppointmentsLib
{
    public static class Database
    {
        private static MySqlConnection mysqlConnection;
        
        public static bool Connect(string server, int port, string database, string username, string password)
        {
            string connectionString = $"Server={server};Port={port};User id={username};Password={password};Database={database}";

            mysqlConnection = new MySqlConnection(connectionString);

            try {
                mysqlConnection.Open();

                Console.WriteLine("db connected");

                return true;
            } catch(Exception e) {
                Console.WriteLine("db connection failed");

                Console.WriteLine(e);

                return false;
            }  
        }

        internal static MySqlCommand Execute(string command)
        {
            return new MySqlCommand(command, mysqlConnection);
        }
    }
}
