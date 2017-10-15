using Configurator2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Configurator2.Controllers {
	public class ProductsController : Controller {

		//--- set up the context for the controller
		private BRMO_Integration_Context _context;

		public ProductsController() {
			_context = new BRMO_Integration_Context();
		}

		protected override void Dispose(bool disposing) {
			_context.Dispose();
		}
		//------------------------------------------------

		public ActionResult Index() {

			var products = _context.products.ToList();

				
			return View(products);
		}
	}
}