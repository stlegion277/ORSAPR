using SolidworksChairPlugin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private ChairParameters GetValuesFromTextBox()
        {
            ChairParameters chairParameters = new ChairParameters(new LegParameters(), 
                new SeatParameters(), new BondParameters());
            try
            {
                chairParameters.SeatParameters.Length = int.Parse(SeatLengthTextBox.Text);
                chairParameters.SeatParameters.Width = int.Parse(SeatLengthTextBox.Text);
                chairParameters.SeatParameters.Thickness = int.Parse(SeatThicknessTextBox.Text);
                chairParameters.LegParameters.Length = int.Parse(LegLengthTextBox.Text);
                chairParameters.LegParameters.Width = int.Parse(LegLengthTextBox.Text);
                chairParameters.LegParameters.Height = int.Parse(LegHeightTextBox.Text);
                chairParameters.BondParameters.SeatParameters = chairParameters.SeatParameters;
                chairParameters.BondParameters.LegParameters = chairParameters.LegParameters;
                chairParameters.BondParameters.Length = int.Parse(BondLengthTextBox.Text);
                chairParameters.BondParameters.Width = int.Parse(BondWidthTextBox.Text);
                chairParameters.BondParameters.Height = int.Parse(BondHeightTextBox.Text);
                return chairParameters;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.GetType());
                throw new Exception("Для того чтобы смоделировать табурет, необходимо заполнить все поля");
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
            _chairParameters = GetValuesFromTextBox();
           // _chairParameters.ValidateParameters();
            _chairBuilder.ChairBuilding(_chairParameters, _solidWorksApi);
           
        }

         private void TestValuesButton_Click(object sender, EventArgs e)
        {
            SeatLengthTextBox.Text = "320";
            SeatWidthTextBox.Text = "320";
            SeatThicknessTextBox.Text = "40";
            LegHeightTextBox.Text = "500";
            LegLengthTextBox.Text = "40";
            LegWidthTextBox.Text = "40";
            BondHeightTextBox.Text = "40";
            BondLengthTextBox.Text = "170";
            BondWidthTextBox.Text = "30";

        }
    }
}
