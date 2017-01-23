using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmap.Models;
using Newtonsoft.Json;
using PagedList;
using Webmap.Data;

namespace Webmap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int page = 1)
        {

            List<MapModel> objList = Repository.getDataList();

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


        public ActionResult Map()
        {
            ViewBag.Message = "Your contact page.";

            List<MapModel> objList = Repository.getDataList();
            MapModel obj = Repository.getData();

            var str = getMapJson(obj);

            return View();
        }



        public string getMapJson<T>(T obj)
        {
            var str = JsonConvert.SerializeObject(obj);

            return str;
        }


    }


}