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
        /// <summary>
        /// Обьект класса solidworksapi
        /// </summary>
        private SolidWorksApi _solidWorksApi;

        /// <summary>
        /// Конструктор класса ChairBuilder
        /// </summary>
        public ChairBuilder()
        {

        }

        #region Методы построения табурета
        /// <summary>
        /// Метод который создает связи
        /// </summary>
        /// <param name="bondParameters">Параметры связей</param>
        /// <param name="seatParameters">Параметры сидушки</param>
        /// <param name="legParameters">Параметры ножек</param>
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

        /// <summary>
        /// Метод, рисующий спинку табурета (опционально)
        /// </summary>
        /// <param name="seatParameters">параметры сидушки</param>
        /// <param name="legParameters">параметры ножки</param>
        /// <param name="bondParameters">параметры связей</param>
        public void CreateChairBack(SeatParameters seatParameters, LegParameters 
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
        /// <param name="seatParameters">Параметры сидушки</param>
        private void CreateSeat(SeatParameters seatParameters)
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangle(seatParameters.Width, seatParameters.Length);
            _solidWorksApi.FigureElongationBySketch(seatParameters.Thickness);
            _solidWorksApi.RemoveAllocations();

        }

        /// <summary>
        /// Метод который создает ножки
        /// </summary>
        /// <param name="legParameters">Параметры ножек</param>
        /// <param name="seatParameters">Параметры сидушки</param>
        private void CreateLeg(LegParameters legParameters, SeatParameters seatParameters)
        {
            _solidWorksApi.LayerSelection();
            _solidWorksApi.SketchSelection();
            _solidWorksApi.DrawingRectangleForLegs(seatParameters.Width, legParameters.Width);
            _solidWorksApi.FigureElongationBySketch(legParameters.Height);
            _solidWorksApi.RemoveAllocations();
        }

        /// <summary>
        /// Метод обьединяющий все остальные методы по постройке табурета
        /// </summary>
        /// <param name="chairParameters">Параметры всего табурета</param>
        /// <param name="solidWorksApi">Обьект класса solidworks</param>
        public void ChairBuilding(ChairParameters chairParameters, SolidWorksApi solidWorksApi)
        {
            object solidWorks = solidWorksApi.IsThereSolidWorks();
            solidWorksApi.StartSolidWorks(solidWorks);
            _solidWorksApi = solidWorksApi;
            solidWorksApi.CreateSolidWorksFile();
            CreateSeat(chairParameters.SeatParameters);
            CreateLeg(chairParameters.LegParameters, chairParameters.SeatParameters);
            CreateBond(chairParameters.BondParameters, chairParameters.SeatParameters, 
                chairParameters.LegParameters);
        }
        #endregion Методы построения табурета

    }
}
