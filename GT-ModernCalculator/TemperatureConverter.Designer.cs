﻿namespace GT_ModernCalculator
{
    partial class TemperatureConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureConverter));
            label1 = new Label();
            BtnTMenu = new Button();
            label2 = new Label();
            label3 = new Label();
            TxtCelcius = new TextBox();
            TxtFarenheit = new TextBox();
            TxtKelvin = new TextBox();
            LabelVersionT = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ubuntu", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 80);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 0;
            label1.Text = "Celcius";
            // 
            // BtnTMenu
            // 
            BtnTMenu.BackColor = Color.FromArgb(32, 32, 32);
            BtnTMenu.FlatAppearance.BorderSize = 0;
            BtnTMenu.FlatStyle = FlatStyle.Flat;
            BtnTMenu.Image = (Image)resources.GetObject("BtnTMenu.Image");
            BtnTMenu.Location = new Point(1, 0);
            BtnTMenu.Margin = new Padding(0);
            BtnTMenu.Name = "BtnTMenu";
            BtnTMenu.Size = new Size(63, 50);
            BtnTMenu.TabIndex = 6;
            toolTip1.SetToolTip(BtnTMenu, "Menu");
            BtnTMenu.UseVisualStyleBackColor = false;
            BtnTMenu.Click += BtnMainMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ubuntu", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 177);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 7;
            label2.Text = "Farenheit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ubuntu", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(115, 274);
            label3.Name = "label3";
            label3.Size = new Size(76, 29);
            label3.TabIndex = 8;
            label3.Text = "Kelvin";
            // 
            // TxtCelcius
            // 
            TxtCelcius.BackColor = Color.FromArgb(16, 16, 16);
            TxtCelcius.BorderStyle = BorderStyle.None;
            TxtCelcius.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCelcius.ForeColor = Color.White;
            TxtCelcius.Location = new Point(243, 88);
            TxtCelcius.Name = "TxtCelcius";
            TxtCelcius.Size = new Size(172, 23);
            TxtCelcius.TabIndex = 9;
            TxtCelcius.Text = "0";
            TxtCelcius.TextAlign = HorizontalAlignment.Right;
            TxtCelcius.TextChanged += TxtCelcius_TextChanged;
            // 
            // TxtFarenheit
            // 
            TxtFarenheit.BackColor = Color.FromArgb(16, 16, 16);
            TxtFarenheit.BorderStyle = BorderStyle.None;
            TxtFarenheit.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtFarenheit.ForeColor = Color.White;
            TxtFarenheit.Location = new Point(243, 183);
            TxtFarenheit.Name = "TxtFarenheit";
            TxtFarenheit.Size = new Size(172, 23);
            TxtFarenheit.TabIndex = 10;
            TxtFarenheit.Text = "0";
            TxtFarenheit.TextAlign = HorizontalAlignment.Right;
            TxtFarenheit.TextChanged += TxtFarenheit_TextChanged;
            // 
            // TxtKelvin
            // 
            TxtKelvin.BackColor = Color.FromArgb(16, 16, 16);
            TxtKelvin.BorderStyle = BorderStyle.None;
            TxtKelvin.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKelvin.ForeColor = Color.White;
            TxtKelvin.Location = new Point(243, 280);
            TxtKelvin.Name = "TxtKelvin";
            TxtKelvin.Size = new Size(172, 23);
            TxtKelvin.TabIndex = 11;
            TxtKelvin.Text = "0";
            TxtKelvin.TextAlign = HorizontalAlignment.Right;
            TxtKelvin.TextChanged += TxtKelvin_TextChanged;
            // 
            // LabelVersionT
            // 
            LabelVersionT.AutoSize = true;
            LabelVersionT.Font = new Font("Ubuntu Light", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            LabelVersionT.ForeColor = Color.White;
            LabelVersionT.Location = new Point(257, 366);
            LabelVersionT.Name = "LabelVersionT";
            LabelVersionT.Size = new Size(18, 21);
            LabelVersionT.TabIndex = 12;
            LabelVersionT.Text = "0";
            // 
            // TemperatureConverter
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(427, 396);
            Controls.Add(LabelVersionT);
            Controls.Add(TxtKelvin);
            Controls.Add(TxtFarenheit);
            Controls.Add(TxtCelcius);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnTMenu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TemperatureConverter";
            Text = "Temperature Converter Mode";
            FormClosing += TemperatureConverter_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnTMenu;
        private Label label2;
        private Label label3;
        private TextBox TxtCelcius;
        private TextBox TxtFarenheit;
        private TextBox TxtKelvin;
        private Label LabelVersionT;
        private ToolTip toolTip1;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
    }
}