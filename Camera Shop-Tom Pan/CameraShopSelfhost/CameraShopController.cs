using System;
using System.Collections.Generic;
using System.Data;

namespace CameraShopSelfhost
{   //Tom-Pan :This controller controls every data in or out from databases
    public class CameraShopController : System.Web.Http.ApiController
    {
        public List<string> GetBrandNames()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT Brand_Name FROM Brands", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows) lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public clsBrand GetBrand(string Brand_Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Brand_Name", Brand_Name);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT * FROM Brands WHERE Brand_Name = @Brand_Name", par);

            if (lcResult.Rows.Count > 0)
                return new clsBrand()

                {
                    Brand_Name = (string)lcResult.Rows[0]["Brand_Name"],
                    Brand_ID = (string)lcResult.Rows[0]["Brand_ID"],
                    Brand_Descrip = (string)lcResult.Rows[0]["Brand_Descrip"],
                    CamerasList = getBrandsCamera(Brand_Name)

                };
            else
                return null;
        }

        private List<clsAllCamera> getBrandsCamera(object Brand_Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Brand_Name", Brand_Name);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM Cameras WHERE Brand_Name = @Brand_Name", par);
            List<clsAllCamera> lcCameras = new List<clsAllCamera>();
            foreach (DataRow dr in lcResult.Rows)
                lcCameras.Add(dataRow2AllCamera(dr));
            return lcCameras;
        }

        private clsAllCamera dataRow2AllCamera(DataRow dr)
        {
            return new clsAllCamera()
            {
                Brand_Name = Convert.ToString(dr["Brand_Name"]),
                Camera_ID = Convert.ToInt32(dr["Camera_ID"]),
                Camera_Price = Convert.ToInt32(dr["Camera_Price"]),
                Camera_Num = Convert.ToString(dr["Camera_Num"]),
                Camera_type = Convert.ToString(dr["Camera_type"]),
                Camera_Warranty = dr["Camera_Warranty"] is DBNull ? (DateTime?)null : Convert.ToDateTime(dr["Camera_Warranty"]), 
            };
        }

        public string PutBrand(clsBrand prBrand)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                "UPDATE Brands SET Brand_ID = @Brand_ID, Brand_Descrip = @Brand_Descrip WHERE Brand_Name = @Brand_Name",
                prepareBrandParameters(prBrand));

                if (lcRecCount == 1)
                    return "One brand updated";
                else
                    return "Unexpected brand update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string InsertBrand(clsBrand prBrand)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                "INSERT INTO Brands VALUES(@Brand_Name, @Brand_ID, @Brand_Descrip)",
                prepareBrandParameters(prBrand));

                if (lcRecCount == 1)
                    return "One brand inserted";
                else
                    return "Unexpected brand insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareBrandParameters(clsBrand prBrand)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(3);

            par.Add("Brand_Name", prBrand.Brand_Name);
            par.Add("Brand_ID", prBrand.Brand_ID);
            par.Add("Brand_Descrip", prBrand.Brand_Descrip);
            return par;
        }
    }
}
