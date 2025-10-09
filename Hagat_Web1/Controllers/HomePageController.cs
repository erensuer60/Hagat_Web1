using Microsoft.AspNetCore.Mvc;

namespace Hagat_Web1.Controllers
{
	public class HomePageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}

		//public PartialViewResult BannerPartial()
		//{
		//	return PartialView();
		//}

		public PartialViewResult ProductPartial()
		{
			return PartialView();
		}
		public PartialViewResult MlrsPartial()
		{
			return PartialView();
		}
		public PartialViewResult WhatWeDoPartial()
		{
			return PartialView();
		}
		public PartialViewResult ReferencePartial()
		{
			return PartialView();
		}
		public PartialViewResult RecentNewPartial()
		{
			return PartialView();
		}
		public PartialViewResult ContactPartial()
		{
			return PartialView();
		}
		public PartialViewResult FfarPartial()
		{
			return PartialView();
		}
	}
}
