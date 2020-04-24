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

        private ChairBuilder _builder = new ChairBuilder();



        private void ClosingSolidWorksButton_Click(object sender, EventArgs e)
        {

        }

        private void BondParametersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void BuildStartButton_Click(object sender, EventArgs e)
        {
            ChairBuilder chairBuilder = new ChairBuilder();
            _builder.BuildingModel(chairBuilder);
        }
    }
}
