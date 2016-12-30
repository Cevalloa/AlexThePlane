using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace AlexThePlane.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//		var mvcName = typeof(Controller).Assembly.GetName();
			//		var isMono = Type.GetType("Mono.Runtime") != null;

			//		ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			//		ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			//if (Session["Rem_Time"] == null)
			//{
			//	Session["Rem_Time"] = DateTime.Now.AddMinutes(2).ToString("dd-MM-yyyy h:mm:ss tt");
			//}

			//ViewBag.Rem_Time = Session["Rem_Time"];
			//ViewBag.Message = "Modifty this template to jump start it";
			if (Session["EndDate"] == null)
			{
				var endDate = new DateTime(

										   year: 2017,
										   month: 1,
										   day: 6,
										   hour: 18,
										   minute: 0,
										   second: 0
				);
				Session["EndDate"] = endDate.ToString("dd-MM-yyyy h:mm:ss tt");//DateTime.Now.AddMinutes(1).ToString("dd-MM-yyyy h:mm:ss tt");
			}
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
			ViewBag.EndDate = Session["EndDate"];

			return View();
		}
	}
}
