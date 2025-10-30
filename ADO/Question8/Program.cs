//8) Create a parameterized procedure to insert a student using stored procedure
// “InsertStudent” with input parameters (Name, Class) and output parameter last inserted
// student id(@LastInsertedId) then print that id.


//CREATE PROCEDURE InsertStudent
//    @Name NVARCHAR(100),
//    @Class NVARCHAR(50),
//    @LastInsertedId INT OUTPUT
//AS
//BEGIN
//    INSERT INTO Student (Name, Class)
//    VALUES (@Name, @Class);

//SET @LastInsertedId = SCOPE_IDENTITY();
//END;


using Microsoft.Data.SqlClient;
using System.Data;

namespace Question8
{
    public class Assignment8
    {
        static void Main(string[] args)
        {
            string cs = "Data Source=localhost;Initial Catalog=ado_db;Integrated Security=False;User ID=sa;Password=Rahul@123;TrustServerCertificate=True;";
            InsertStudent(cs, "Rahul", "BTECH");
        }

        public static void InsertStudent(string cs, string name, string className)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Class", className);

                SqlParameter outputParams = new SqlParameter("@LastInsertedId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                };

                cmd.Parameters.Add(outputParams);

                cmd.ExecuteNonQuery();

                int lastId = Convert.ToInt32(outputParams.Value);

                Console.WriteLine($"New student inserted successfully with ID: {lastId}");
            }
        }
    }


}
