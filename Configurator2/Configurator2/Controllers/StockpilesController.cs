using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Configurator2.Controllers {

	public class StockpilesController : Controller {

		//--- set up the context for the controller
		private BRMO_Integration_Context _context;

		public StockpilesController() {
			_context = new BRMO_Integration_Context();
		}

		protected override void Dispose(bool disposing) {
			_context.Dispose();
		}
		//------------------------------------------------

		public ActionResult Index() {

			var stockpiles = _context.Stockpiles.ToList();

			return View(stockpiles);
		}
	}
}