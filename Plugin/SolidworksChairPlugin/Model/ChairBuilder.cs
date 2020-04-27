using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace SolidworksChairPlugin.Model
{
    class ChairBuilder
    {
        private ChairParameters _chairParameters;

        private SolidWorksApi _solidWorksApi;

        public ChairBuilder()
        {

        }

        private void CreateBond(BondParameters bondParameters)
        {

        }

        private void CreateSeat(SeatParameters seatParameters)
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.DrawingRectangle(seatParameters.Width, seatParameters.Length);
            _solidWorksApi.FigureElongationBySketch(seatParameters.Thickness);
            _solidWorksApi.FigureCutBySketch(seatParameters.Thickness, false);
            _solidWorksApi.RemoveAllocations();

        }

        private void CreateLeg(LegParameters legParameters, SeatParameters seatParameters)
        {
            _solidWorksApi.CoordinatesSelection(200, 200, 200);
            _solidWorksApi.LayerSelection(); 
            _solidWorksApi.DrawingRectangleForLegs(seatParameters.Width, legParameters.Width);
            _solidWorksApi.FigureElongationBySketch(legParameters.Height);
            _solidWorksApi.FigureCutBySketch(legParameters.Height, false);
            _solidWorksApi.RemoveAllocations();
        }

        public void CreateChair(ChairParameters chairParameters)
        {

        }

        public void ChairBuilding(ChairParameters chairParameters, SolidWorksApi solidWorksApi)
        {
            object solidWorks = solidWorksApi.IsThereSolidWorks();
            solidWorksApi.StartSolidWorks(solidWorks);
            _solidWorksApi = solidWorksApi;
            solidWorksApi.CreateSolidWorksFile();
            CreateSeat(chairParameters.SeatParameters);
            CreateLeg(chairParameters.LegParameters, chairParameters.SeatParameters);
        }

    }
}
