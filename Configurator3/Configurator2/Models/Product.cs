using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Configurator2.Models {

	public class Product {
		public int ProductIdentifier { get; set; }
		public string ProductName { get; set; }
		public double? BulkDensity { get; set; }
		public double? AngleofRepose { get; set; }
		public string Description { get; set; }
		public int? TLSPattern { get; set; }
		public double? ParPercentageBlending { get; set; }
	}
}