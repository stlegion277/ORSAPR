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
        private SldWorks solidWorks;

        private IModelDoc2 model;


        private object IsThereSolidWorks()
        {
            try
            {
                Guid Guid = new Guid("d134b411-3689-497d-b2d7-a27cb1066648");
                object processSolidWorks = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(Guid));
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

        public void BuildingModel(ChairBuilder chairBuilder)
        {
            object solidWorks = IsThereSolidWorks();
            StartSolidWorks(solidWorks);
        }
    }
}
