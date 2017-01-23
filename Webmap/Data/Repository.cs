using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webmap.Models;

namespace Webmap.Data
{
    public static class Repository
    {

        public static MapModel obj = new MapModel();
        public static MapModel obj1 = new MapModel();
        public static MapModel obj2 = new MapModel();
        public static MapModel obj3 = new MapModel();
        public static MapModel obj4 = new MapModel();
        public static MapModel obj5 = new MapModel();
        public static MapModel obj6 = new MapModel();
        public static MapModel obj7 = new MapModel();
        public static List<MapModel> objList;


        static Repository()
        {

            obj.id = 1;
            obj.name = "matty";
            obj.lat = "10.16596";
            obj.lng = "36.401081";


            obj1.id = 1;
            obj1.name = "tester";
            obj1.lat = "10.16596";
            obj1.lng = "36.401081";


            obj2.id = 1;
            obj2.name = "hello";
            obj2.lat = "10.16596";
            obj2.lng = "36.401081";

            obj3.id = 1;
            obj3.name = "matty";
            obj3.lat = "10.16596";
            obj3.lng = "36.401081";


            obj4.id = 1;
            obj4.name = "matty";
            obj4.lat = "10.16596";
            obj4.lng = "36.401081";

            obj5.id = 1;
            obj5.name = "matty";
            obj5.lat = "10.16596";
            obj5.lng = "36.401081";

            obj6.id = 1;
            obj6.name = "matty";
            obj6.lat = "10.16596";
            obj6.lng = "36.401081";

            obj7.id = 1;
            obj7.name = "matty";
            obj7.lat = "10.16596";
            obj7.lng = "36.401081";
   

            var objList = new List<MapModel>();
            objList.Add(obj);
            objList.Add(obj1);
            objList.Add(obj2);
            objList.Add(obj3);
            objList.Add(obj4);
            objList.Add(obj5);
            objList.Add(obj6);
            objList.Add(obj7);


        }


        public static MapModel getData()
        {

            return obj1;
        }



        public static List<MapModel> getDataList()
        {
            return objList;
        }
    }
}