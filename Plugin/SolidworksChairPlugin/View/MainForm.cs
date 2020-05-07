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

        #region Параметры
        private ChairParameters _chairParameters;


        private SolidWorksApi _solidWorksApi = new SolidWorksApi();


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
        /// <summary>
        /// Тултипы нужны для того чтобы высвечивались подсказки в тексбоксах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region ToolTipActions
        private void SeatLengthTextBox_Enter(object sender, EventArgs e)
        {
            SeatLengthToolTIp.Show("Длина и ширина сидушки должны быть равны", SeatLengthTextBox);
        }

        private void SeatLengthTextBox_Leave(object sender, EventArgs e)
        {
            SeatLengthToolTIp.Hide(SeatLengthTextBox);
        }

        private void SeatWidthTextBox_Enter(object sender, EventArgs e)
        {
            SeatWidthToolTIp.Show("Длина и ширина сидушки должны быть равны", SeatWidthTextBox);
        }

        private void SeatWidthTextBox_Leave(object sender, EventArgs e)
        {
            SeatWidthToolTIp.Hide(SeatWidthTextBox);
        }

        private void SeatThicknessTextBox_Enter(object sender, EventArgs e)
        {
            SeatThicknessToolTIp.Show("Толщина сидушки не должна быть меньше 40-а и больше 100-а", SeatThicknessTextBox);
        }

        private void SeatThicknessTextBox_Leave(object sender, EventArgs e)
        {
            SeatThicknessToolTIp.Hide(SeatThicknessTextBox);
        }

        private void LegLengthTextBox_Enter(object sender, EventArgs e)
        {
            LegLengthToolTIp.Show("Длина ножки не может быть меньше 40-а и больше 100-а", LegLengthTextBox);
        }

        private void LegLengthTextBox_Leave(object sender, EventArgs e)
        {
            LegLengthToolTIp.Hide(LegLengthTextBox);
        }

        private void LegWidthTextBox_Enter(object sender, EventArgs e)
        {
            LegWidthToolTip.Show("Длина и ширина ножки должны быть равны", LegWidthTextBox);
        }

        private void LegWidthTextBox_Leave(object sender, EventArgs e)
        {
            LegWidthToolTip.Hide(LegWidthTextBox);
        }

        private void LegHeightTextBox_Enter(object sender, EventArgs e)
        {
            LegHeightToolTip.Show("Высота ножки должна быть не меньше 500-а и больше 1000-и", LegHeightTextBox);
        }

        private void LegHeightTextBox_Leave(object sender, EventArgs e)
        {
            LegHeightToolTip.Hide(LegHeightTextBox);
        }

        private void BondLengthTextBox_Enter(object sender, EventArgs e)
        {
            BondLengthToolTip.Show("Длина связи должна быть равна расстоянию между ножек табурета, " +
                "Формула: Длина связи = Ширина сиденья - ширина ножки * 2", 
                BondLengthTextBox);
        }

        private void BondLengthTextBox_Leave(object sender, EventArgs e)
        {
            BondHeightToolTip.Hide(BondLengthTextBox);
        }

        private void BondWidthTextBox_Enter(object sender, EventArgs e)
        {
            BondWidthToolTip.Show("Ширина связи должна быть равна высоте " +
                "связи и не может быть шире самой ножки",
                   BondWidthTextBox);

        }

        private void BondWidthTextBox_Leave(object sender, EventArgs e)
        {
            BondWidthToolTip.Hide(BondWidthTextBox);
        }

        private void BondHeightTextBox_Enter(object sender, EventArgs e)
        {
            BondHeightToolTip.Show("Высота связи должна быть равна ширине связи и" +
                "не может быть выше ножки табурета",
                   BondHeightTextBox);
        }

        private void BondHeightTextBox_Leave(object sender, EventArgs e)
        {
            BondHeightToolTip.Hide(BondHeightTextBox);
        }
        #endregion ToolTipActions
    }
}
