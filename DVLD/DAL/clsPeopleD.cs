using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

    }
}
