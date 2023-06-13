namespace GT_ModernCalculator
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
            TxtMillimeter = new TextBox();
            TxtCentimeter = new TextBox();
            TxtInch = new TextBox();
            TxtMeter = new TextBox();
            TxtFoot = new TextBox();
            TxtKilometer = new TextBox();
            TxtMile = new TextBox();
            BtnMenuL = new Button();
            LabelVersionL = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "milimiter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(114, 95);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "centimeter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(114, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 2;
            label3.Text = "inch";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(114, 187);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 3;
            label4.Text = "meter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(114, 279);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 4;
            label5.Text = "kilometer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(114, 233);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 5;
            label6.Text = "foot";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(114, 325);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 6;
            label7.Text = "mile";
            // 
            // TxtMillimeter
            // 
            TxtMillimeter.BackColor = Color.FromArgb(32, 32, 32);
            TxtMillimeter.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMillimeter.ForeColor = Color.White;
            TxtMillimeter.Location = new Point(320, 49);
            TxtMillimeter.Name = "TxtMillimeter";
            TxtMillimeter.Size = new Size(166, 27);
            TxtMillimeter.TabIndex = 7;
            TxtMillimeter.Text = "0";
            TxtMillimeter.TextAlign = HorizontalAlignment.Right;
            TxtMillimeter.TextChanged += LengthTextChanged;
            // 
            // TxtCentimeter
            // 
            TxtCentimeter.BackColor = Color.FromArgb(32, 32, 32);
            TxtCentimeter.Font = new Font("Ubuntu", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCentimeter.ForeColor = Color.White;
            TxtCentimeter.Location = new Point(320, 102);
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
            TxtInch.Location = new Point(320, 153);
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
            TxtMeter.Location = new Point(320, 204);
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
            TxtFoot.Location = new Point(320, 255);
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
            TxtKilometer.Location = new Point(320, 306);
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
            TxtMile.Location = new Point(320, 357);
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
            BtnMenuL.Click += BtnMainMenu_Click;
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
            // LengthConverter
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(534, 450);
            Controls.Add(LabelVersionL);
            Controls.Add(BtnMenuL);
            Controls.Add(TxtMile);
            Controls.Add(TxtKilometer);
            Controls.Add(TxtFoot);
            Controls.Add(TxtMeter);
            Controls.Add(TxtInch);
            Controls.Add(TxtCentimeter);
            Controls.Add(TxtMillimeter);
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
            Text = "Length Converter Mode";
            FormClosing += LengthConverter_FormClosing;
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
        private TextBox TxtMillimeter;
        private TextBox TxtCentimeter;
        private TextBox TxtInch;
        private TextBox TxtMeter;
        private TextBox TxtFoot;
        private TextBox TxtKilometer;
        private TextBox TxtMile;
        private Button BtnMenuL;
        private Label LabelVersionL;
        private ToolTip toolTip1;
        private ToolTip toolTip5;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
    }
}