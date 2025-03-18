using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Configuration;
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
        public static bool GetContactByID(int id, ref string FirstName, ref string SecondName
            , ref string thirdName, ref string LastName, ref string NationalNo
            , ref DateTime DateOfBirth, ref byte Gender, ref string Phone, ref string Email,
            ref string Country, ref string Address, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(DataConnection.ConnectionString);
            string query = "Select * from vw_PeopleWithCountry where PersonID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
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
        public static int GetCountryID(string FirstName, string SecondName
            , string thirdName, string LastName, string NationalNo
            , DateTime DateOfBirth, byte Gender, string Phone, string Email,
             string Country, string Address, string ImagePath)
        {
            int ContactID = -1;

            SqlConnection conn = new SqlConnection(DataConnection.ConnectionString);
            string GetIdQuery = "select CountryID from Countries where CountryName =@Country";
            SqlCommand cmd = new SqlCommand(GetIdQuery, conn);
            cmd.Parameters.AddWithValue("@Country", Country);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    return -1;
                }
                ContactID = (int)result;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
            return ContactID;

        }
        public static int AddAllContact(string FirstName, string SecondName
        , string thirdName, string LastName, string NationalNo
        , DateTime DateOfBirth, string Address, byte Gender, string CountryName, string ImagePath,
             string Email, string Phone)
        {
            int ContactID = -1;
            SqlConnection Conn = new SqlConnection(DataConnection.ConnectionString);
            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName,
LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName,
@LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email,
        (SELECT CountryID FROM Countries WHERE CountryName = @Country), @ImagePath)";

            SqlCommand cmd = new SqlCommand(@query, Conn);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", thirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gender);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            cmd.Parameters.AddWithValue("@Country", CountryName);
            try
            {
                Conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ContactID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Conn.Close();

            }
            return ContactID;






        }



        public static int AddAllContactModified(string FirstName, string SecondName,
    string thirdName, string LastName, string NationalNo,
    DateTime DateOfBirth, string Address, byte Gender, string CountryName, string ImagePath,
    string Email, string Phone)
        {
            int ContactID = -1;

            string query = @"
    INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
    OUTPUT INSERTED.PersonID
    VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email,
            (SELECT  CountryID FROM Countries WHERE CountryName = @Country), @ImagePath)";

            using (SqlConnection Conn = new SqlConnection(DataConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", SecondName);
                    cmd.Parameters.AddWithValue("@ThirdName", thirdName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gendor", Gender); // Fixed column name
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                    cmd.Parameters.AddWithValue("@Country", CountryName);

                    try
                    {
                        Conn.Open();
                        object result = cmd.ExecuteScalar(); // Using ExecuteScalar() for OUTPUT INSERTED.PersonID
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ContactID = insertedID;
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        Console.WriteLine("SQL Error: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("General Error: " + ex.Message);
                    }
                } // SqlCommand is disposed here
            } // SqlConnection is disposed here

            return ContactID;
        }

    }

}
