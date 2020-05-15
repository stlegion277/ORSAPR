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
    /// <summary>
    /// Класс, хранящий в себе методы выполняющиеся на форме
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #region Параметры

        /// <summary>
        /// Обьект класса ChairParameters
        /// </summary>
        private ChairParameters _chairParameters;

        /// <summary>
        /// Команды API SolidWorks
        /// </summary>
        private SolidWorksApi _solidWorksApi = new SolidWorksApi();

        /// <summary>
        /// Строитель табурета
        /// </summary>
        private ChairBuilder _chairBuilder = new ChairBuilder();
        #endregion Параметры

        #region Методы выполняющиеся через кнопки, текстбоксы
        /// <summary>
        /// Метод блокирующий ввод символов и всякого ненужного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPressOnlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Здесь мы берем значения из текстбоксов
        /// </summary>
        /// <returns></returns>
        private ChairParameters GetValuesFromTextBox()
        {
            ChairParameters chairParameters = new ChairParameters(new LegParameters(), 
                new SeatParameters(), new BondParameters());
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

        /// <summary>
        /// Кнопочка закрытия solidworks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosingSolidWorksButton_Click(object sender, EventArgs e)
        {
            _solidWorksApi.ClosingSolidWorks();
        }

        /// <summary>
        /// Кнопочка построения моделирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildStartButton_Click(object sender, EventArgs e)
        {
            bool isValuesRight = true;
            try
            {
                isValuesRight = true;
                _chairParameters = GetValuesFromTextBox();
            }
            catch
            {
                isValuesRight = false;
                MessageBox.Show("Чтобы смоделировать табурет, необходимо ввести корректные данные", 
                    "OutOfRange", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (isValuesRight)
            {
                _chairBuilder.ChairBuilding(_chairParameters, _solidWorksApi);
                if (ChairBackCheckBox.Checked == true)
                {
                    _chairBuilder.CreateChairBack(_chairParameters.SeatParameters, _chairParameters.
                        LegParameters, _chairParameters.BondParameters);
                }
               
            }
           
        }

        /// <summary>
        /// Значения по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void TestValuesButton_Click(object sender, EventArgs e)
        {
            SeatLengthTextBox.Text = "320";
            SeatWidthTextBox.Text = "320";
            SeatThicknessTextBox.Text = "40";
            LegHeightTextBox.Text = "500";
            LegLengthTextBox.Text = "40";
            LegWidthTextBox.Text = "40";
            BondHeightTextBox.Text = "40";
            BondLengthTextBox.Text = "240";
            BondWidthTextBox.Text = "40";

        }

        #endregion Методы выполняющиеся через кнопки, текстбоксы
    }
}
