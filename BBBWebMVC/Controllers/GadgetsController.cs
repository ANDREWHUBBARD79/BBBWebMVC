using BBBWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;





namespace BBBWebMVC.Controllers
{
	public class GadgetsController : Controller
	{
		public ActionResult Index()
		{
			List<GadgetModel> gadgets = new List<GadgetModel>();
			gadgets.Add(new GadgetModel(0, "Gun", "A secret gun", "Moonraker", "Actor name"));


			gadgets.Add(new GadgetModel(0, "Gun", "A secret gun", "Moonraker", "Actor name"));

			gadgets.Add(new GadgetModel(0, "Gun", "A secret gun", "Moonraker", "Actor name"));

			gadgets.Add(new GadgetModel(0, "Gun", "A secret gun", "Moonraker", "Actor name"));

			return View("Index", gadgets);


		}
	}
}
