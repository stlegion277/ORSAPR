using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidworksChairPlugin.Model
{
    class SolidWorksApi
    {
        private SldWorks _solidWorks;

        private IModelDoc2 _model;

        private const string TopAxisName = "Сверху";

        private const string SideAxisName = "Спереди";

        private const string NameView = "Изометрия";

        private const string SelectionAxisType = "PLANE";

        private const string SelectionByPointsType = "FACE";

        private const string SketchName = "Эскиз1";

        public void ClosingSolidWorks()
        {
            Process[] processes = Process.GetProcessesByName("SLDWORKS");
            foreach(Process process in processes)
            {
                process.CloseMainWindow();
                process.Kill();
            }
        }
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

        public void StartSolidWorks(object processSolidWorks)
        {
            _solidWorks = (SldWorks)processSolidWorks;
            _solidWorks.Visible = true;
        }

        public void DrawingRectangle(int xaxis, int yaxis, int center = 0)
        {
            _model.SketchManager.CreateCenterRectangle(center, 0, 0, xaxis/2, yaxis/2, 0);
        }

        public void DrawingRectangleForLegs(int xaxis, int yaxis )
        {
            _model.SketchManager.CreateCornerRectangle(xaxis/2, xaxis/2, 0, (xaxis/2)-yaxis, (xaxis/2)-yaxis, 0);
            _model.SketchManager.CreateCornerRectangle(0 - xaxis / 2, 0 - xaxis / 2, 0,  yaxis-(xaxis / 2) , yaxis-(xaxis / 2), 0);
            _model.SketchManager.CreateCornerRectangle(xaxis / 2, yaxis - xaxis / 2, 0, xaxis/2 - yaxis, 0 - (xaxis / 2), 0);
            _model.SketchManager.CreateCornerRectangle(0 - xaxis / 2, xaxis / 2 - yaxis, 0, yaxis - xaxis/2, xaxis / 2, 0);

        }

        public void DrawingRectangleForBonds(int xaxis, int yaxis)
        {
            
            _model.SketchManager.CreateCornerRectangle(-130, -140, 100, -150, -160, 100);
            _model.SketchManager.CreateCornerRectangle(130, -140, 0, 150, -160, 100);
            _model.SketchManager.CreateCornerRectangle(180, -35, 150, 200, -45, -45);

        }

        public void CreateSolidWorksFile()
        {
            _solidWorks.NewPart();
            _model = _solidWorks.IActiveDoc2;
        }

        public void LayerSelection()
        {
            _model.Extension.SelectByID2(TopAxisName, SelectionAxisType, 0, 0, 100, false, 0, null, 0);
        }

        public void SketchSelection()
        {
            _model.SketchManager.InsertSketch(true);
        }

        public void SetIsometricView()
        {
            _model.ShowNamedView2(NameView, -1);
            _model.ViewZoomtofit2();
        }

        public void RemoveAllocations()
        {
            _model.ClearSelection2(true);
        }

        public void FigureCutBySketch(int height, bool upDirection = false)
        {
            _model.FeatureManager.FeatureCut4(true, false, upDirection, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
        }

        public void FigureElongationBySketch(int height)
        {
            _model.FeatureManager.FeatureExtrusion2(true, false, true, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
        }

        public void FigureElongationBySketchForBonds(int height)
        {
            _model.FeatureManager.FeatureExtrusion2(false, false, true, -1, -1, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, false, -100, -100, true);
        }


        public void SelectLayerByRay(int height)
        {
            _model.Extension.SelectByRay(0, height, 0, 1, height, 1, 1, 2, false, 0, 0);
        }
    }
}
