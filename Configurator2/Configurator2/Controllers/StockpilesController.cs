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

			//-- convert 'null bool' to 'bool'
			bool _StackingFormulaIdentifier = false;
			bool _BLStartStackingDirection = false;
			bool _BLStartReclaimingDirection = false;

			if (stockpile.StackingFormulaIdentifier != null)
				_StackingFormulaIdentifier = true;

			if (stockpile.BLStartStackingDirection != null)
				_BLStartStackingDirection = true;

			if (stockpile.BLStartReclaimingDirection != null)
				_BLStartReclaimingDirection = true;
			//----------------------------------------------

			var viewModel = new StockpileFormViewModel {
				StockpileIdentifier = stockpile.StockpileIdentifier,
				StockpileName = stockpile.StockpileName,
				StockpileCapacity = stockpile.StockpileCapacity,
				StockpileServiceTypeIdentifier = stockpile.StockpileServiceTypeIdentifier,
				StockpileStartLimit = stockpile.StockpileStartLimit,
				StockpileCentreLimit = stockpile.StockpileCentreLimit,
				StockpileEndLimit = stockpile.StockpileEndLimit,
				PlannedBuildProductIdentifier = stockpile.PlannedBuildProductIdentifier,
				BuildAngleOfRepose = stockpile.BuildAngleOfRepose,
				StackerNo = stockpile.StackerNo,
				ReclaimerQuadrant = stockpile.ReclaimerQuadrant,
				StartPositionOffset = stockpile.StartPositionOffset,
				StartLuffingAngle = stockpile.StartLuffingAngle,
				ConeShellStepDistance = stockpile.ConeShellStepDistance,
				BenchHeight = stockpile.BenchHeight,
				BenchVolume = stockpile.BenchVolume,
				InitialLuffAngle = stockpile.InitialLuffAngle,
				InitialLongTravelPosition = stockpile.InitialLongTravelPosition,
				StackingRegimeIdentifier = stockpile.StackingRegimeIdentifier,

				StackingFormulaIdentifier = _StackingFormulaIdentifier,
				BLStartStackingDirection = _BLStartStackingDirection,
				BLStartReclaimingDirection = _BLStartReclaimingDirection,

				Bench1LuffAngle = stockpile.Bench1LuffAngle,
				ParBench1SlewAngle = stockpile.ParBench1SlewAngle,
				Bench1LongTravelPosition = stockpile.Bench1LongTravelPosition,
				Bench2LuffAngle = stockpile.Bench2LuffAngle,
				Bench2SlewAngle = stockpile.Bench2SlewAngle,
				Bench2LongTravelPosition = stockpile.Bench2LongTravelPosition,
				Bench3LuffAngle = stockpile.Bench3LuffAngle,
				Bench3SlewAngle = stockpile.Bench3SlewAngle,
				Bench3LongTravelPosition = stockpile.Bench3LongTravelPosition,
				StockpileLength = stockpile.StockpileLength,
				LongTravelStepLength = stockpile.LongTravelStepLength,
				PilgrimStepLength = stockpile.PilgrimStepLength,
				InnerSlewLimit = stockpile.InnerSlewLimit,
				OuterSlewLimit = stockpile.OuterSlewLimit,
				InnerSlewTurnaroundLimit = stockpile.InnerSlewTurnaroundLimit,
				OuterSlewTurnaroundLimit = stockpile.OuterSlewTurnaroundLimit,
				ReclaimRateSetpoint = stockpile.ReclaimRateSetpoint,
				InitialSlewAngle = stockpile.InitialSlewAngle,
				InitialSlewInnerTurnaroundLimit = stockpile.InitialSlewInnerTurnaroundLimit,
				InitialSlewOuterTurnaroundLimit = stockpile.InitialSlewOuterTurnaroundLimit,
			};

			return View("StockpileForm", viewModel);

		}

		[HttpPost]
		public ActionResult Save(StockpileFormViewModel stockpile) {

			if (stockpile.StockpileIdentifier == 0) {
				return HttpNotFound();
			} else {
				var stockpileInDb = _context.Stockpiles.Single(m => m.StockpileIdentifier == stockpile.StockpileIdentifier);

				stockpileInDb.Bench1LongTravelPosition = stockpile.Bench1LongTravelPosition;
				stockpileInDb.StockpileCapacity = stockpile.StockpileCapacity;
				stockpileInDb.StockpileServiceTypeIdentifier = stockpile.StockpileServiceTypeIdentifier;
				stockpileInDb.StockpileStartLimit = stockpile.StockpileStartLimit;
				stockpileInDb.StockpileCentreLimit = stockpile.StockpileCentreLimit;
				stockpileInDb.StockpileEndLimit = stockpile.StockpileEndLimit;
				stockpileInDb.PlannedBuildProductIdentifier = stockpile.PlannedBuildProductIdentifier;
				stockpileInDb.BuildAngleOfRepose = stockpile.BuildAngleOfRepose;
				stockpileInDb.StackerNo = stockpile.StackerNo;
				stockpileInDb.ReclaimerQuadrant = stockpile.ReclaimerQuadrant;
				stockpileInDb.StartPositionOffset = stockpile.StartPositionOffset;
				stockpileInDb.StartLuffingAngle = stockpile.StartLuffingAngle;
				stockpileInDb.ConeShellStepDistance = stockpile.ConeShellStepDistance;
				stockpileInDb.BenchHeight = stockpile.BenchHeight;
				stockpileInDb.BenchVolume = stockpile.BenchVolume;
				stockpileInDb.InitialLuffAngle = stockpile.InitialLuffAngle;
				stockpileInDb.InitialLongTravelPosition = stockpile.InitialLongTravelPosition;
				stockpileInDb.StackingRegimeIdentifier = stockpile.StackingRegimeIdentifier;
				stockpileInDb.StackingFormulaIdentifier = stockpile.StackingFormulaIdentifier;
				stockpileInDb.BLStartStackingDirection = stockpile.BLStartStackingDirection;
				stockpileInDb.BLStartReclaimingDirection = stockpile.BLStartReclaimingDirection;
				stockpileInDb.Bench1LuffAngle = stockpile.Bench1LuffAngle;
				stockpileInDb.ParBench1SlewAngle = stockpile.ParBench1SlewAngle;
				stockpileInDb.Bench1LongTravelPosition = stockpile.Bench1LongTravelPosition;
				stockpileInDb.Bench2LuffAngle = stockpile.Bench2LuffAngle;
				stockpileInDb.Bench2SlewAngle = stockpile.Bench2SlewAngle;
				stockpileInDb.Bench2LongTravelPosition = stockpile.Bench2LongTravelPosition;
				stockpileInDb.Bench3LuffAngle = stockpile.Bench3LuffAngle;
				stockpileInDb.Bench3SlewAngle = stockpile.Bench3SlewAngle;
				stockpileInDb.Bench3LongTravelPosition = stockpile.Bench3LongTravelPosition;
				stockpileInDb.StockpileLength = stockpile.StockpileLength;
				stockpileInDb.LongTravelStepLength = stockpile.LongTravelStepLength;
				stockpileInDb.PilgrimStepLength = stockpile.PilgrimStepLength;
				stockpileInDb.InnerSlewLimit = stockpile.InnerSlewLimit;
				stockpileInDb.OuterSlewLimit = stockpile.OuterSlewLimit;
				stockpileInDb.InnerSlewTurnaroundLimit = stockpile.InnerSlewTurnaroundLimit;
				stockpileInDb.OuterSlewTurnaroundLimit = stockpile.OuterSlewTurnaroundLimit;
				stockpileInDb.ReclaimRateSetpoint = stockpile.ReclaimRateSetpoint;
				stockpileInDb.InitialSlewAngle = stockpile.InitialSlewAngle;
				stockpileInDb.InitialSlewInnerTurnaroundLimit = stockpile.InitialSlewInnerTurnaroundLimit;
				stockpileInDb.InitialSlewOuterTurnaroundLimit = stockpile.InitialSlewOuterTurnaroundLimit;

				_context.SaveChanges();

				return RedirectToAction("Index", "Stockpiles");
			}
		}
	}
}