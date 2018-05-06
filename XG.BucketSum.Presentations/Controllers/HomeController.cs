using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XG.BucketSum.Presentations.BucketSumService;

namespace XG.BucketSum.Presentations.Controllers
{
    public class HomeController : Controller
    {
        BucketSumServiceClient bucketService = new BucketSumServiceClient();


        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public JsonResult GetBucketSum(string data)
        {
            var test = bucketService.GetBucketSumWeb(data);
            return Json(test, JsonRequestBehavior.AllowGet);
        }
    }
}