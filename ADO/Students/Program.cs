
// 6) Create a parameterized inline query to insert new students (avoid SQL injection).
// Create a table Student(Id, Name, Class)

// 7) Create a parameterized procedure to get student using stored procedure “GetStudentById”
// with input parameter(@StudentId)  and get students where studentid = 1 from program and print

using System;
using System.Data.SqlClient;

namespace ADO
{
    public class Students
    {
        static void Main(string[] args)
        {
            string cs = "Data Source=localhost;Initial Catalog=ado_db;Integrated Security=False;User ID=sa;Password=Rahul@123;";

            //InsertStudent(cs,1, "Rahul", "10th");
            GetStudentById(cs, 1);
        }

        public static void InsertStudent(string cs,int id, string name, string className)
        { 
            string query = "INSERT INTO student (id, name, class) VALUES (@Id, @Name, @Class)";
            try
            {
                using (SqlConnection con = new SqlConnection(cs)) 
                {
                    con.Open(); 

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Class", className);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery(); 

                    Console.WriteLine($"{rowsAffected} row(s) inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 7) Create a parameterized procedure to get student using stored procedure “GetStudentById”
        // with input parameter(@StudentId)  and get students where studentid = 1 from program and print

        //CREATE PROCEDURE GetStudentById
        //    @StudentId INT
        //AS
        //BEGIN
        //    SELECT Id, Name, Class
        //    FROM Student
        //    WHERE Id = @StudentId;
        //END;

        public static void GetStudentById(string cs, int studentId)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetStudentById", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", studentId);
                
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Name"]}");
                }
            }
        }
    
    }
}

