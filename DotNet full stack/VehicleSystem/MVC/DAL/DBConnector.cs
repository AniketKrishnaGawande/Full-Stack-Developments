namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBConnector
{
    private static string conString = @"server=localhost;port=3306;user=root;password=Aniket19%;database=showroom";
    public static List<Vehicle> GetAllData()
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        List<Vehicle> list = new List<Vehicle>();
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Vehicles";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var vid = int.Parse(reader["vId"].ToString());
                var vname = reader["vName"].ToString();
                var vcmp = reader["vCompany"].ToString();
                var vprice = double.Parse(reader["vPrice"].ToString());
                Vehicle veh = new Vehicle
                {
                    Vid = vid,
                    VName = vname,
                    Vcmp = vcmp,
                    VPrice = vprice
                };
                list.Add(veh);
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
        return list;
    }

    public static Vehicle GetSearchedData(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        Vehicle veh = new Vehicle();
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Vehicles where vId=" + id;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var vid = int.Parse(reader["vId"].ToString());
                var vname = reader["vName"].ToString();
                var vcmp = reader["vCompany"].ToString();
                var vprice = double.Parse(reader["vPrice"].ToString());
                veh = new Vehicle
                {
                    Vid = vid,
                    VName = vname,
                    Vcmp = vcmp,
                    VPrice = vprice
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
        return veh;
    }



    public static bool DeleteData(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        List<Vehicle> list = new List<Vehicle>();
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from vehicles where vId=" + id;
            int row = cmd.ExecuteNonQuery();
            if (row == 0)
            {
                return false;
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
        return true;
    }




    public static bool AddData(int id, string vname, string vcmp, double vprice)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        List<Vehicle> list = new List<Vehicle>();
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into vehicles values(" + id + ",'" + vname + "','" + vcmp + "'," + vprice + ")";
            int row = cmd.ExecuteNonQuery();
            if (row == 0)
            {
                return false;
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
        return true;
    }
    public static bool UpdateData(int vid, string vname, string vcmp, double vprice)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        List<Vehicle> list = new List<Vehicle>();
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update vehicles set vName='" + vname + "', vCompany='" + vcmp + "', vPrice=" + vprice + " where vId=" + vid;
            int row = cmd.ExecuteNonQuery();
            if (row == 0)
            {
                return false;
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
        return true;
    }


}
