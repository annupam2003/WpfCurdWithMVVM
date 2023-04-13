using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.AdoNet
{
    public class AdoDbContext
    {
        const string constr = "Data Source=localhost;Initial Catalog=WebApi5;Integrated Security=True";

        public IEnumerable<Employee> GetAllEmployee()
        {
            DataTable tbl = new DataTable();
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("Select * from employees", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tbl);
            }
            if (tbl?.Rows.Count > 0)
            {
                employees.AddRange((from tb in tbl.AsEnumerable() select new Employee { Id = tb.Field<int>("Id"), Name = tb.Field<string>("Name"), Address = tb.Field<string>("Address"), City = tb.Field<string>("City"), Salary = tb.Field<Int64>("Salary") }).ToList());
            }
            return employees;
        }

        public int AddEmployee(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("insert into Employees(Name, Address, City, Salary) values(@Name, @Address, @City, @Salary)", con);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@City", emp.City);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int EditEmployee(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("Update employees set Name=@Name, Address=@Address, City=@City, Salary=@Salary where id=@Id",con);
                cmd.Parameters.AddWithValue("@Id", emp.Id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@City", emp.City);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int RemoveEmployee(int Id)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("Delete from employees where id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

    }
}
