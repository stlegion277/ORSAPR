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


        private ChairParameters _chairParameters;
        private SolidWorksApi _solidWorksApi = new SolidWorksApi();

        private ChairBuilder _chairBuilder = new ChairBuilder();


        private void KeyPressOnlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void ClosingSolidWorksButton_Click(object sender, EventArgs e)
        {
            _solidWorksApi.ClosingSolidWorks();
        }

        private void BondParametersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void BuildStartButton_Click(object sender, EventArgs e)
        {
            _chairBuilder.ChairBuilding(_chairParameters, _solidWorksApi);
           
        }
    }
}
