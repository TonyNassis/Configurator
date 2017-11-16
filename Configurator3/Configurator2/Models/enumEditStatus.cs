using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Configurator2.Models {

	public enum EnumEditStatus {
		EditEnabled,
		EditDisabled
	}

	public class Sessions {
		public const string EditStatus = "EditStatus";
	}
}