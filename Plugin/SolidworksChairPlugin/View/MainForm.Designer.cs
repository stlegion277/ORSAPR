﻿namespace SolidworksChairPlugin
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LegLengthTextBox = new System.Windows.Forms.TextBox();
            this.LegWidthTextBox = new System.Windows.Forms.TextBox();
            this.LegHeightTextBox = new System.Windows.Forms.TextBox();
            this.SeatLengthTextBox = new System.Windows.Forms.TextBox();
            this.SeatWidthTextBox = new System.Windows.Forms.TextBox();
            this.SeatThicknessTextBox = new System.Windows.Forms.TextBox();
            this.BondLengthTextBox = new System.Windows.Forms.TextBox();
            this.BondWidthTextBox = new System.Windows.Forms.TextBox();
            this.BondHeightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BuildStartButton = new System.Windows.Forms.Button();
            this.ClosingSolidWorksButton = new System.Windows.Forms.Button();
            this.LegParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SeatParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.BondParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SeatLengthToolTIp = new System.Windows.Forms.ToolTip(this.components);
            this.SeatWidthToolTIp = new System.Windows.Forms.ToolTip(this.components);
            this.SeatThicknessToolTIp = new System.Windows.Forms.ToolTip(this.components);
            this.LegLengthToolTIp = new System.Windows.Forms.ToolTip(this.components);
            this.LegWidthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LegHeightToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BondLengthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BondWidthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BondHeightToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LegParametersGroupBox.SuspendLayout();
            this.SeatParametersGroupBox.SuspendLayout();
            this.BondParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "мм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Длина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ширина:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Высота:";
            // 
            // LegLengthTextBox
            // 
            this.LegLengthTextBox.Location = new System.Drawing.Point(83, 21);
            this.LegLengthTextBox.Name = "LegLengthTextBox";
            this.LegLengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.LegLengthTextBox.TabIndex = 6;
            this.LegLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // LegWidthTextBox
            // 
            this.LegWidthTextBox.Location = new System.Drawing.Point(83, 49);
            this.LegWidthTextBox.Name = "LegWidthTextBox";
            this.LegWidthTextBox.Size = new System.Drawing.Size(100, 22);
            this.LegWidthTextBox.TabIndex = 7;
            this.LegWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // LegHeightTextBox
            // 
            this.LegHeightTextBox.Location = new System.Drawing.Point(83, 77);
            this.LegHeightTextBox.Name = "LegHeightTextBox";
            this.LegHeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.LegHeightTextBox.TabIndex = 8;
            this.LegHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // SeatLengthTextBox
            // 
            this.SeatLengthTextBox.Location = new System.Drawing.Point(83, 27);
            this.SeatLengthTextBox.Multiline = true;
            this.SeatLengthTextBox.Name = "SeatLengthTextBox";
            this.SeatLengthTextBox.ShortcutsEnabled = false;
            this.SeatLengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.SeatLengthTextBox.TabIndex = 9;
            this.SeatLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // SeatWidthTextBox
            // 
            this.SeatWidthTextBox.Location = new System.Drawing.Point(83, 55);
            this.SeatWidthTextBox.Name = "SeatWidthTextBox";
            this.SeatWidthTextBox.Size = new System.Drawing.Size(100, 22);
            this.SeatWidthTextBox.TabIndex = 10;
            this.SeatWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // SeatThicknessTextBox
            // 
            this.SeatThicknessTextBox.Location = new System.Drawing.Point(83, 83);
            this.SeatThicknessTextBox.Name = "SeatThicknessTextBox";
            this.SeatThicknessTextBox.Size = new System.Drawing.Size(100, 22);
            this.SeatThicknessTextBox.TabIndex = 11;
            this.SeatThicknessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // BondLengthTextBox
            // 
            this.BondLengthTextBox.Location = new System.Drawing.Point(83, 18);
            this.BondLengthTextBox.Name = "BondLengthTextBox";
            this.BondLengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.BondLengthTextBox.TabIndex = 12;
            this.BondLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // BondWidthTextBox
            // 
            this.BondWidthTextBox.Location = new System.Drawing.Point(83, 46);
            this.BondWidthTextBox.Name = "BondWidthTextBox";
            this.BondWidthTextBox.Size = new System.Drawing.Size(100, 22);
            this.BondWidthTextBox.TabIndex = 13;
            this.BondWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // BondHeightTextBox
            // 
            this.BondHeightTextBox.Location = new System.Drawing.Point(83, 74);
            this.BondHeightTextBox.Name = "BondHeightTextBox";
            this.BondHeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.BondHeightTextBox.TabIndex = 14;
            this.BondHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Длина:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ширина:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Толщина:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Длина:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ширина:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Высота:";
            // 
            // BuildStartButton
            // 
            this.BuildStartButton.Location = new System.Drawing.Point(12, 384);
            this.BuildStartButton.Name = "BuildStartButton";
            this.BuildStartButton.Size = new System.Drawing.Size(233, 28);
            this.BuildStartButton.TabIndex = 21;
            this.BuildStartButton.Text = "Выполнить моделирование";
            this.BuildStartButton.UseVisualStyleBackColor = true;
            this.BuildStartButton.Click += new System.EventHandler(this.BuildStartButton_Click);
            // 
            // ClosingSolidWorksButton
            // 
            this.ClosingSolidWorksButton.Location = new System.Drawing.Point(12, 418);
            this.ClosingSolidWorksButton.Name = "ClosingSolidWorksButton";
            this.ClosingSolidWorksButton.Size = new System.Drawing.Size(233, 28);
            this.ClosingSolidWorksButton.TabIndex = 22;
            this.ClosingSolidWorksButton.Text = "Закрыть SolidWorks";
            this.ClosingSolidWorksButton.UseVisualStyleBackColor = true;
            this.ClosingSolidWorksButton.Click += new System.EventHandler(this.ClosingSolidWorksButton_Click);
            // 
            // LegParametersGroupBox
            // 
            this.LegParametersGroupBox.Controls.Add(this.label15);
            this.LegParametersGroupBox.Controls.Add(this.label14);
            this.LegParametersGroupBox.Controls.Add(this.label13);
            this.LegParametersGroupBox.Controls.Add(this.label4);
            this.LegParametersGroupBox.Controls.Add(this.label5);
            this.LegParametersGroupBox.Controls.Add(this.label6);
            this.LegParametersGroupBox.Controls.Add(this.LegLengthTextBox);
            this.LegParametersGroupBox.Controls.Add(this.LegWidthTextBox);
            this.LegParametersGroupBox.Controls.Add(this.LegHeightTextBox);
            this.LegParametersGroupBox.Location = new System.Drawing.Point(12, 136);
            this.LegParametersGroupBox.Name = "LegParametersGroupBox";
            this.LegParametersGroupBox.Size = new System.Drawing.Size(233, 118);
            this.LegParametersGroupBox.TabIndex = 23;
            this.LegParametersGroupBox.TabStop = false;
            this.LegParametersGroupBox.Text = "Ножка";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(189, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "мм";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "мм";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "мм";
            // 
            // SeatParametersGroupBox
            // 
            this.SeatParametersGroupBox.Controls.Add(this.label7);
            this.SeatParametersGroupBox.Controls.Add(this.label9);
            this.SeatParametersGroupBox.Controls.Add(this.label8);
            this.SeatParametersGroupBox.Controls.Add(this.SeatLengthTextBox);
            this.SeatParametersGroupBox.Controls.Add(this.SeatWidthTextBox);
            this.SeatParametersGroupBox.Controls.Add(this.SeatThicknessTextBox);
            this.SeatParametersGroupBox.Controls.Add(this.label2);
            this.SeatParametersGroupBox.Controls.Add(this.label3);
            this.SeatParametersGroupBox.Controls.Add(this.label1);
            this.SeatParametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SeatParametersGroupBox.Name = "SeatParametersGroupBox";
            this.SeatParametersGroupBox.Size = new System.Drawing.Size(233, 118);
            this.SeatParametersGroupBox.TabIndex = 24;
            this.SeatParametersGroupBox.TabStop = false;
            this.SeatParametersGroupBox.Text = "Сиденье";
            // 
            // BondParametersGroupBox
            // 
            this.BondParametersGroupBox.Controls.Add(this.label18);
            this.BondParametersGroupBox.Controls.Add(this.label17);
            this.BondParametersGroupBox.Controls.Add(this.label16);
            this.BondParametersGroupBox.Controls.Add(this.label10);
            this.BondParametersGroupBox.Controls.Add(this.BondLengthTextBox);
            this.BondParametersGroupBox.Controls.Add(this.BondWidthTextBox);
            this.BondParametersGroupBox.Controls.Add(this.label11);
            this.BondParametersGroupBox.Controls.Add(this.BondHeightTextBox);
            this.BondParametersGroupBox.Controls.Add(this.label12);
            this.BondParametersGroupBox.Location = new System.Drawing.Point(12, 260);
            this.BondParametersGroupBox.Name = "BondParametersGroupBox";
            this.BondParametersGroupBox.Size = new System.Drawing.Size(233, 118);
            this.BondParametersGroupBox.TabIndex = 25;
            this.BondParametersGroupBox.TabStop = false;
            this.BondParametersGroupBox.Text = "Связь";
            this.BondParametersGroupBox.Enter += new System.EventHandler(this.BondParametersGroupBox_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(189, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "мм";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 17);
            this.label17.TabIndex = 22;
            this.label17.Text = "мм";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(189, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "мм";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(259, 462);
            this.Controls.Add(this.BondParametersGroupBox);
            this.Controls.Add(this.SeatParametersGroupBox);
            this.Controls.Add(this.LegParametersGroupBox);
            this.Controls.Add(this.ClosingSolidWorksButton);
            this.Controls.Add(this.BuildStartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Мой табурет";
            this.LegParametersGroupBox.ResumeLayout(false);
            this.LegParametersGroupBox.PerformLayout();
            this.SeatParametersGroupBox.ResumeLayout(false);
            this.SeatParametersGroupBox.PerformLayout();
            this.BondParametersGroupBox.ResumeLayout(false);
            this.BondParametersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LegLengthTextBox;
        private System.Windows.Forms.TextBox LegWidthTextBox;
        private System.Windows.Forms.TextBox LegHeightTextBox;
        private System.Windows.Forms.TextBox SeatLengthTextBox;
        private System.Windows.Forms.TextBox SeatWidthTextBox;
        private System.Windows.Forms.TextBox SeatThicknessTextBox;
        private System.Windows.Forms.TextBox BondLengthTextBox;
        private System.Windows.Forms.TextBox BondWidthTextBox;
        private System.Windows.Forms.TextBox BondHeightTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BuildStartButton;
        private System.Windows.Forms.Button ClosingSolidWorksButton;
        private System.Windows.Forms.GroupBox LegParametersGroupBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox SeatParametersGroupBox;
        private System.Windows.Forms.GroupBox BondParametersGroupBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip SeatLengthToolTIp;
        private System.Windows.Forms.ToolTip SeatWidthToolTIp;
        private System.Windows.Forms.ToolTip SeatThicknessToolTIp;
        private System.Windows.Forms.ToolTip LegLengthToolTIp;
        private System.Windows.Forms.ToolTip LegWidthToolTip;
        private System.Windows.Forms.ToolTip LegHeightToolTip;
        private System.Windows.Forms.ToolTip BondLengthToolTip;
        private System.Windows.Forms.ToolTip BondWidthToolTip;
        private System.Windows.Forms.ToolTip BondHeightToolTip;
    }
}

