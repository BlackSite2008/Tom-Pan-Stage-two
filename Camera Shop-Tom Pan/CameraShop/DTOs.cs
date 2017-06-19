using System;
using System.Collections.Generic;

namespace CameraShop
{   //Tom-Pan :This is a DTO file for WinForm
    public class clsBrand
    {
        public string Brand_Name { get; set; }
        public string Brand_ID { get; set; }
        public string Brand_Descrip { get; set; }
        public List<clsAllCamera> CamerasList { get; set; }

    }

    public class clsAllCamera
    {
        public string Brand_Name { get; set; }
        public int Camera_ID { get; set; }
        public int Camera_Price { get; set; }
        public string Camera_Num { get; set; }
        public DateTime? Camera_Warranty { get; set; }
        public string Camera_type { get; set; }
        public string _DisplayMember {
            get {
                return Brand_Name + "\t" + Camera_ID + "\t" + Camera_Price;
            }
        }
    }
}
