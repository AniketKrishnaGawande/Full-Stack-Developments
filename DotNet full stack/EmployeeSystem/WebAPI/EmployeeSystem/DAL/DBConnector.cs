namespace DAL;
using HR;
using MySql.Data.MySqlClient;
public class DBConnector
{
    private static string conString = @"server=localhost;port=3306;user=root;password=Aniket19%;database=Organisation";

    public static List<Employee> GetAllData()
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        List<Employee> list = new List<Employee>();
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection=con;
            cmd.CommandText = "select * from employees";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var eId = int.Parse(reader["eId"].ToString());
                var eName = reader["eName"].ToString();
                var eDept = reader["eDepartment"].ToString();
                var eSalary = double.Parse(reader["eSalary"].ToString());

                Employee emp = new Employee
                {
                    Eid = eId,
                    EName = eName,
                    EDept = eDept,
                    ESalary = eSalary
                };

                list.Add(emp);

            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }
        Console.WriteLine(list);
        return list;
    }

    public static Employee GetEmpData(int Empid)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        Employee emp = new Employee();
        try
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
             cmd.Connection=con;
            cmd.CommandText = "select * from employees where eId=" + Empid;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var eId = int.Parse(reader["eId"].ToString());
                var eName = reader["eName"].ToString();
                var eDept = reader["eDepartment"].ToString();
                var eSalary = double.Parse(reader["eSalary"].ToString());

                emp = new Employee
                {
                    Eid = eId,
                    EName = eName,
                    EDept = eDept,
                    ESalary = eSalary
                };
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }
        return emp;
    }

    public static bool InsertEmployee(Employee emp)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
             cmd.Connection=con;
            cmd.CommandText = "insert into Employees(eName,eDepartment,eSalary) values('" + emp.EName + "','" + emp.EDept + "'," + emp.ESalary + ")";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }
        return false;
    }


    public static bool DeleteEmp(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
             cmd.Connection=con;
            cmd.CommandText = "delete from Employees where eId=" + id;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }
        return false;
    }


    public static bool UpdateEmp(int id, Employee emp)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
             cmd.Connection=con;
            cmd.CommandText = "update Employees set eName='" + emp.EName + "',   eDepartment='" + emp.EDept + "',  eSalary=" + emp.ESalary + " where eId=" +id;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            con.Close();
        }
        return false;
    }
}
