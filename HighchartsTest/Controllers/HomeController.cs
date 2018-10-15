using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighchartsTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "修改此模板以快速启动你的 ASP.NET MVC 应用程序。";


            //后台取数据
            //List<XModel> XModelList = new List<XModel>();
            //for (int i = 0; i < dataArray[6].Length; i++)
            //{
            //    XModel Xmodel = new XModel();
            //    Xmodel.XID = i + 1;
            //    Xmodel.XValue = Math.Round(Convert.ToDecimal(dataArray[6][i]) / 100, 2);
            //    XModelList.Add(Xmodel);
            //}
            //ViewBag.XModelList = XModelList;




            //前台x轴赋值
            //@{
            //var RModelList = ViewBag.RModelList as List<BSNSManage.Models.RModel>;
            //var RValue = RModelList.Select(p => p.RValue);
            //}
            //X轴值
            //series: [{
            //    name: '平均值',
            //    //data: [109, 109, 111, 112.3, 109.4, 108.8, 108.8, 110.1, 109, 110.9, 109, 108]
            //    data: [@string.Join(",", XValue)]


            //}



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
