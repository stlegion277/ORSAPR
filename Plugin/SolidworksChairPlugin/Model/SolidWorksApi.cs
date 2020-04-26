﻿using SolidWorks.Interop.sldworks;
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

        private const string NameView = "Изометрия";

        private const string SelectionAxisType = "PLANE";

        private const string SelectionByPointsType = "FACE";

        private const string SketchName = "Эскиз";


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

        public void DrawingRectangleForLegs(int xaxis, int yaxis, int center = 0)
        {
            _model.SketchManager.CreateCornerRectangle(center, 0, 0, xaxis, yaxis, 0);
        }

        public void CreateSolidWorksFile()
        {
            _solidWorks.NewPart();
            _model = _solidWorks.IActiveDoc2;
        }

        public void LayerSelection()
        {
            _model.Extension.SelectByID2(TopAxisName, SelectionAxisType, 0, 0, 0, false, 0, null, 0);
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

        public void CoordinatesSelection(int Xaxis, int yAxis, int zAxis)
        {
            _model.Extension.SelectByID2(string.Empty, SelectionByPointsType, 40, 40, 40, false, 40, null, 0);
        }

        public void FigureCutBySketch(int height, bool upDirection = true)
        {
            _model.FeatureManager.FeatureCut4(true, false, upDirection, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);
        }

        public void FigureElongationBySketch(int height)
        {
            _model.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, height, 0.01, false, false, false, false,
               1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
        }

        public void SelectLayerByRay(int height)
        {
            _model.Extension.SelectByRay(0, height, 0, 1, height, 1, 1, 2, false, 0, 0);
        }

       // public void MirrorPart(int)
    }
}
