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
           // _solidWorksApi.CreateSolidWorksFile();
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangle(seatParameters.Width, seatParameters.Length);
            _solidWorksApi.FigureElongationBySketch(seatParameters.Thickness);
           // _solidWorksApi.SelectLayerByRay(seatParameters.Thickness);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.FigureCutBySketch(seatParameters.Thickness, false);
            _solidWorksApi.RemoveAllocations();

        }

        private void CreateLeg(LegParameters legParameters)
        {
           // _solidWorksApi.CreateSolidWorksFile();
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.CoordinatesSelection(-400, -440, 440);
            _solidWorksApi.DrawingRectangleForLegs(legParameters.Width, legParameters.Length);
            _solidWorksApi.FigureElongationBySketch(legParameters.Height);
            // _solidWorksApi.SelectLayerByRay(seatParameters.Thickness);
            _solidWorksApi.SketchSelection();
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
            CreateLeg(chairParameters.LegParameters);
            CreateSeat(chairParameters.SeatParameters);
        }

    }
}
