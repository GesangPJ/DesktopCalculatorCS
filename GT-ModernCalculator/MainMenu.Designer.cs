namespace GT_ModernCalculator
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            BtnLength = new Button();
            BtnFormTemp = new Button();
            BtnFormScience = new Button();
            BtnFormCalculator = new Button();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // BtnLength
            // 
            BtnLength.FlatAppearance.BorderSize = 0;
            BtnLength.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnLength.FlatStyle = FlatStyle.Flat;
            BtnLength.Image = (Image)resources.GetObject("BtnLength.Image");
            BtnLength.Location = new Point(392, 42);
            BtnLength.Name = "BtnLength";
            BtnLength.Size = new Size(60, 70);
            BtnLength.TabIndex = 7;
            toolTip1.SetToolTip(BtnLength, "Length Converter");
            BtnLength.UseVisualStyleBackColor = true;
            BtnLength.Click += LengthConverter_Click;
            // 
            // BtnFormTemp
            // 
            BtnFormTemp.FlatAppearance.BorderSize = 0;
            BtnFormTemp.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormTemp.FlatStyle = FlatStyle.Flat;
            BtnFormTemp.Image = (Image)resources.GetObject("BtnFormTemp.Image");
            BtnFormTemp.Location = new Point(302, 42);
            BtnFormTemp.Name = "BtnFormTemp";
            BtnFormTemp.Size = new Size(60, 70);
            BtnFormTemp.TabIndex = 6;
            toolTip1.SetToolTip(BtnFormTemp, "Temperature Converter");
            BtnFormTemp.UseVisualStyleBackColor = true;
            BtnFormTemp.Click += BtnTemperature_Click;
            // 
            // BtnFormScience
            // 
            BtnFormScience.FlatAppearance.BorderSize = 0;
            BtnFormScience.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormScience.FlatStyle = FlatStyle.Flat;
            BtnFormScience.Image = (Image)resources.GetObject("BtnFormScience.Image");
            BtnFormScience.Location = new Point(212, 42);
            BtnFormScience.Name = "BtnFormScience";
            BtnFormScience.Size = new Size(60, 70);
            BtnFormScience.TabIndex = 5;
            toolTip1.SetToolTip(BtnFormScience, "Scientific Calculator");
            BtnFormScience.UseVisualStyleBackColor = true;
            BtnFormScience.Click += BtnScience_Click;
            // 
            // BtnFormCalculator
            // 
            BtnFormCalculator.FlatAppearance.BorderSize = 0;
            BtnFormCalculator.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormCalculator.FlatStyle = FlatStyle.Flat;
            BtnFormCalculator.Image = (Image)resources.GetObject("BtnFormCalculator.Image");
            BtnFormCalculator.Location = new Point(122, 42);
            BtnFormCalculator.Name = "BtnFormCalculator";
            BtnFormCalculator.Size = new Size(60, 70);
            BtnFormCalculator.TabIndex = 4;
            toolTip1.SetToolTip(BtnFormCalculator, "Standard Calculator");
            BtnFormCalculator.UseVisualStyleBackColor = true;
            BtnFormCalculator.Click += BtnStandard_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(122, 179);
            button1.Name = "button1";
            button1.Size = new Size(60, 70);
            button1.TabIndex = 8;
            toolTip1.SetToolTip(button1, "Timer");
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnTimer_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(212, 179);
            button2.Name = "button2";
            button2.Size = new Size(60, 70);
            button2.TabIndex = 9;
            toolTip1.SetToolTip(button2, "More Features Coming...");
            button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(603, 373);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnLength);
            Controls.Add(BtnFormTemp);
            Controls.Add(BtnFormScience);
            Controls.Add(BtnFormCalculator);
            Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLength;
        private Button BtnFormTemp;
        private Button BtnFormScience;
        private Button BtnFormCalculator;
        private ToolTip toolTip1;
        private Button button1;
        private Button button2;
    }
}