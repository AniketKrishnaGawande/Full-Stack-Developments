namespace BLL;
using BOL;
using DAL;

public class Manager
{


public static List<Vehicle> getAllVehciles(){
    return DBConnector.GetAllData();
}
public static bool UpdateVehicle(int vid, string vname, string vcmp, double vprice){
    return DBConnector.UpdateData(vid, vname, vcmp, vprice);
}

public static Vehicle getSearchedVehcile(int id){
    return DBConnector.GetSearchedData(id);
}

public static bool DeleteVehicles(int id){
    return DBConnector.DeleteData(id);
}
public static bool AddVehicles(int id,string vname, string vcmp, double vprice){
    return DBConnector.AddData(id,vname,vcmp,vprice);
}


}
