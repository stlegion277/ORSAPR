using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    /// <summary>
    /// Класс, хранящий методы SolidworksAPI 
    /// </summary>
    class SolidWorksApi
    {
        #region Параметры
        /// <summary>
        /// Обьект API solidworks
        /// </summary>
        private SldWorks _solidWorks;

        /// <summary>
        /// Обьект API проекта
        /// </summary>
        private IModelDoc2 _model;

        /// <summary>
        /// Переменные, которые нужны для изменения вида 
        /// </summary>
        private const string TopAxisName = "Сверху";

        private const string RightAxisName = "Справа";

        private const string NameView = "Изометрия";

        private const string SelectionAxisType = "PLANE";

        private const string SelectionByPointsType = "FACE";

        private const string SketchName = "Эскиз1";
        #endregion Параметры


        #region Методы SolidWorksAPI
        /// <summary>
        /// Метод, для закрытия solidworks по нажатию кнопки
        /// </summary>
        public void ClosingSolidWorks()
        {
            Process[] processes = Process.GetProcessesByName("SLDWORKS");
            foreach(Process process in processes)
            {
                process.CloseMainWindow();
                process.Kill();
            }
        }
        /// <summary>
        /// Метод проверяющий наличие solidworks на компьютере
        /// </summary>
        /// <returns></returns>
        public object IsThereSolidWorks()
        {
            try
            {
                Guid guid = new Guid("d134b411-3689-497d-b2d7-a27cb1066648");
                object processSolidWorks = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(guid));
                return processSolidWorks;
            }
            catch
            {
                throw new Exception("SolidWorks 2020 не найден на вашем компьютере");
            }
        }

        public void CreateChairBack(int xaxis, int yaxis)
        {
            _model.SketchManager.CreateCornerRectangle(xaxis / 2, xaxis / 2, 0, (xaxis / 2) - yaxis, (xaxis / 2) - yaxis, 0);
            _model.SketchManager.CreateCornerRectangle(0 - xaxis / 2, xaxis / 2 - yaxis, 0, yaxis - xaxis / 2, xaxis / 2, 0);
        }

        /// <summary>
        /// Метод запускающий solidworks
        /// </summary>
        /// <param name="processSolidWorks"></param>
        public void StartSolidWorks(object processSolidWorks)
        {
            _solidWorks = (SldWorks)processSolidWorks;
            _solidWorks.Visible = true;
        }

        /// <summary>
        /// Метод рисующий квадрат из центра (используется для построения сиденья)
        /// </summary>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <param name="center"></param>
        public void DrawingRectangle(int xaxis, int yaxis, int center = 0)
        {
            _model.SketchManager.CreateCenterRectangle(center, 0, 0, xaxis/2, yaxis/2, 0);
        }

        /// <summary>
        /// Метод, использующийся для построения ножек. Квадраты рисуются из угла.
        /// </summary>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        public void DrawingRectangleForLegs(int xaxis, int yaxis )
        {
            _model.SketchManager.CreateCornerRectangle(xaxis/2, xaxis/2, 0, (xaxis/2)-yaxis, (xaxis/2)-yaxis, 0);
            _model.SketchManager.CreateCornerRectangle(0 - xaxis / 2, 0 - xaxis / 2, 0,  yaxis-(xaxis / 2) , yaxis-(xaxis / 2), 0);
            _model.SketchManager.CreateCornerRectangle(xaxis / 2, yaxis - xaxis / 2, 0, xaxis/2 - yaxis, 0 - (xaxis / 2), 0);
            _model.SketchManager.CreateCornerRectangle(0 - xaxis / 2, xaxis / 2 - yaxis, 0, yaxis - xaxis/2, xaxis / 2, 0);

        }

        /// <summary>
        /// Метод, использующийся для построения связей. Квадраты рисуются из угла.
        /// </summary>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        public void DrawingRectangleForBonds(int xaxis, int yaxis)
        {
            _model.SketchManager.CreateCornerRectangle((0 - (xaxis/2)) + yaxis, -140, 0, 0 - xaxis/2, -160, 0);
            _model.SketchManager.CreateCornerRectangle(xaxis/2 - yaxis, -140, 0, xaxis /2, -160, 0);
        }

        public void DrawingRectangleForBondsOfChairBack(int xaxis, int yaxis)
        {
            _model.SketchManager.CreateCornerRectangle(xaxis / 2 - yaxis, 280, 0, xaxis / 2, 300, 0);
            _model.SketchManager.CreateCornerRectangle(xaxis / 2 - yaxis, 320, 0, xaxis / 2, 340, 0);
            _model.SketchManager.CreateCornerRectangle(xaxis / 2 - yaxis, 240, 0, xaxis / 2, 260, 0);

        }

        /// <summary>
        /// Метод, использующийся для построения связей по плоскости Z. 
        /// Отдельный метод понадобился из-за смены плоскостей, если пытаться рисовать связи 
        /// сразу после смены плоскости это приводит к ошибкам. 
        /// </summary>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        public void DrawingRectangleForBondsYOZ(int xaxis, int yaxis)
        {
            _model.SketchManager.CreateCornerRectangle((0 - (xaxis / 2)) + yaxis, -140, 0, 0 - xaxis / 2, -160, 0);
            _model.SketchManager.CreateCornerRectangle(xaxis / 2 - yaxis, -140, 0, xaxis / 2, -160, 0);
        }

        /// <summary>
        /// Метод, создающий файл в котором будет рисоваться деталь.
        /// </summary>
        public void CreateSolidWorksFile()
        {
            _solidWorks.NewPart();
            _model = _solidWorks.IActiveDoc2;
        }

        /// <summary>
        /// Выбор вида и плоскости
        /// </summary>
        public void LayerSelection()
        {
            _model.Extension.SelectByID2(TopAxisName, SelectionAxisType, 0, 0, 0, false, 0, null, 0);
        }

        /// <summary>
        /// Выбор вида специально для постройки связей
        /// </summary>
        public void LayerSelectionForBonds()
        {
            _model.Extension.SelectByID2(RightAxisName, SelectionAxisType, 0, 0, 0, false, 0, null, 0);
        }

        /// <summary>
        /// Выбор эскиза
        /// </summary>
        public void SketchSelection()
        {
            _model.SketchManager.InsertSketch(true);
        }

        /// <summary>
        /// Метод для изометрического вида
        /// </summary>
        public void SetIsometricView()
        {
            _model.ShowNamedView2(NameView, -1);
            _model.ViewZoomtofit2();
        }

        /// <summary>
        /// Снятие всех "меток" 
        /// </summary>
        public void RemoveAllocations()
        {
            _model.ClearSelection2(true);
        }

        /// <summary>
        /// Вырез фигуры по эскизу
        /// </summary>
        /// <param name="height"></param>
        /// <param name="upDirection"></param>
        public void FigureCutBySketch(int height, bool upDirection = false)
        {
            _model.FeatureManager.FeatureCut4(true, false, upDirection, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
        }

        /// <summary>
        /// Вытягивание фигуры по эскизу
        /// </summary>
        /// <param name="height"></param>
        public void FigureElongationBySketch(int height)
        {
            _model.FeatureManager.FeatureExtrusion2(true, false, true, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
        }

        /// <summary>
        /// Вытягивание фигуры по эскизу для связей. 
        /// Отдельный метод понадобился из-за разных меток true false.
        /// </summary>
        /// <param name="height"></param>
        public void FigureElongationBySketchForBonds(int height)
        {
            _model.FeatureManager.FeatureExtrusion2(false, false, true, -1, -1, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, false, -100, -100, true);
        }

        public void FigureElongationBySketchForChairBack(int height)
        {
            _model.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, height, height, false, false, false, false,
              1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
        }


        /// <summary>
        /// Меняет плоскость и оси
        /// </summary>
        /// <param name="height"></param>
        public void SelectLayerByRay(int height)
        {
            _model.Extension.SelectByRay(0, height, 0, 1, height, 1, 1, 2, false, 0, 0);
        }
        #endregion Методы SolidWorksAPI
    }
}
