using Configurator2.ViewModels;
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

		public ActionResult Edit(int id) {

			var stockpile = _context.Stockpiles.SingleOrDefault(m => m.StockpileIdentifier == id);

			if (stockpile == null) {
				return HttpNotFound();
			}

			var viewModel = new StockpileFormViewModel {
				StockpileIdentifier = stockpile.StockpileIdentifier,
				StockpileName = stockpile.StockpileName,
				StockpileCapacity =  stockpile.StockpileCapacity,
				StockpileServiceTypeIdentifier = stockpile.StockpileServiceTypeIdentifier,
				StockpileStartLimit = stockpile.StockpileStartLimit ,
				StockpileCentreLimit = stockpile.StockpileCentreLimit ,
				StockpileEndLimit = stockpile.StockpileEndLimit ,
				PlannedBuildProductIdentifier = stockpile.PlannedBuildProductIdentifier,
				BuildAngleOfRepose = stockpile.BuildAngleOfRepose ,
				StackerNo = stockpile.StackerNo ,
				ReclaimerQuadrant = stockpile.ReclaimerQuadrant ,
				StartPositionOffset  = stockpile.StartPositionOffset ,
				StartLuffingAngle  = stockpile.StartLuffingAngle ,
				ConeShellStepDistance = stockpile.ConeShellStepDistance ,
				BenchHeight  = stockpile.BenchHeight ,
				BenchVolume  = stockpile.BenchVolume ,
				InitialLuffAngle  = stockpile.InitialLuffAngle ,
				InitialLongTravelPosition = stockpile.InitialLongTravelPosition,
				StackingRegimeIdentifier = stockpile.StackingRegimeIdentifier ,
				StackingFormulaIdentifier = stockpile.StackingFormulaIdentifier ,
				BLStartStackingDirection = stockpile.BLStartStackingDirection ,
				BLStartReclaimingDirection = stockpile.BLStartReclaimingDirection ,
				Bench1LuffAngle = stockpile.Bench1LuffAngle ,
				ParBench1SlewAngle  = stockpile.ParBench1SlewAngle ,
				Bench1LongTravelPosition = stockpile.Bench1LongTravelPosition,
				Bench2LuffAngle = stockpile.Bench2LuffAngle ,
				Bench2SlewAngle  = stockpile.Bench2SlewAngle ,
				Bench2LongTravelPosition = stockpile.Bench2LongTravelPosition,
				Bench3LuffAngle = stockpile.Bench3LuffAngle ,
				Bench3SlewAngle = stockpile.Bench3SlewAngle ,
				Bench3LongTravelPosition = stockpile.Bench3LongTravelPosition,
				StockpileLength = stockpile.StockpileLength ,
				LongTravelStepLength = stockpile.LongTravelStepLength ,
				PilgrimStepLength = stockpile.PilgrimStepLength ,
				InnerSlewLimit = stockpile.InnerSlewLimit ,
				OuterSlewLimit = stockpile.OuterSlewLimit ,
				InnerSlewTurnaroundLimit = stockpile.InnerSlewTurnaroundLimit,
				OuterSlewTurnaroundLimit = stockpile.OuterSlewTurnaroundLimit ,
				ReclaimRateSetpoint  = stockpile.ReclaimRateSetpoint ,
				InitialSlewAngle  = stockpile.InitialSlewAngle ,
				InitialSlewInnerTurnaroundLimit = stockpile.InitialSlewInnerTurnaroundLimit,
				InitialSlewOuterTurnaroundLimit = stockpile.InitialSlewOuterTurnaroundLimit ,
			};

			return View("StockpileForm", viewModel);

		}
	}
}