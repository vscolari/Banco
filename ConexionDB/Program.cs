using System;
using MySql.Data.MySqlClient;

namespace ConexionDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=banco;User=root;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos 'banco'.");

                    // Aquí puedes realizar consultas u otras operaciones en la base de datos.

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
