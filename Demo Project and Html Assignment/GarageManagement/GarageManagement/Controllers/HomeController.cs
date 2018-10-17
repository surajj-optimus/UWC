using GarageManagement.Models;
using GarageManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageManagement.Controllers
{
	[Route("garage")]
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return RedirectToAction("Index", "Home");
		}

		[HttpPost]
		[Route("add-car")]
		public ActionResult CarSubmit(Car car)
		{
			CarManagementService.AddCar(car.Name, car.Model, car.Number);
			return Json(new { name = car.Name, model = car.Model, number = car.Number });
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
	}
}