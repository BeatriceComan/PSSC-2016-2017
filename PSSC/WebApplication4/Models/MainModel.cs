using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class MainModel
    {
        public Login login { get; set; }
        public EnrolledSubject2 enSubject2 { get; set; }

        public DataSet GetAllSubjects(string registrationnr)
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; // Read the connection string from the web.config file
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select SubjectId,Name,Credits from EnrolledSubject2 where RegistrationNumber='" + registrationnr + "'", conn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
        }
    }
}