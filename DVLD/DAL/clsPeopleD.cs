using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;



namespace DAL
{
    public class clsPeopleD
    {
        public static DataTable GetAllContact()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataConnection.ConnectionString);
            string query = "Select * from People"; 
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(); 
                if(reader.HasRows)
                {
                    dt.Load(reader); 
                }
                reader.Close(); 
            }
            catch (Exception ex) 
                {

                }
             finally
            {
                conn.Close();
            }
            return dt;

        }
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataConnection.ConnectionString);
            string query = "Select * from Countries";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return dt;


        }
        public static bool GetContactByID(int id , ref string FirstName , ref string SecondName
            , ref string thirdName , ref string LastName , ref string NationalNo 
            ,ref DateTime DateOfBirth , ref byte Gender , ref string Phone , ref string Email , 
            ref string Country , ref string Address , ref string ImagePath )
        {
            bool isFound  = false;
            SqlConnection conn = new SqlConnection(DataConnection.ConnectionString);
            string query = "Select * from vw_PeopleWithCountry where PersonID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id" ,id);
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Country = (string)reader["CountryName"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                        ImagePath = "";

                }
                else
                {
                    isFound = false;
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

    }
}
