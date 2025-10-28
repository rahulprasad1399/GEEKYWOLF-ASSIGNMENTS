// 9) Create a parameterized procedure to delete a student using stored procedure “DeleteStudent”
// with input parameters (@StudentId) and print student deleted successfully or not.

//CREATE PROCEDURE DeleteStudent
//    @StudentId INT
//AS
//BEGIN
//    DELETE FROM Student WHERE Id = @StudentId;

//IF @@ROWCOUNT > 0
//        PRINT 'Student deleted successfully.';
//ELSE
//    PRINT 'No student found with the given ID.';
//END;

using Microsoft.Data.SqlClient;

namespace Question9
{
    public class Assignment9
    {
        public static void Main(string[] args)
        {
            string cs = "Data Source=localhost;Initial Catalog=ado_db;Integrated Security=False;User ID=sa;Password=Rahul@123;TrustServerCertificate=True;";
            DeleteStudent(cs, 2);
        }

        public static void DeleteStudent(string cs, int studentId)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", studentId);
                int rowsAffected = cmd.ExecuteNonQuery();
                
                if(rowsAffected > 0)
                {
                    Console.WriteLine("Student deleted successfully");
                } else
                {
                    Console.WriteLine("No Student found with the given id");
                }
            }
        }
    }
}