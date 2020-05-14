using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace SolidworksChairPlugin.Model
{
    /// <summary>
    /// Класс строящий табурет посредством методов с solidworksAPI
    /// </summary>
    class ChairBuilder
    {
        private ChairParameters _chairParameters;

        private SolidWorksApi _solidWorksApi;

        public ChairBuilder()
        {

        }

        #region Методы построения табурета
        /// <summary>
        /// Метод который создает связи
        /// </summary>
        /// <param name="bondParameters"></param>
        /// <param name="seatParameters"></param>
        /// <param name="legParameters"></param>
        private void CreateBond(BondParameters bondParameters, SeatParameters 
            seatParameters, LegParameters legParameters)
        {
            _solidWorksApi.LayerSelectionForBonds();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangleForBonds(seatParameters.Width, bondParameters.Width);
            _solidWorksApi.FigureElongationBySketchForBonds(bondParameters.Length);
            _solidWorksApi.SelectLayerByRay(legParameters.Height);
            _solidWorksApi.DrawingRectangleForBondsYOZ(seatParameters.Width, bondParameters.Width);
            _solidWorksApi.FigureElongationBySketchForBonds(bondParameters.Length);
            _solidWorksApi.RemoveAllocations();
        }

        private void CreateChairBack(SeatParameters seatParameters, LegParameters 
            legParameters, BondParameters bondParameters)
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.CreateChairBack(seatParameters.Width, legParameters.Width);
            _solidWorksApi.FigureElongationBySketchForChairBack(legParameters.Height-100);
            _solidWorksApi.LayerSelectionForBonds();
            _solidWorksApi.SelectLayerByRay(legParameters.Height);
            _solidWorksApi.DrawingRectangleForBondsOfChairBack(seatParameters.Width,bondParameters.Width);
            _solidWorksApi.FigureElongationBySketchForBonds(bondParameters.Length);
            _solidWorksApi.RemoveAllocations();
        }

        /// <summary>
        /// Метод который создает сиденье
        /// </summary>
        /// <param name="seatParameters"></param>
        private void CreateSeat(SeatParameters seatParameters)
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangle(seatParameters.Width, seatParameters.Length);
            _solidWorksApi.FigureElongationBySketch(seatParameters.Thickness);
            _solidWorksApi.FigureCutBySketch(seatParameters.Thickness, false);
            _solidWorksApi.RemoveAllocations();

        }

        /// <summary>
        /// Метод который создает ножки
        /// </summary>
        /// <param name="legParameters"></param>
        /// <param name="seatParameters"></param>
        private void CreateLeg(LegParameters legParameters, SeatParameters seatParameters)
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangleForLegs(seatParameters.Width, legParameters.Width);
            _solidWorksApi.FigureElongationBySketch(legParameters.Height);
            _solidWorksApi.FigureCutBySketch(legParameters.Height, false);
            _solidWorksApi.RemoveAllocations();
        }

        public void ChairBuilding(ChairParameters chairParameters, SolidWorksApi solidWorksApi)
        {
            object solidWorks = solidWorksApi.IsThereSolidWorks();
            solidWorksApi.StartSolidWorks(solidWorks);
            _solidWorksApi = solidWorksApi;
            solidWorksApi.CreateSolidWorksFile();
            CreateSeat(chairParameters.SeatParameters);
            CreateLeg(chairParameters.LegParameters, chairParameters.SeatParameters);
            CreateBond(chairParameters.BondParameters, chairParameters.SeatParameters, chairParameters.LegParameters);
            CreateChairBack(chairParameters.SeatParameters, chairParameters.LegParameters, chairParameters.BondParameters);
        }
        #endregion Методы построения табурета

    }
}
