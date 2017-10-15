using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Configurator2.ViewModels {

	public class ProductFormViewModel {
		public int ProductIdentifier { get; set; }
		public string ProductName { get; set; }
		public double? ParPercentageBlending { get; set; }
	}
}