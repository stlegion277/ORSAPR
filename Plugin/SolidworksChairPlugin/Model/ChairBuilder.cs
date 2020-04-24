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

        public ChairBuilder(SolidWorksApi solidWorksApi, ChairParameters chairParameters)
        {

        }

        private void CreateBond(BondParameters bondParameters)
        {

        }

        private void CreateSeat(SeatParameters seatParameters)
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangle(seatParameters.Width, seatParameters.Length);
            _solidWorksApi.FigureElongationBySketch(seatParameters.Thickness);
            _solidWorksApi.SelectLayerByRay(seatParameters.Thickness);
            _solidWorksApi.SketchSelection();
            _solidWorksApi.FigureCutBySketch(seatParameters.Thickness, false);
            _solidWorksApi.RemoveAllocations();
        }

        private void CreateLeg(LegParameters legParameters)
        {

        }

        public void CreateChair(ChairParameters chairParameters)
        {

        }

        public void ChairBuilding(ChairParameters chairParameters, SolidWorksApi solidWorksApi)
        {
            object solidWorks = solidWorksApi.IsThereSolidWorks();
            solidWorksApi.StartSolidWorks(solidWorks);
        }

    }
}
