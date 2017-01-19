using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication4.Models

{
    //[Table("EnrolledSubject2")]
    public class EnrolledSubject2
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string RegNumber { get; set; }
    }
}