namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBConnector
{

    private static string conString = @"server=localhost;port=3306;user=root;password=Aniket19%;database=PMS";
    public static List<Profile> getAllDetails()
    {
        MySqlConnection con = new MySqlConnection();
        List<Profile> list = new List<Profile>();
        con.ConnectionString = conString;
        try
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from profiles";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                var pid = int.Parse(reader["pId"].ToString());
                var pnm = reader["pName"].ToString();
                var age = int.Parse(reader["pAge"].ToString());
                //var pdate = DateOnly.Parse(reader["pBDate"].ToString());
                var psw = (reader["password"].ToString());
                var rollP = (reader["roll"].ToString());

                Profile prof = new Profile
                {

                    Pid = pid,
                    Pname = pnm,
                    Page = age,
                    //  PBdate = pdate,
                    password = psw,
                    roll = rollP
                };

                list.Add(prof);
            }

        }
        catch (Exception e)
        {
            Console.Write(e);
        }
        finally
        {
            con.Close();
        }
        return list;
    }

    public static Profile findOne(string uname)
    {
        MySqlConnection con = new MySqlConnection();
        Profile per = new Profile();
        con.ConnectionString = conString;
        try
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from profiles where pName='" + uname + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                var pid = int.Parse(reader["pId"].ToString());
                var pnm = reader["pName"].ToString();
                var age = int.Parse(reader["pAge"].ToString());
                //var pdate = DateOnly.Parse(reader["pBDate"].ToString());
                var psw = (reader["password"].ToString());
                var rollP = (reader["roll"].ToString());
                Console.WriteLine(pid);
                per = new Profile
                {

                    Pid = pid,
                    Pname = pnm,
                    Page = age,
                    //  PBdate = pdate,
                    password = psw,
                    roll = rollP
                };
            }

        }
        catch (Exception e)
        {
            Console.Write(e);
        }
        finally
        {
            con.Close();
        }
        return per;
    }




}
