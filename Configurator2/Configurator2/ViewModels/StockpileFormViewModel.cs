using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Configurator2.ViewModels {

	public class StockpileFormViewModel {


		public int StockpileIdentifier { get; set; }
		public string StockpileName { get; set; }
		public double? StockpileCapacity { get; set; }
		public int StockpileServiceTypeIdentifier { get; set; }
		public double? StockpileStartLimit { get; set; }
		public double? StockpileCentreLimit { get; set; }
		public double? StockpileEndLimit { get; set; }
		public int PlannedBuildProductIdentifier { get; set; }
		public double? BuildAngleOfRepose { get; set; }
		public int? StackerNo { get; set; }
		public int? ReclaimerQuadrant { get; set; }
		public double? StartPositionOffset { get; set; }
		public double? StartLuffingAngle { get; set; }
		public double? ConeShellStepDistance { get; set; }
		public double? BenchHeight { get; set; }
		public double? BenchVolume { get; set; }
		public double? InitialLuffAngle { get; set; }
		public double? InitialLongTravelPosition { get; set; }
		public int? StackingRegimeIdentifier { get; set; }
		public bool StackingFormulaIdentifier { get; set; }
		public bool BLStartStackingDirection { get; set; }
		public bool BLStartReclaimingDirection { get; set; }
		public double? Bench1LuffAngle { get; set; }
		public double? ParBench1SlewAngle { get; set; }
		public double? Bench1LongTravelPosition { get; set; }
		public double? Bench2LuffAngle { get; set; }
		public double? Bench2SlewAngle { get; set; }
		public double? Bench2LongTravelPosition { get; set; }
		public double? Bench3LuffAngle { get; set; }
		public double? Bench3SlewAngle { get; set; }
		public double? Bench3LongTravelPosition { get; set; }
		public double? StockpileLength { get; set; }
		public double? LongTravelStepLength { get; set; }
		public double? PilgrimStepLength { get; set; }
		public double? InnerSlewLimit { get; set; }
		public double? OuterSlewLimit { get; set; }
		public double? InnerSlewTurnaroundLimit { get; set; }
		public double? OuterSlewTurnaroundLimit { get; set; }
		public double? ReclaimRateSetpoint { get; set; }
		public double? InitialSlewAngle { get; set; }
		public double? InitialSlewInnerTurnaroundLimit { get; set; }
		public double? InitialSlewOuterTurnaroundLimit { get; set; }
	}
}