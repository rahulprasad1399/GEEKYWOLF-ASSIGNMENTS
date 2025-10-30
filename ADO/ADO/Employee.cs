//1) Write a program to connect to SQL Server, read data from Employee table
//Create a table Employee(Id, Name, Salary) and perform Insert, Update, and Delete using ADO.NET.

//2) Display all rows from the Employee table using SqlDataReader.

//3) Display the total employee count using ExecuteScalar().

//4) Display all rows from the Employee table using disconnected mode.
//Display all employees and their Name, Salary.

//5) Use SqlDataAdapter and DataSet to retrieve all employees.
//Modify data in the DataSet and update the database using da.Update()


using System.Data;
using System.Data.SqlClient;

namespace ADO
{
    public class SqlConnectionADO
    {
        static void Main(string[] args)
        {
            string cs = "data source=localhost;initial catalog=ado_db;integrated security = False; User ID = sa; Password = Rahul@123";

            //InsertEmployee(cs, "John Martin", 5000);
            //UpdateEmployee(1, cs, "Rock", 10000);
            //DeleteEmployee(4, cs);
            //ShowAllEmployee(cs);

            //int employeeCount = GetEmployeeCount(cs);
            //Console.WriteLine(employeeCount);

            DisconnectedMode(cs);
        }

        public static void InsertEmployee(string cs, string name, decimal salary)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "INSERT INTO Employee (Name, Salary) values (@Name,@Salary)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Salary", salary);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows);
            }
        }

        public static void UpdateEmployee(int id, string cs, string name, decimal salary)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "Update Employee set Name=@Name, Salary=@Salary where id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Salary", salary);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows);
            }
        }

        public static void DeleteEmployee(int id, string cs)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE From Employee Where id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rows} rows deleted");
            }
        }

        //2) Display all rows from the Employee table using SqlDataReader.
        public static void ShowAllEmployee(string cs)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * From Employee";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = reader["Name"].ToString();
                    decimal salary = (decimal)reader["Salary"];
                    Console.WriteLine($"ID: {id}, Name: {name}, Salary: {salary}");
                }
            }
        }

        //3) Display the total employee count using ExecuteScalar().
        public static int GetEmployeeCount(string cs)
        {
            string query = "SELECT count(*) from Employee";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                var result = cmd.ExecuteScalar();

                int count = Convert.ToInt32(result);

                return count;

            }
                

        }

        //4) Display all rows from the Employee table using disconnected mode.
        //Display all employees and their Name, Salary.

        public static void DisconnectedMode(string cs)
        {
            string query = "Select Name, Salary From Employee";

            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                DataTable dt = ds.Tables["Employee"];

                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine($"{row["Name"]}");
                }
            }
        }

        //5) Use SqlDataAdapter and DataSet to retrieve all employees.
        //Modify data in the DataSet and update the database using da.Update()
        public static void UpdateEmployeesUsingDataAdapter(string cs)
        {
            string query = "Select * from Employee";
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                DataTable dt = ds.Tables["Employee"];

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID: {row["Id"]}, Name: {row["Name"]}, Salary: {row["Salary"]}");
                }

                if(dt.Rows.Count > 0)
                {
                    dt.Rows[0]["Salary"] = Convert.ToDecimal(dt.Rows[0]["Salary"]) + 2000;
                }

                DataRow newRow = dt.NewRow();
                newRow["Name"] = "New Employee";
                newRow["Salary"] = 9000;

                dt.Rows.Add(newRow);

                int rowsUpdated = da.Update(ds, "Employee");
                Console.WriteLine($"{rowsUpdated} in the database");
            }
        }
    }
}
