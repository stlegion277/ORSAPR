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
        private SldWorks solidWorks;

        private IModelDoc2 model;


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
            solidWorks = (SldWorks)processSolidWorks;
            solidWorks.Visible = true;
        }

        public void BuildingModel(SolidWorksApi solidWorksApi)
        {
            object solidWorks = IsThereSolidWorks();
            StartSolidWorks(solidWorks);
        }

        private void CreateSolidWorksFile()
        {
            solidWorks.NewPart();
            model = solidWorks.IActiveDoc2;
        }


    }
}
