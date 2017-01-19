using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Login
    {
        [Required(ErrorMessage= "Registration Number is required")]
        [Display(Name="Registration Number")]
        public string RegNumber { get; set; }
        [Required(ErrorMessage="Password is required")]
        public string Password { get; set; }

        public bool checkUser(string registrationnr, string password) //This method check the user existence
        {
            bool flag = false;
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; // Read the connection string from the web.config file
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from StudentLogin where RegistrationNumber='" + registrationnr + "' and Password='" + password + "'", conn);
                flag = Convert.ToBoolean(cmd.ExecuteScalar());
                return flag;
            }
        }
    }
}