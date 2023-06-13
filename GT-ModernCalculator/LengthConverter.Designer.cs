﻿namespace GT_ModernCalculator
{
    partial class LengthConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LengthConverter));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtMilimeter = new TextBox();
            TxtCentimeter = new TextBox();
            TxtInch = new TextBox();
            TxtMeter = new TextBox();
            TxtFoot = new TextBox();
            TxtKilometer = new TextBox();
            TxtMile = new TextBox();
            BtnMenuL = new Button();
            LabelVersionL = new Label();
            panelSidebarL = new Panel();
            BtnLengthL = new Button();
            BtnFormTempL = new Button();
            BtnFormScienceL = new Button();
            BtnFormCalculatorL = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            panelSidebarL.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 131);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Centimeters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(97, 80);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Milimiters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(97, 182);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Inches";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 233);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Meters";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(97, 284);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 4;
            label5.Text = "Foot";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(97, 335);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 5;
            label6.Text = "Kilomters";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(97, 386);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 6;
            label7.Text = "Miles";
            // 
            // TxtMilimeter
            // 
            TxtMilimeter.BackColor = Color.FromArgb(32, 32, 32);
            TxtMilimeter.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMilimeter.ForeColor = Color.White;
            TxtMilimeter.Location = new Point(258, 78);
            TxtMilimeter.Name = "TxtMilimeter";
            TxtMilimeter.Size = new Size(166, 27);
            TxtMilimeter.TabIndex = 7;
            TxtMilimeter.Text = "0";
            TxtMilimeter.TextAlign = HorizontalAlignment.Right;
            TxtMilimeter.TextChanged += LengthTextChanged;
            // 
            // TxtCentimeter
            // 
            TxtCentimeter.BackColor = Color.FromArgb(32, 32, 32);
            TxtCentimeter.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCentimeter.ForeColor = Color.White;
            TxtCentimeter.Location = new Point(258, 131);
            TxtCentimeter.Name = "TxtCentimeter";
            TxtCentimeter.Size = new Size(166, 27);
            TxtCentimeter.TabIndex = 8;
            TxtCentimeter.Text = "0";
            TxtCentimeter.TextAlign = HorizontalAlignment.Right;
            TxtCentimeter.TextChanged += LengthTextChanged;
            // 
            // TxtInch
            // 
            TxtInch.BackColor = Color.FromArgb(32, 32, 32);
            TxtInch.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtInch.ForeColor = Color.White;
            TxtInch.Location = new Point(258, 182);
            TxtInch.Name = "TxtInch";
            TxtInch.Size = new Size(166, 27);
            TxtInch.TabIndex = 9;
            TxtInch.Text = "0";
            TxtInch.TextAlign = HorizontalAlignment.Right;
            TxtInch.TextChanged += LengthTextChanged;
            // 
            // TxtMeter
            // 
            TxtMeter.BackColor = Color.FromArgb(32, 32, 32);
            TxtMeter.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMeter.ForeColor = Color.White;
            TxtMeter.Location = new Point(258, 233);
            TxtMeter.Name = "TxtMeter";
            TxtMeter.Size = new Size(166, 27);
            TxtMeter.TabIndex = 10;
            TxtMeter.Text = "0";
            TxtMeter.TextAlign = HorizontalAlignment.Right;
            TxtMeter.TextChanged += LengthTextChanged;
            // 
            // TxtFoot
            // 
            TxtFoot.BackColor = Color.FromArgb(32, 32, 32);
            TxtFoot.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtFoot.ForeColor = Color.White;
            TxtFoot.Location = new Point(258, 284);
            TxtFoot.Name = "TxtFoot";
            TxtFoot.Size = new Size(166, 27);
            TxtFoot.TabIndex = 11;
            TxtFoot.Text = "0";
            TxtFoot.TextAlign = HorizontalAlignment.Right;
            TxtFoot.TextChanged += LengthTextChanged;
            // 
            // TxtKilometer
            // 
            TxtKilometer.BackColor = Color.FromArgb(32, 32, 32);
            TxtKilometer.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKilometer.ForeColor = Color.White;
            TxtKilometer.Location = new Point(258, 335);
            TxtKilometer.Name = "TxtKilometer";
            TxtKilometer.Size = new Size(166, 27);
            TxtKilometer.TabIndex = 12;
            TxtKilometer.Text = "0";
            TxtKilometer.TextAlign = HorizontalAlignment.Right;
            TxtKilometer.TextChanged += LengthTextChanged;
            // 
            // TxtMile
            // 
            TxtMile.BackColor = Color.FromArgb(32, 32, 32);
            TxtMile.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMile.ForeColor = Color.White;
            TxtMile.Location = new Point(258, 386);
            TxtMile.Name = "TxtMile";
            TxtMile.Size = new Size(166, 27);
            TxtMile.TabIndex = 13;
            TxtMile.Text = "0";
            TxtMile.TextAlign = HorizontalAlignment.Right;
            TxtMile.TextChanged += LengthTextChanged;
            // 
            // BtnMenuL
            // 
            BtnMenuL.BackColor = Color.FromArgb(32, 32, 32);
            BtnMenuL.FlatAppearance.BorderSize = 0;
            BtnMenuL.FlatStyle = FlatStyle.Flat;
            BtnMenuL.Image = (Image)resources.GetObject("BtnMenuL.Image");
            BtnMenuL.Location = new Point(9, 9);
            BtnMenuL.Margin = new Padding(0);
            BtnMenuL.Name = "BtnMenuL";
            BtnMenuL.Size = new Size(63, 50);
            BtnMenuL.TabIndex = 14;
            toolTip1.SetToolTip(BtnMenuL, "Menu");
            BtnMenuL.UseVisualStyleBackColor = false;
            // 
            // LabelVersionL
            // 
            LabelVersionL.AutoSize = true;
            LabelVersionL.FlatStyle = FlatStyle.Flat;
            LabelVersionL.Font = new Font("Ubuntu Light", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            LabelVersionL.ForeColor = Color.White;
            LabelVersionL.Location = new Point(151, 436);
            LabelVersionL.Margin = new Padding(0);
            LabelVersionL.Name = "LabelVersionL";
            LabelVersionL.Size = new Size(18, 21);
            LabelVersionL.TabIndex = 32;
            LabelVersionL.Text = "0";
            // 
            // panelSidebarL
            // 
            panelSidebarL.BackColor = Color.FromArgb(24, 24, 24);
            panelSidebarL.Controls.Add(BtnLengthL);
            panelSidebarL.Controls.Add(BtnFormTempL);
            panelSidebarL.Controls.Add(BtnFormScienceL);
            panelSidebarL.Controls.Add(BtnFormCalculatorL);
            panelSidebarL.Location = new Point(0, 62);
            panelSidebarL.Name = "panelSidebarL";
            panelSidebarL.Size = new Size(72, 404);
            panelSidebarL.TabIndex = 33;
            panelSidebarL.Visible = false;
            // 
            // BtnLengthL
            // 
            BtnLengthL.FlatAppearance.BorderSize = 0;
            BtnLengthL.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnLengthL.FlatStyle = FlatStyle.Flat;
            BtnLengthL.Image = (Image)resources.GetObject("BtnLengthL.Image");
            BtnLengthL.Location = new Point(0, 243);
            BtnLengthL.Name = "BtnLengthL";
            BtnLengthL.Size = new Size(69, 70);
            BtnLengthL.TabIndex = 3;
            toolTip5.SetToolTip(BtnLengthL, "Length Converter");
            BtnLengthL.UseVisualStyleBackColor = true;
            // 
            // BtnFormTempL
            // 
            BtnFormTempL.FlatAppearance.BorderSize = 0;
            BtnFormTempL.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormTempL.FlatStyle = FlatStyle.Flat;
            BtnFormTempL.Image = (Image)resources.GetObject("BtnFormTempL.Image");
            BtnFormTempL.Location = new Point(0, 167);
            BtnFormTempL.Name = "BtnFormTempL";
            BtnFormTempL.Size = new Size(69, 70);
            BtnFormTempL.TabIndex = 2;
            toolTip4.SetToolTip(BtnFormTempL, "Temperature Converter");
            BtnFormTempL.UseVisualStyleBackColor = true;
            BtnFormTempL.Click += BtnTemperature_Click;
            // 
            // BtnFormScienceL
            // 
            BtnFormScienceL.FlatAppearance.BorderSize = 0;
            BtnFormScienceL.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormScienceL.FlatStyle = FlatStyle.Flat;
            BtnFormScienceL.Image = (Image)resources.GetObject("BtnFormScienceL.Image");
            BtnFormScienceL.Location = new Point(0, 84);
            BtnFormScienceL.Name = "BtnFormScienceL";
            BtnFormScienceL.Size = new Size(69, 70);
            BtnFormScienceL.TabIndex = 1;
            toolTip3.SetToolTip(BtnFormScienceL, "Scientific Calculator");
            BtnFormScienceL.UseVisualStyleBackColor = true;
            BtnFormScienceL.Click += BtnScience_Click;
            // 
            // BtnFormCalculatorL
            // 
            BtnFormCalculatorL.FlatAppearance.BorderSize = 0;
            BtnFormCalculatorL.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormCalculatorL.FlatStyle = FlatStyle.Flat;
            BtnFormCalculatorL.Image = (Image)resources.GetObject("BtnFormCalculatorL.Image");
            BtnFormCalculatorL.Location = new Point(0, 0);
            BtnFormCalculatorL.Name = "BtnFormCalculatorL";
            BtnFormCalculatorL.Size = new Size(69, 70);
            BtnFormCalculatorL.TabIndex = 0;
            toolTip2.SetToolTip(BtnFormCalculatorL, "Standard Calculator");
            BtnFormCalculatorL.UseVisualStyleBackColor = true;
            BtnFormCalculatorL.Click += BtnStandard_Click;
            // 
            // LengthConverter
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(453, 466);
            Controls.Add(panelSidebarL);
            Controls.Add(LabelVersionL);
            Controls.Add(BtnMenuL);
            Controls.Add(TxtMile);
            Controls.Add(TxtKilometer);
            Controls.Add(TxtFoot);
            Controls.Add(TxtMeter);
            Controls.Add(TxtInch);
            Controls.Add(TxtCentimeter);
            Controls.Add(TxtMilimeter);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "LengthConverter";
            Text = "Length Converter mode";
            FormClosing += LengthConverter_FormClosing;
            panelSidebarL.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtMilimeter;
        private TextBox TxtCentimeter;
        private TextBox TxtInch;
        private TextBox TxtMeter;
        private TextBox TxtFoot;
        private TextBox TxtKilometer;
        private TextBox TxtMile;
        private Button BtnMenuL;
        private Label LabelVersionL;
        private Panel panelSidebarL;
        private Button BtnLengthL;
        private Button BtnFormTempL;
        private Button BtnFormScienceL;
        private Button BtnFormCalculatorL;
        private ToolTip toolTip1;
        private ToolTip toolTip5;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
    }
}