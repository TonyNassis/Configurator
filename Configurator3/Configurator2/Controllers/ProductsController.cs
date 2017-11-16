using Configurator2.Models;
using Configurator2.ViewModels;
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

		public ActionResult Edit(int id) {

			var product = _context.products.SingleOrDefault(m => m.ProductIdentifier == id);

			if (product == null) {
				return HttpNotFound();
			}

			var viewModel = new ProductFormViewModel {
				ProductIdentifier = product.ProductIdentifier,
				ProductName = product.ProductName,
				BulkDensity = product.BulkDensity,
				AngleOfRepose = product.AngleofRepose,
				TLSPattern = product.TLSPattern,
				ParPercentageBlending = product.ParPercentageBlending
			};
	
			if ((int)Session[Sessions.EditStatus] == (int)EnumEditStatus.EditEnabled)
				ViewBag.Passed = true;
			else
				ViewBag.Passed = false;

			return View("ProductForm", viewModel);
		}

		[HttpPost]
		public ActionResult Save(ProductFormViewModel product) {

			if (product.ProductIdentifier == 0) {
				return HttpNotFound();
			} else {
				var productInDb = _context.products.Single(m => m.ProductIdentifier == product.ProductIdentifier);

				productInDb.BulkDensity = product.BulkDensity;
				productInDb.AngleofRepose = product.AngleOfRepose;
				productInDb.TLSPattern = product.TLSPattern;
				productInDb.ParPercentageBlending = product.ParPercentageBlending;
				
				_context.SaveChanges();

				return RedirectToAction("Index", "Products");
			}
		}
	}
}