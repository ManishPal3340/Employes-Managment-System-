using System;
using System.Data.SqlClient;

class CrudOperation
{
    static string cs = @"Data Source=.\SQLEXPRESS;
                         Initial Catalog=Company;
                         Integrated Security=True";

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n====== Employee CRUD ======");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. View");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Insert(); break;
                case 2: View(); break;
                case 3: Update(); break;
                case 4: Delete(); break;
                case 5: return;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }
    }

    // INSERT
    static void Insert()
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Dept: ");
            string dept = Console.ReadLine();

            Console.Write("Enter Salary: ");
            int salary = int.Parse(Console.ReadLine());

            string query = @"INSERT INTO Employee
                            (EmpId, EmpName, EmpAge, EmpDept, EmpSalary)
                            VALUES
                            (@id,@name,@age,@dept,@salary)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.Parameters.AddWithValue("@salary", salary);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("✅ Record Inserted");
        }
    }

    // VIEW
    static void View()
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            string query = "SELECT * FROM Employee";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\nID  NAME  AGE  DEPT  SALARY");

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} {dr[4]}");
            }
            conn.Close();
        }
    }

    // UPDATE
    static void Update()
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            Console.Write("Enter ID to Update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();

            string query = "UPDATE Employee SET EmpName=@name WHERE EmpId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("✅ Record Updated");
        }
    }

    // DELETE
    static void Delete()
    {
        using (SqlConnection conn = new SqlConnection(cs))
        {
            Console.Write("Enter ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            string query = "DELETE FROM Employee WHERE EmpId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("✅ Record Deleted");
        }
    }
}
