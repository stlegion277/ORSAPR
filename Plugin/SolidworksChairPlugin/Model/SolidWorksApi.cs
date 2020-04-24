using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
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

        private const string NameView = "Изометрия";

        private const string SelectionAxisType = "PLANE";

        private object IsThereSolidWorks()
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

        private void StartSolidWorks(object processSolidWorks)
        {
            _solidWorks = (SldWorks)processSolidWorks;
            _solidWorks.Visible = true;
        }

        private void DrawingRectangle(int xaxis, int yaxis, int center = 0)
        {
            _model.SketchManager.CreateCenterRectangle(center, 0, 0, xaxis, yaxis, 0);
        }
        public void BuildingModel(SolidWorksApi solidWorksApi)
        {
            object solidWorks = IsThereSolidWorks();
            StartSolidWorks(solidWorks);
        }

        private void CreateSolidWorksFile()
        {
            _solidWorks.NewPart();
            _model = _solidWorks.IActiveDoc2;
        }

        private void LayerSelection()
        {
            _model.Extension.SelectByID2(TopAxisName, SelectionAxisType, 0, 0, 0, false, 0, null, 0);
        }

        private void SketchSelection()
        {
            _model.SketchManager.InsertSketch(true);
        }

        private void SetIsometricView()
        {
            _model.ShowNamedView2(NameView, -1);
            _model.ViewZoomtofit2();
        }

        private void RemoveAllocations()
        {
            _model.ClearSelection2(true);
        }

        private void FigureCutBySketch(int height, bool upDirection = true)
        {

        }

        private void FigureElongationBySketch(int height)
        {

        }
    }
}
