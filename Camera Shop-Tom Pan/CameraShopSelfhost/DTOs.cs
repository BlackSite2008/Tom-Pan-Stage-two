using System;
using System.Collections.Generic;

namespace CameraShopSelfhost
{   //Tom-Pan :This is a DTO file of selfhost
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
    }
}
