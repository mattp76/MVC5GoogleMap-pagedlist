using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmap.Models;
using Newtonsoft.Json;
using PagedList;

namespace Webmap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int page = 1)
        {

            var obj = new MapModel() {
                id = 1,
                name = "matty",
                lat = "10.16596",
                lng = "36.401081"
            };

            var obj1 = new MapModel()
            {
                id = 1,
                name = "tester",
                lat = "10.16596",
                lng = "36.401081"
            };


            var obj2 = new MapModel()
            {
                id = 1,
                name = "hello",
                lat = "10.16596",
                lng = "36.401081"
            };


            var obj3 = new MapModel()
            {
                id = 1,
                name = "matty",
                lat = "10.16596",
                lng = "36.401081"
            };


            var obj4 = new MapModel()
            {
                id = 1,
                name = "matty",
                lat = "10.16596",
                lng = "36.401081"
            };



            var obj5 = new MapModel()
            {
                id = 1,
                name = "matty",
                lat = "10.16596",
                lng = "36.401081"
            };



            var obj6 = new MapModel()
            {
                id = 1,
                name = "matty",
                lat = "10.16596",
                lng = "36.401081"
            };



            var obj7 = new MapModel()
            {
                id = 1,
                name = "matty",
                lat = "10.16596",
                lng = "36.401081"
            };




            var objList = new List<MapModel>();
            objList.Add(obj);
            objList.Add(obj1);
            objList.Add(obj2);
            objList.Add(obj3);
            objList.Add(obj4);
            objList.Add(obj5);
            objList.Add(obj6);
            objList.Add(obj7);

            var str = getMapJson(obj);
           
            bool isAjax = Request.IsAjaxRequest();

            return isAjax
                ? (ActionResult)PartialView("PagedList", objList.ToPagedList(page, 2))
                : View(objList.ToPagedList(page, 2));

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public string getMapJson<T>(T obj)
        {
            var str = JsonConvert.SerializeObject(obj);


            return str;
        }


    }


}