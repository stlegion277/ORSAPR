using SolidworksChairPlugin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidworksChairPlugin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ChairBuilder _chairBuilder;

        private ChairParameters _chairParameters;

        private SolidWorksApi _solidWorksApi;




        private void ClosingSolidWorksButton_Click(object sender, EventArgs e)
        {

        }

        private void BondParametersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void BuildStartButton_Click(object sender, EventArgs e)
        {
            SolidWorksApi solidWorksApi = new SolidWorksApi();
            solidWorksApi.BuildingModel(solidWorksApi);
           
        }
    }
}
