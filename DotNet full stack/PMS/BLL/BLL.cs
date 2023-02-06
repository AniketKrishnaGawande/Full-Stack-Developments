namespace BLL;
using DAL;
using BOL;
public class Manager
{

    public static string validate(string uname, string psw)
    {
        List<Profile> list = DBConnector.getAllDetails();
        foreach (Profile per in list)
        {
            if (per.Pname == uname && per.password == psw)
            {
                return per.roll;
            }
        }
        return null;
    }
}
