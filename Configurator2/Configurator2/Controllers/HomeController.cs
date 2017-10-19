using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Configurator2.Models;

namespace Configurator2.Controllers {

	public class HomeController : Controller {

		public ActionResult Index() {

			if (Session[Sessions.EditStatus] == null)
				Session[Sessions.EditStatus] = EnumEditStatus.EditDisabled;

			return View();
		}

		public ActionResult EnableEdit() {
			ViewBag.PasswordError = "";
			return View();
		}

		[HttpPost]
		public ActionResult EnableEdit(string UserPassword) {

			Debug.WriteLine(UserPassword);

			//get the edit password from Web.config
			var EditPassword = ConfigurationManager.AppSettings["PASS"];

			if (UserPassword == EditPassword) {
				Session[Sessions.EditStatus] = EnumEditStatus.EditEnabled;
			} else {
				Session[Sessions.EditStatus] = EnumEditStatus.EditDisabled;
				ViewBag.PasswordError = "Password Wrong - Please Re-enter";

				return View("EnableEdit");
			};

			return View("Index");
		}

		public ActionResult DisableEdit() {

			Session[Sessions.EditStatus] = EnumEditStatus.EditDisabled;

			return View("Index");
		}
	}
}