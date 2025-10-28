// 10)  Create a parameterized procedure to update a student using stored procedure “UpdateStudent”
// with input parameters (@StudentId, @StudnetName, @Class) and print student updated successfully
// or not.

//CREATE PROCEDURE UpdateStudent
//    @StudentId INT,
//    @StudentName VARCHAR(100),
//    @Class VARCHAR(50)
//AS
//BEGIN
//    UPDATE Student
//    SET Name = @StudentName,
//        Class = @Class
//    WHERE Id = @StudentId;

//IF @@ROWCOUNT > 0
//        PRINT 'Student updated successfully.';
//ELSE
//    PRINT 'No student found with the given ID.';
//END;

using Microsoft.Data.SqlClient;

namespace Assignment10
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            string cs = "Data Source=localhost;Initial Catalog=ado_db;Integrated Security=False;User ID=sa;Password=Rahul@123;TrustServerCertificate=True;";
            UpdateStudent(cs, "Rohit", "MCA", 2);
        }

        public static void UpdateStudent(string cs, string studentName, string className, int studentId)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@StudentName", studentName);
                cmd.Parameters.AddWithValue("@Class", className);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Student Updated Successfully");
                } else
                {
                    Console.WriteLine("No Student found with the provided Id");
                }
            }
        }
    }
}
