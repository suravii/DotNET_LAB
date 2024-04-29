using Microsoft.Data.SqlClient;
using AdoCrud.Models;
using System.Data.SqlTypes;

namespace AdoCrud.Repositories
{
    public class StudentRepo
    {
        public IEnumerable<Student> GetAllRecords()
        {
            string conStr = @"server=Desktop-123 ; database=ncclabsuravi ; TrustServerCertificate=true; Integrated Security= SSPI; Trusted_connection= true";
            List<Student> listOfStudents = new List<Student>();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            String selectQuery = "SELECT * FROM students";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Student std = new Student();
                std.Id = Convert.ToInt32(rdr["Id"]);
                std.Name = Convert.ToString(rdr["Name"]);
                std.Stream = Convert.ToString(rdr["Stream"]);
                listOfStudents.Add(std);
            }
            return listOfStudents;
        }
      }
    }

