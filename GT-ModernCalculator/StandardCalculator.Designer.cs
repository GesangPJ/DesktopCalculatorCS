namespace GT_ModernCalculator
{
    partial class StandardCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardCalculator));
            BtnMenu = new Button();
            BtnRemove = new Button();
            TxtOut1 = new TextBox();
            TxtOut0 = new TextBox();
            BtnDivide = new Button();
            BtnMultiply = new Button();
            BtnMinus = new Button();
            BtnPlus = new Button();
            BtnEqual = new Button();
            BtnClear = new Button();
            BtnPercent = new Button();
            BtnSqrt = new Button();
            BtnSquare = new Button();
            BtnClearEntry = new Button();
            BtnOneperX = new Button();
            BtnNine = new Button();
            BtnEight = new Button();
            BtnSeven = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            BtnTwo = new Button();
            BtnOne = new Button();
            BtnZero = new Button();
            BtnDot = new Button();
            BtnPlusMinus = new Button();
            toolTip1 = new ToolTip(components);
            panelSidebarS = new Panel();
            BtnLength = new Button();
            BtnFormTemp = new Button();
            BtnFormScience = new Button();
            BtnFormCalculator = new Button();
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            LabelVersionStandard = new Label();
            toolTip5 = new ToolTip(components);
            panelSidebarS.SuspendLayout();
            SuspendLayout();
            // 
            // BtnMenu
            // 
            BtnMenu.BackColor = Color.FromArgb(32, 32, 32);
            BtnMenu.FlatAppearance.BorderSize = 0;
            BtnMenu.FlatStyle = FlatStyle.Flat;
            BtnMenu.Image = (Image)resources.GetObject("BtnMenu.Image");
            BtnMenu.Location = new Point(2, 2);
            BtnMenu.Margin = new Padding(0);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(63, 50);
            BtnMenu.TabIndex = 1;
            toolTip1.SetToolTip(BtnMenu, "Menu");
            BtnMenu.UseVisualStyleBackColor = false;
            BtnMenu.Click += BtnMainMenu_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = Color.FromArgb(64, 64, 64);
            BtnRemove.FlatAppearance.BorderSize = 0;
            BtnRemove.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnRemove.FlatStyle = FlatStyle.Flat;
            BtnRemove.Image = (Image)resources.GetObject("BtnRemove.Image");
            BtnRemove.Location = new Point(325, 138);
            BtnRemove.Margin = new Padding(0);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(100, 50);
            BtnRemove.TabIndex = 2;
            BtnRemove.UseVisualStyleBackColor = false;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // TxtOut1
            // 
            TxtOut1.BackColor = Color.FromArgb(32, 32, 32);
            TxtOut1.BorderStyle = BorderStyle.None;
            TxtOut1.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOut1.ForeColor = Color.White;
            TxtOut1.Location = new Point(32, 63);
            TxtOut1.Name = "TxtOut1";
            TxtOut1.Size = new Size(393, 23);
            TxtOut1.TabIndex = 3;
            TxtOut1.Text = "0";
            TxtOut1.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtOut0
            // 
            TxtOut0.BackColor = Color.FromArgb(32, 32, 32);
            TxtOut0.BorderStyle = BorderStyle.None;
            TxtOut0.Font = new Font("Ubuntu", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOut0.ForeColor = Color.White;
            TxtOut0.Location = new Point(32, 96);
            TxtOut0.Name = "TxtOut0";
            TxtOut0.Size = new Size(393, 39);
            TxtOut0.TabIndex = 4;
            TxtOut0.Text = "0";
            TxtOut0.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnDivide
            // 
            BtnDivide.BackColor = Color.FromArgb(64, 64, 64);
            BtnDivide.FlatAppearance.BorderSize = 0;
            BtnDivide.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnDivide.FlatStyle = FlatStyle.Flat;
            BtnDivide.Font = new Font("Segoe UI", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDivide.Image = (Image)resources.GetObject("BtnDivide.Image");
            BtnDivide.Location = new Point(325, 188);
            BtnDivide.Margin = new Padding(0);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(100, 50);
            BtnDivide.TabIndex = 5;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = false;
            BtnDivide.Click += OperationButton_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.FromArgb(64, 64, 64);
            BtnMultiply.FlatAppearance.BorderSize = 0;
            BtnMultiply.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnMultiply.FlatStyle = FlatStyle.Flat;
            BtnMultiply.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMultiply.Image = (Image)resources.GetObject("BtnMultiply.Image");
            BtnMultiply.Location = new Point(325, 238);
            BtnMultiply.Margin = new Padding(0);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(100, 50);
            BtnMultiply.TabIndex = 6;
            BtnMultiply.Text = "*";
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += OperationButton_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.BackColor = Color.FromArgb(64, 64, 64);
            BtnMinus.FlatAppearance.BorderSize = 0;
            BtnMinus.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnMinus.FlatStyle = FlatStyle.Flat;
            BtnMinus.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMinus.Image = (Image)resources.GetObject("BtnMinus.Image");
            BtnMinus.Location = new Point(325, 288);
            BtnMinus.Margin = new Padding(0);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(100, 50);
            BtnMinus.TabIndex = 7;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = false;
            BtnMinus.Click += OperationButton_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.FromArgb(64, 64, 64);
            BtnPlus.FlatAppearance.BorderSize = 0;
            BtnPlus.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnPlus.FlatStyle = FlatStyle.Flat;
            BtnPlus.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPlus.Image = (Image)resources.GetObject("BtnPlus.Image");
            BtnPlus.Location = new Point(325, 338);
            BtnPlus.Margin = new Padding(0);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(100, 50);
            BtnPlus.TabIndex = 8;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += OperationButton_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = Color.DodgerBlue;
            BtnEqual.FlatAppearance.BorderSize = 0;
            BtnEqual.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnEqual.FlatStyle = FlatStyle.Flat;
            BtnEqual.Image = (Image)resources.GetObject("BtnEqual.Image");
            BtnEqual.Location = new Point(325, 388);
            BtnEqual.Margin = new Padding(0);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(100, 50);
            BtnEqual.TabIndex = 9;
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += EqualButton_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(64, 64, 64);
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(209, 138);
            BtnClear.Margin = new Padding(0);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(100, 50);
            BtnClear.TabIndex = 10;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.FromArgb(64, 64, 64);
            BtnPercent.FlatAppearance.BorderSize = 0;
            BtnPercent.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.Image = (Image)resources.GetObject("BtnPercent.Image");
            BtnPercent.Location = new Point(9, 138);
            BtnPercent.Margin = new Padding(0);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(100, 50);
            BtnPercent.TabIndex = 12;
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += PercentageButton_Click;
            // 
            // BtnSqrt
            // 
            BtnSqrt.BackColor = Color.FromArgb(64, 64, 64);
            BtnSqrt.FlatAppearance.BorderSize = 0;
            BtnSqrt.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSqrt.FlatStyle = FlatStyle.Flat;
            BtnSqrt.Image = (Image)resources.GetObject("BtnSqrt.Image");
            BtnSqrt.Location = new Point(209, 188);
            BtnSqrt.Margin = new Padding(0);
            BtnSqrt.Name = "BtnSqrt";
            BtnSqrt.Size = new Size(100, 50);
            BtnSqrt.TabIndex = 13;
            BtnSqrt.UseVisualStyleBackColor = false;
            // 
            // BtnSquare
            // 
            BtnSquare.BackColor = Color.FromArgb(64, 64, 64);
            BtnSquare.FlatAppearance.BorderSize = 0;
            BtnSquare.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSquare.FlatStyle = FlatStyle.Flat;
            BtnSquare.Image = (Image)resources.GetObject("BtnSquare.Image");
            BtnSquare.Location = new Point(109, 188);
            BtnSquare.Margin = new Padding(0);
            BtnSquare.Name = "BtnSquare";
            BtnSquare.Size = new Size(100, 50);
            BtnSquare.TabIndex = 14;
            BtnSquare.UseVisualStyleBackColor = false;
            // 
            // BtnClearEntry
            // 
            BtnClearEntry.BackColor = Color.FromArgb(64, 64, 64);
            BtnClearEntry.FlatAppearance.BorderSize = 0;
            BtnClearEntry.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnClearEntry.FlatStyle = FlatStyle.Flat;
            BtnClearEntry.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClearEntry.ForeColor = Color.White;
            BtnClearEntry.Location = new Point(109, 138);
            BtnClearEntry.Margin = new Padding(0);
            BtnClearEntry.Name = "BtnClearEntry";
            BtnClearEntry.Size = new Size(100, 50);
            BtnClearEntry.TabIndex = 16;
            BtnClearEntry.Text = "CE";
            BtnClearEntry.UseVisualStyleBackColor = false;
            BtnClearEntry.Click += BtnClearEntry_Click;
            // 
            // BtnOneperX
            // 
            BtnOneperX.BackColor = Color.FromArgb(64, 64, 64);
            BtnOneperX.FlatAppearance.BorderSize = 0;
            BtnOneperX.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnOneperX.FlatStyle = FlatStyle.Flat;
            BtnOneperX.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnOneperX.ForeColor = Color.White;
            BtnOneperX.Location = new Point(9, 188);
            BtnOneperX.Margin = new Padding(0);
            BtnOneperX.Name = "BtnOneperX";
            BtnOneperX.Size = new Size(100, 50);
            BtnOneperX.TabIndex = 17;
            BtnOneperX.Text = "1/x";
            BtnOneperX.UseVisualStyleBackColor = false;
            // 
            // BtnNine
            // 
            BtnNine.BackColor = Color.FromArgb(24, 24, 24);
            BtnNine.FlatAppearance.BorderSize = 0;
            BtnNine.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnNine.FlatStyle = FlatStyle.Flat;
            BtnNine.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNine.ForeColor = Color.White;
            BtnNine.Location = new Point(209, 238);
            BtnNine.Margin = new Padding(0);
            BtnNine.Name = "BtnNine";
            BtnNine.Size = new Size(100, 50);
            BtnNine.TabIndex = 18;
            BtnNine.Text = "9";
            BtnNine.UseVisualStyleBackColor = false;
            BtnNine.Click += NumberButton_Click;
            // 
            // BtnEight
            // 
            BtnEight.BackColor = Color.FromArgb(24, 24, 24);
            BtnEight.FlatAppearance.BorderSize = 0;
            BtnEight.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnEight.FlatStyle = FlatStyle.Flat;
            BtnEight.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEight.ForeColor = Color.White;
            BtnEight.Location = new Point(109, 238);
            BtnEight.Margin = new Padding(0);
            BtnEight.Name = "BtnEight";
            BtnEight.Size = new Size(100, 50);
            BtnEight.TabIndex = 19;
            BtnEight.Text = "8";
            BtnEight.UseVisualStyleBackColor = false;
            BtnEight.Click += NumberButton_Click;
            // 
            // BtnSeven
            // 
            BtnSeven.BackColor = Color.FromArgb(24, 24, 24);
            BtnSeven.FlatAppearance.BorderSize = 0;
            BtnSeven.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSeven.FlatStyle = FlatStyle.Flat;
            BtnSeven.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSeven.ForeColor = Color.White;
            BtnSeven.Location = new Point(9, 238);
            BtnSeven.Margin = new Padding(0);
            BtnSeven.Name = "BtnSeven";
            BtnSeven.Size = new Size(100, 50);
            BtnSeven.TabIndex = 20;
            BtnSeven.Text = "7";
            BtnSeven.UseVisualStyleBackColor = false;
            BtnSeven.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 24, 24);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(209, 288);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(100, 50);
            button5.TabIndex = 21;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(24, 24, 24);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.Silver;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(109, 288);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(100, 50);
            button6.TabIndex = 22;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(24, 24, 24);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.Silver;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(9, 288);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(100, 50);
            button7.TabIndex = 23;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = false;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(24, 24, 24);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.Silver;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(209, 338);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(100, 50);
            button8.TabIndex = 24;
            button8.Text = "3";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NumberButton_Click;
            // 
            // BtnTwo
            // 
            BtnTwo.BackColor = Color.FromArgb(24, 24, 24);
            BtnTwo.FlatAppearance.BorderSize = 0;
            BtnTwo.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnTwo.FlatStyle = FlatStyle.Flat;
            BtnTwo.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTwo.ForeColor = Color.White;
            BtnTwo.Location = new Point(109, 338);
            BtnTwo.Margin = new Padding(0);
            BtnTwo.Name = "BtnTwo";
            BtnTwo.Size = new Size(100, 50);
            BtnTwo.TabIndex = 25;
            BtnTwo.Text = "2";
            BtnTwo.UseVisualStyleBackColor = false;
            BtnTwo.Click += NumberButton_Click;
            // 
            // BtnOne
            // 
            BtnOne.BackColor = Color.FromArgb(24, 24, 24);
            BtnOne.FlatAppearance.BorderSize = 0;
            BtnOne.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnOne.FlatStyle = FlatStyle.Flat;
            BtnOne.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnOne.ForeColor = Color.White;
            BtnOne.Location = new Point(9, 338);
            BtnOne.Margin = new Padding(0);
            BtnOne.Name = "BtnOne";
            BtnOne.Size = new Size(100, 50);
            BtnOne.TabIndex = 26;
            BtnOne.Text = "1";
            BtnOne.UseVisualStyleBackColor = false;
            BtnOne.Click += NumberButton_Click;
            // 
            // BtnZero
            // 
            BtnZero.BackColor = Color.FromArgb(24, 24, 24);
            BtnZero.FlatAppearance.BorderSize = 0;
            BtnZero.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnZero.FlatStyle = FlatStyle.Flat;
            BtnZero.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnZero.ForeColor = Color.White;
            BtnZero.Location = new Point(109, 388);
            BtnZero.Margin = new Padding(0);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(100, 50);
            BtnZero.TabIndex = 27;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = false;
            BtnZero.Click += NumberButton_Click;
            // 
            // BtnDot
            // 
            BtnDot.BackColor = Color.FromArgb(24, 24, 24);
            BtnDot.FlatAppearance.BorderSize = 0;
            BtnDot.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnDot.FlatStyle = FlatStyle.Flat;
            BtnDot.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDot.ForeColor = Color.White;
            BtnDot.Location = new Point(209, 388);
            BtnDot.Margin = new Padding(0);
            BtnDot.Name = "BtnDot";
            BtnDot.Size = new Size(100, 50);
            BtnDot.TabIndex = 28;
            BtnDot.Text = ".";
            BtnDot.UseVisualStyleBackColor = false;
            BtnDot.Click += DecimalButton_Click;
            // 
            // BtnPlusMinus
            // 
            BtnPlusMinus.BackColor = Color.FromArgb(24, 24, 24);
            BtnPlusMinus.FlatAppearance.BorderSize = 0;
            BtnPlusMinus.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnPlusMinus.FlatStyle = FlatStyle.Flat;
            BtnPlusMinus.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPlusMinus.ForeColor = Color.White;
            BtnPlusMinus.Image = (Image)resources.GetObject("BtnPlusMinus.Image");
            BtnPlusMinus.Location = new Point(9, 388);
            BtnPlusMinus.Margin = new Padding(0);
            BtnPlusMinus.Name = "BtnPlusMinus";
            BtnPlusMinus.Size = new Size(100, 50);
            BtnPlusMinus.TabIndex = 29;
            BtnPlusMinus.UseVisualStyleBackColor = false;
            BtnPlusMinus.Click += PlusMinusButton_Click;
            // 
            // panelSidebarS
            // 
            panelSidebarS.BackColor = Color.FromArgb(24, 24, 24);
            panelSidebarS.Controls.Add(BtnLength);
            panelSidebarS.Controls.Add(BtnFormTemp);
            panelSidebarS.Controls.Add(BtnFormScience);
            panelSidebarS.Controls.Add(BtnFormCalculator);
            panelSidebarS.Location = new Point(2, 48);
            panelSidebarS.Name = "panelSidebarS";
            panelSidebarS.Size = new Size(63, 411);
            panelSidebarS.TabIndex = 30;
            panelSidebarS.Visible = false;
            // 
            // BtnLength
            // 
            BtnLength.FlatAppearance.BorderSize = 0;
            BtnLength.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnLength.FlatStyle = FlatStyle.Flat;
            BtnLength.Image = (Image)resources.GetObject("BtnLength.Image");
            BtnLength.Location = new Point(0, 243);
            BtnLength.Name = "BtnLength";
            BtnLength.Size = new Size(60, 70);
            BtnLength.TabIndex = 3;
            toolTip5.SetToolTip(BtnLength, "Length Converter");
            BtnLength.UseVisualStyleBackColor = true;
            // 
            // BtnFormTemp
            // 
            BtnFormTemp.FlatAppearance.BorderSize = 0;
            BtnFormTemp.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormTemp.FlatStyle = FlatStyle.Flat;
            BtnFormTemp.Image = (Image)resources.GetObject("BtnFormTemp.Image");
            BtnFormTemp.Location = new Point(0, 167);
            BtnFormTemp.Name = "BtnFormTemp";
            BtnFormTemp.Size = new Size(60, 70);
            BtnFormTemp.TabIndex = 2;
            toolTip4.SetToolTip(BtnFormTemp, "Temperature Converter");
            BtnFormTemp.UseVisualStyleBackColor = true;
            // 
            // BtnFormScience
            // 
            BtnFormScience.FlatAppearance.BorderSize = 0;
            BtnFormScience.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormScience.FlatStyle = FlatStyle.Flat;
            BtnFormScience.Image = (Image)resources.GetObject("BtnFormScience.Image");
            BtnFormScience.Location = new Point(0, 84);
            BtnFormScience.Name = "BtnFormScience";
            BtnFormScience.Size = new Size(60, 70);
            BtnFormScience.TabIndex = 1;
            toolTip3.SetToolTip(BtnFormScience, "Scientific Calculator");
            BtnFormScience.UseVisualStyleBackColor = true;
            // 
            // BtnFormCalculator
            // 
            BtnFormCalculator.FlatAppearance.BorderSize = 0;
            BtnFormCalculator.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnFormCalculator.FlatStyle = FlatStyle.Flat;
            BtnFormCalculator.Image = (Image)resources.GetObject("BtnFormCalculator.Image");
            BtnFormCalculator.Location = new Point(0, 8);
            BtnFormCalculator.Name = "BtnFormCalculator";
            BtnFormCalculator.Size = new Size(60, 70);
            BtnFormCalculator.TabIndex = 0;
            toolTip2.SetToolTip(BtnFormCalculator, "Standard Calculator");
            BtnFormCalculator.UseVisualStyleBackColor = true;
            // 
            // LabelVersionStandard
            // 
            LabelVersionStandard.AutoSize = true;
            LabelVersionStandard.FlatStyle = FlatStyle.Flat;
            LabelVersionStandard.Font = new Font("Ubuntu Light", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            LabelVersionStandard.ForeColor = Color.White;
            LabelVersionStandard.Location = new Point(81, 438);
            LabelVersionStandard.Margin = new Padding(0);
            LabelVersionStandard.Name = "LabelVersionStandard";
            LabelVersionStandard.Size = new Size(18, 21);
            LabelVersionStandard.TabIndex = 31;
            LabelVersionStandard.Text = "0";
            // 
            // StandardCalculator
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(440, 460);
            Controls.Add(LabelVersionStandard);
            Controls.Add(panelSidebarS);
            Controls.Add(BtnPlusMinus);
            Controls.Add(BtnDot);
            Controls.Add(BtnZero);
            Controls.Add(BtnOne);
            Controls.Add(BtnTwo);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(BtnSeven);
            Controls.Add(BtnEight);
            Controls.Add(BtnNine);
            Controls.Add(BtnOneperX);
            Controls.Add(BtnClearEntry);
            Controls.Add(BtnSquare);
            Controls.Add(BtnSqrt);
            Controls.Add(BtnPercent);
            Controls.Add(BtnClear);
            Controls.Add(BtnEqual);
            Controls.Add(BtnPlus);
            Controls.Add(BtnMinus);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnDivide);
            Controls.Add(TxtOut0);
            Controls.Add(TxtOut1);
            Controls.Add(BtnRemove);
            Controls.Add(BtnMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StandardCalculator";
            Text = "C# Calculator";
            FormClosing += StandardCalculator_FormClosing;
            panelSidebarS.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnMenu;
        private Button BtnRemove;
        private TextBox TxtOut1;
        private TextBox TxtOut0;
        private Button BtnDivide;
        private Button BtnMultiply;
        private Button BtnMinus;
        private Button BtnPlus;
        private Button BtnEqual;
        private Button BtnClear;
        private Button BtnPercent;
        private Button BtnSqrt;
        private Button BtnSquare;
        private Button BtnClearEntry;
        private Button BtnOneperX;
        private Button BtnNine;
        private Button BtnEight;
        private Button BtnSeven;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button BtnTwo;
        private Button BtnOne;
        private Button BtnZero;
        private Button BtnDot;
        private Button BtnPlusMinus;
        private ToolTip toolTip1;
        private Panel panelSidebarS;
        private Button BtnFormScience;
        private Button BtnFormCalculator;
        private Button BtnFormTemp;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private Label LabelVersionStandard;
        private Button BtnLength;
        private ToolTip toolTip5;
    }
}