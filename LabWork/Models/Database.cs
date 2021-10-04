using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LabWork.Models.Tables;

namespace LabWork.Models
{
    public class Database
    {
        public Students Students { get; set; }
        public Courses Courses { get; set; }

        public Database()
        {
            string connString = @"Server=RUSHDI\SQLEXPRESS;Database=Esite;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            Students = new Students(conn);
            Courses = new Courses();
            
        }
        
   
    }
}