using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExampleConsoleApp.Models
{
    internal class BebidaDB
    {
        
        
        //ServerName: DESKTOP-BHUCDOQ
        private string connectionString = "Data Source=DESKTOP-BHUCDOQ;Initial Catalog=Example;User=admin;Password=cesar12345678";
    
        public List<Jugo> Get()
        {
            List<Jugo> jugos = new List<Jugo>();

            string query = "select nombre, marca, azucar, cantidad" + " from bebida";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    Console.WriteLine(" Conexion Establecidad ");
                    Console.WriteLine("*------------------------*");

                    SqlDataReader reader = command.ExecuteReader();
                   
                    while(reader.Read())
                    {
                        string Nombre = reader.GetString(0);
                        string Marca = reader.GetString(1);
                        int Cantidad = reader.GetInt32(3);
                        Jugo refresco = new Jugo(Nombre, Marca, Cantidad);
                        refresco.CantidadAzucar = reader.GetInt32(2);

                        jugos.Add((Jugo)refresco);
                    }

                    reader.Close();
                    connection.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error Connection {e.Message}");
                }
            }
            return jugos;
        }
    
        public void Add(Jugo jugos)
        {
            string query = "insert into bebida(nombre, marca, azucar, cantidad) Values (@nombre, @marca, @azucar, @cantidad)";
             using (var connection = new SqlConnection(connectionString))
             {
                try
                {
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", jugos.Nombre);
                    command.Parameters.AddWithValue("@marca", jugos.Marca);
                    command.Parameters.AddWithValue("@azucar", jugos.CantidadAzucar);
                    command.Parameters.AddWithValue("@cantidad", jugos.Cantidad);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ha ocurrido un Error {e.Message}");
                    connection.Close(); 
                }

             }

        }

        public void Edit(Jugo jugos, int Id)
        {
            string query = "update bebida set nombre=@nombre, marca=@marca, azucar=@azucar, cantidad=@cantidad " + " where id=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", jugos.Nombre);
                    command.Parameters.AddWithValue("@marca", jugos.Marca);
                    command.Parameters.AddWithValue("@azucar", jugos.CantidadAzucar);
                    command.Parameters.AddWithValue("@cantidad", jugos.Cantidad);
                    command.Parameters.AddWithValue("@id", Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ha ocurrido un Error {e.Message}");
                    connection.Close();
                }

            }

        }

        public void Delete( int Id)
        {
            string query = "delete from bebida " + " where id=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ha ocurrido un Error {e.Message}");
                    connection.Close();
                }

            }

        }
    }
}
