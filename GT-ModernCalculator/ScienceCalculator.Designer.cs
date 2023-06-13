namespace GT_ModernCalculator
{
    partial class ScienceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScienceCalculator));
            TxtOut0S = new TextBox();
            TxtOut1S = new TextBox();
            BtnSMenu = new Button();
            BtnSClearEntry = new Button();
            BtnSClear = new Button();
            BtnSRemove = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            BtnSPlusMinus = new Button();
            BtnSDot = new Button();
            BtnSZero = new Button();
            BtnSOne = new Button();
            BtnSTwo = new Button();
            ButtonSThree = new Button();
            ButtonSFour = new Button();
            ButtonSFive = new Button();
            ButtonSSix = new Button();
            BtnSSeven = new Button();
            BtnSEight = new Button();
            BtnSNine = new Button();
            ButtonSDoubleZero = new Button();
            BtnSEqual = new Button();
            BtnSPlus = new Button();
            BtnSMinus = new Button();
            BtnSMultiply = new Button();
            BtnSDivide = new Button();
            BtnSOneperX = new Button();
            BtnSSquare = new Button();
            BtnSSqrt = new Button();
            BtnSPercent = new Button();
            BtnSin = new Button();
            BtnCos = new Button();
            BtnTan = new Button();
            BtnCosec = new Button();
            BtnSinH = new Button();
            BtnCosH = new Button();
            BtnTanH = new Button();
            BtnInX = new Button();
            LabelVersion = new Label();
            BtnPie = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            SuspendLayout();
            // 
            // TxtOut0S
            // 
            TxtOut0S.BackColor = Color.FromArgb(32, 32, 32);
            TxtOut0S.BorderStyle = BorderStyle.None;
            TxtOut0S.Font = new Font("Ubuntu", 21F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOut0S.ForeColor = Color.White;
            TxtOut0S.Location = new Point(58, 94);
            TxtOut0S.Name = "TxtOut0S";
            TxtOut0S.Size = new Size(585, 41);
            TxtOut0S.TabIndex = 7;
            TxtOut0S.Text = "0";
            TxtOut0S.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtOut1S
            // 
            TxtOut1S.BackColor = Color.FromArgb(32, 32, 32);
            TxtOut1S.BorderStyle = BorderStyle.None;
            TxtOut1S.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOut1S.ForeColor = Color.White;
            TxtOut1S.Location = new Point(58, 61);
            TxtOut1S.Name = "TxtOut1S";
            TxtOut1S.Size = new Size(585, 23);
            TxtOut1S.TabIndex = 6;
            TxtOut1S.Text = "0";
            TxtOut1S.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnSMenu
            // 
            BtnSMenu.BackColor = Color.FromArgb(32, 32, 32);
            BtnSMenu.FlatAppearance.BorderSize = 0;
            BtnSMenu.FlatStyle = FlatStyle.Flat;
            BtnSMenu.Image = (Image)resources.GetObject("BtnSMenu.Image");
            BtnSMenu.Location = new Point(-2, 0);
            BtnSMenu.Margin = new Padding(0);
            BtnSMenu.Name = "BtnSMenu";
            BtnSMenu.Size = new Size(63, 50);
            BtnSMenu.TabIndex = 5;
            toolTip1.SetToolTip(BtnSMenu, "Menu");
            BtnSMenu.UseVisualStyleBackColor = false;
            BtnSMenu.Click += BtnMainMenu_Click;
            // 
            // BtnSClearEntry
            // 
            BtnSClearEntry.BackColor = Color.FromArgb(64, 64, 64);
            BtnSClearEntry.FlatAppearance.BorderSize = 0;
            BtnSClearEntry.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnSClearEntry.FlatStyle = FlatStyle.Flat;
            BtnSClearEntry.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSClearEntry.ForeColor = Color.White;
            BtnSClearEntry.Location = new Point(326, 145);
            BtnSClearEntry.Margin = new Padding(0);
            BtnSClearEntry.Name = "BtnSClearEntry";
            BtnSClearEntry.Size = new Size(100, 50);
            BtnSClearEntry.TabIndex = 20;
            BtnSClearEntry.Text = "CE";
            BtnSClearEntry.UseVisualStyleBackColor = false;
            BtnSClearEntry.Click += BtnClearEntry_Click;
            // 
            // BtnSClear
            // 
            BtnSClear.BackColor = Color.FromArgb(64, 64, 64);
            BtnSClear.FlatAppearance.BorderSize = 0;
            BtnSClear.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnSClear.FlatStyle = FlatStyle.Flat;
            BtnSClear.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSClear.ForeColor = Color.White;
            BtnSClear.Location = new Point(426, 145);
            BtnSClear.Margin = new Padding(0);
            BtnSClear.Name = "BtnSClear";
            BtnSClear.Size = new Size(100, 50);
            BtnSClear.TabIndex = 18;
            BtnSClear.Text = "C";
            BtnSClear.UseVisualStyleBackColor = false;
            BtnSClear.Click += BtnClear_Click;
            // 
            // BtnSRemove
            // 
            BtnSRemove.BackColor = Color.FromArgb(64, 64, 64);
            BtnSRemove.FlatAppearance.BorderSize = 0;
            BtnSRemove.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnSRemove.FlatStyle = FlatStyle.Flat;
            BtnSRemove.Image = (Image)resources.GetObject("BtnSRemove.Image");
            BtnSRemove.Location = new Point(543, 145);
            BtnSRemove.Margin = new Padding(0);
            BtnSRemove.Name = "BtnSRemove";
            BtnSRemove.Size = new Size(100, 50);
            BtnSRemove.TabIndex = 17;
            BtnSRemove.UseVisualStyleBackColor = false;
            BtnSRemove.Click += BtnRemove_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(109, 145);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 22;
            button1.Text = "Mod";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ModButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(109, 245);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 23;
            button2.Text = "Hex";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnHex_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(109, 445);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 24;
            button3.Text = "Exp";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BtnExp_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(109, 345);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(100, 50);
            button4.TabIndex = 25;
            button4.Text = "Bin";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BtnBin_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(109, 295);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(100, 50);
            button5.TabIndex = 26;
            button5.Text = "Oct";
            button5.UseVisualStyleBackColor = false;
            button5.Click += BtnOct_Click;
            // 
            // BtnSPlusMinus
            // 
            BtnSPlusMinus.BackColor = Color.FromArgb(64, 64, 64);
            BtnSPlusMinus.FlatAppearance.BorderSize = 0;
            BtnSPlusMinus.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSPlusMinus.FlatStyle = FlatStyle.Flat;
            BtnSPlusMinus.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSPlusMinus.ForeColor = Color.White;
            BtnSPlusMinus.Image = (Image)resources.GetObject("BtnSPlusMinus.Image");
            BtnSPlusMinus.Location = new Point(543, 445);
            BtnSPlusMinus.Margin = new Padding(0);
            BtnSPlusMinus.Name = "BtnSPlusMinus";
            BtnSPlusMinus.Size = new Size(100, 50);
            BtnSPlusMinus.TabIndex = 41;
            BtnSPlusMinus.UseVisualStyleBackColor = false;
            BtnSPlusMinus.Click += PlusMinusButton_Click;
            // 
            // BtnSDot
            // 
            BtnSDot.BackColor = Color.FromArgb(24, 24, 24);
            BtnSDot.FlatAppearance.BorderSize = 0;
            BtnSDot.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSDot.FlatStyle = FlatStyle.Flat;
            BtnSDot.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSDot.ForeColor = Color.White;
            BtnSDot.Location = new Point(426, 393);
            BtnSDot.Margin = new Padding(0);
            BtnSDot.Name = "BtnSDot";
            BtnSDot.Size = new Size(100, 50);
            BtnSDot.TabIndex = 40;
            BtnSDot.Text = ".";
            BtnSDot.UseVisualStyleBackColor = false;
            BtnSDot.Click += DecimalButton_Click;
            // 
            // BtnSZero
            // 
            BtnSZero.BackColor = Color.FromArgb(24, 24, 24);
            BtnSZero.FlatAppearance.BorderSize = 0;
            BtnSZero.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSZero.FlatStyle = FlatStyle.Flat;
            BtnSZero.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSZero.ForeColor = Color.White;
            BtnSZero.Location = new Point(326, 393);
            BtnSZero.Margin = new Padding(0);
            BtnSZero.Name = "BtnSZero";
            BtnSZero.Size = new Size(100, 50);
            BtnSZero.TabIndex = 39;
            BtnSZero.Text = "0";
            BtnSZero.UseVisualStyleBackColor = false;
            BtnSZero.Click += NumberButton_Click;
            // 
            // BtnSOne
            // 
            BtnSOne.BackColor = Color.FromArgb(24, 24, 24);
            BtnSOne.FlatAppearance.BorderSize = 0;
            BtnSOne.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSOne.FlatStyle = FlatStyle.Flat;
            BtnSOne.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSOne.ForeColor = Color.White;
            BtnSOne.Location = new Point(226, 343);
            BtnSOne.Margin = new Padding(0);
            BtnSOne.Name = "BtnSOne";
            BtnSOne.Size = new Size(100, 50);
            BtnSOne.TabIndex = 38;
            BtnSOne.Text = "1";
            BtnSOne.UseVisualStyleBackColor = false;
            BtnSOne.Click += NumberButton_Click;
            // 
            // BtnSTwo
            // 
            BtnSTwo.BackColor = Color.FromArgb(24, 24, 24);
            BtnSTwo.FlatAppearance.BorderSize = 0;
            BtnSTwo.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSTwo.FlatStyle = FlatStyle.Flat;
            BtnSTwo.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSTwo.ForeColor = Color.White;
            BtnSTwo.Location = new Point(326, 343);
            BtnSTwo.Margin = new Padding(0);
            BtnSTwo.Name = "BtnSTwo";
            BtnSTwo.Size = new Size(100, 50);
            BtnSTwo.TabIndex = 37;
            BtnSTwo.Text = "2";
            BtnSTwo.UseVisualStyleBackColor = false;
            BtnSTwo.Click += NumberButton_Click;
            // 
            // ButtonSThree
            // 
            ButtonSThree.BackColor = Color.FromArgb(24, 24, 24);
            ButtonSThree.FlatAppearance.BorderSize = 0;
            ButtonSThree.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonSThree.FlatStyle = FlatStyle.Flat;
            ButtonSThree.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSThree.ForeColor = Color.White;
            ButtonSThree.Location = new Point(426, 343);
            ButtonSThree.Margin = new Padding(0);
            ButtonSThree.Name = "ButtonSThree";
            ButtonSThree.Size = new Size(100, 50);
            ButtonSThree.TabIndex = 36;
            ButtonSThree.Text = "3";
            ButtonSThree.UseVisualStyleBackColor = false;
            ButtonSThree.Click += NumberButton_Click;
            // 
            // ButtonSFour
            // 
            ButtonSFour.BackColor = Color.FromArgb(24, 24, 24);
            ButtonSFour.FlatAppearance.BorderSize = 0;
            ButtonSFour.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonSFour.FlatStyle = FlatStyle.Flat;
            ButtonSFour.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSFour.ForeColor = Color.White;
            ButtonSFour.Location = new Point(226, 293);
            ButtonSFour.Margin = new Padding(0);
            ButtonSFour.Name = "ButtonSFour";
            ButtonSFour.Size = new Size(100, 50);
            ButtonSFour.TabIndex = 35;
            ButtonSFour.Text = "4";
            ButtonSFour.UseVisualStyleBackColor = false;
            ButtonSFour.Click += NumberButton_Click;
            // 
            // ButtonSFive
            // 
            ButtonSFive.BackColor = Color.FromArgb(24, 24, 24);
            ButtonSFive.FlatAppearance.BorderSize = 0;
            ButtonSFive.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonSFive.FlatStyle = FlatStyle.Flat;
            ButtonSFive.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSFive.ForeColor = Color.White;
            ButtonSFive.Location = new Point(326, 293);
            ButtonSFive.Margin = new Padding(0);
            ButtonSFive.Name = "ButtonSFive";
            ButtonSFive.Size = new Size(100, 50);
            ButtonSFive.TabIndex = 34;
            ButtonSFive.Text = "5";
            ButtonSFive.UseVisualStyleBackColor = false;
            ButtonSFive.Click += NumberButton_Click;
            // 
            // ButtonSSix
            // 
            ButtonSSix.BackColor = Color.FromArgb(24, 24, 24);
            ButtonSSix.FlatAppearance.BorderSize = 0;
            ButtonSSix.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonSSix.FlatStyle = FlatStyle.Flat;
            ButtonSSix.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSSix.ForeColor = Color.White;
            ButtonSSix.Location = new Point(426, 293);
            ButtonSSix.Margin = new Padding(0);
            ButtonSSix.Name = "ButtonSSix";
            ButtonSSix.Size = new Size(100, 50);
            ButtonSSix.TabIndex = 33;
            ButtonSSix.Text = "6";
            ButtonSSix.UseVisualStyleBackColor = false;
            ButtonSSix.Click += NumberButton_Click;
            // 
            // BtnSSeven
            // 
            BtnSSeven.BackColor = Color.FromArgb(24, 24, 24);
            BtnSSeven.FlatAppearance.BorderSize = 0;
            BtnSSeven.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSSeven.FlatStyle = FlatStyle.Flat;
            BtnSSeven.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSSeven.ForeColor = Color.White;
            BtnSSeven.Location = new Point(226, 243);
            BtnSSeven.Margin = new Padding(0);
            BtnSSeven.Name = "BtnSSeven";
            BtnSSeven.Size = new Size(100, 50);
            BtnSSeven.TabIndex = 32;
            BtnSSeven.Text = "7";
            BtnSSeven.UseVisualStyleBackColor = false;
            BtnSSeven.Click += NumberButton_Click;
            // 
            // BtnSEight
            // 
            BtnSEight.BackColor = Color.FromArgb(24, 24, 24);
            BtnSEight.FlatAppearance.BorderSize = 0;
            BtnSEight.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSEight.FlatStyle = FlatStyle.Flat;
            BtnSEight.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSEight.ForeColor = Color.White;
            BtnSEight.Location = new Point(326, 243);
            BtnSEight.Margin = new Padding(0);
            BtnSEight.Name = "BtnSEight";
            BtnSEight.Size = new Size(100, 50);
            BtnSEight.TabIndex = 31;
            BtnSEight.Text = "8";
            BtnSEight.UseVisualStyleBackColor = false;
            BtnSEight.Click += NumberButton_Click;
            // 
            // BtnSNine
            // 
            BtnSNine.BackColor = Color.FromArgb(24, 24, 24);
            BtnSNine.FlatAppearance.BorderSize = 0;
            BtnSNine.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSNine.FlatStyle = FlatStyle.Flat;
            BtnSNine.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSNine.ForeColor = Color.White;
            BtnSNine.Location = new Point(426, 243);
            BtnSNine.Margin = new Padding(0);
            BtnSNine.Name = "BtnSNine";
            BtnSNine.Size = new Size(100, 50);
            BtnSNine.TabIndex = 30;
            BtnSNine.Text = "9";
            BtnSNine.UseVisualStyleBackColor = false;
            BtnSNine.Click += NumberButton_Click;
            // 
            // ButtonSDoubleZero
            // 
            ButtonSDoubleZero.BackColor = Color.FromArgb(24, 24, 24);
            ButtonSDoubleZero.FlatAppearance.BorderSize = 0;
            ButtonSDoubleZero.FlatAppearance.MouseOverBackColor = Color.Silver;
            ButtonSDoubleZero.FlatStyle = FlatStyle.Flat;
            ButtonSDoubleZero.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSDoubleZero.ForeColor = Color.White;
            ButtonSDoubleZero.Location = new Point(226, 393);
            ButtonSDoubleZero.Margin = new Padding(0);
            ButtonSDoubleZero.Name = "ButtonSDoubleZero";
            ButtonSDoubleZero.Size = new Size(100, 50);
            ButtonSDoubleZero.TabIndex = 42;
            ButtonSDoubleZero.Text = "00";
            ButtonSDoubleZero.UseVisualStyleBackColor = false;
            ButtonSDoubleZero.Click += NumberButton_Click;
            // 
            // BtnSEqual
            // 
            BtnSEqual.BackColor = Color.DodgerBlue;
            BtnSEqual.FlatAppearance.BorderSize = 0;
            BtnSEqual.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSEqual.FlatStyle = FlatStyle.Flat;
            BtnSEqual.Image = (Image)resources.GetObject("BtnSEqual.Image");
            BtnSEqual.Location = new Point(226, 443);
            BtnSEqual.Margin = new Padding(0);
            BtnSEqual.Name = "BtnSEqual";
            BtnSEqual.Size = new Size(300, 52);
            BtnSEqual.TabIndex = 47;
            BtnSEqual.UseVisualStyleBackColor = false;
            BtnSEqual.Click += EqualButton_Click;
            // 
            // BtnSPlus
            // 
            BtnSPlus.BackColor = Color.FromArgb(64, 64, 64);
            BtnSPlus.FlatAppearance.BorderSize = 0;
            BtnSPlus.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSPlus.FlatStyle = FlatStyle.Flat;
            BtnSPlus.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSPlus.Image = (Image)resources.GetObject("BtnSPlus.Image");
            BtnSPlus.Location = new Point(543, 343);
            BtnSPlus.Margin = new Padding(0);
            BtnSPlus.Name = "BtnSPlus";
            BtnSPlus.Size = new Size(100, 102);
            BtnSPlus.TabIndex = 46;
            BtnSPlus.Text = "+";
            BtnSPlus.UseVisualStyleBackColor = false;
            BtnSPlus.Click += OperationButton_Click;
            // 
            // BtnSMinus
            // 
            BtnSMinus.BackColor = Color.FromArgb(64, 64, 64);
            BtnSMinus.FlatAppearance.BorderSize = 0;
            BtnSMinus.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSMinus.FlatStyle = FlatStyle.Flat;
            BtnSMinus.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSMinus.Image = (Image)resources.GetObject("BtnSMinus.Image");
            BtnSMinus.Location = new Point(543, 293);
            BtnSMinus.Margin = new Padding(0);
            BtnSMinus.Name = "BtnSMinus";
            BtnSMinus.Size = new Size(100, 50);
            BtnSMinus.TabIndex = 45;
            BtnSMinus.Text = "-";
            BtnSMinus.UseVisualStyleBackColor = false;
            BtnSMinus.Click += OperationButton_Click;
            // 
            // BtnSMultiply
            // 
            BtnSMultiply.BackColor = Color.FromArgb(64, 64, 64);
            BtnSMultiply.FlatAppearance.BorderSize = 0;
            BtnSMultiply.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSMultiply.FlatStyle = FlatStyle.Flat;
            BtnSMultiply.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSMultiply.Image = (Image)resources.GetObject("BtnSMultiply.Image");
            BtnSMultiply.Location = new Point(543, 243);
            BtnSMultiply.Margin = new Padding(0);
            BtnSMultiply.Name = "BtnSMultiply";
            BtnSMultiply.Size = new Size(100, 50);
            BtnSMultiply.TabIndex = 44;
            BtnSMultiply.Text = "*";
            BtnSMultiply.UseVisualStyleBackColor = false;
            BtnSMultiply.Click += OperationButton_Click;
            // 
            // BtnSDivide
            // 
            BtnSDivide.BackColor = Color.FromArgb(64, 64, 64);
            BtnSDivide.FlatAppearance.BorderSize = 0;
            BtnSDivide.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSDivide.FlatStyle = FlatStyle.Flat;
            BtnSDivide.Font = new Font("Segoe UI", 1.2F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSDivide.Image = (Image)resources.GetObject("BtnSDivide.Image");
            BtnSDivide.Location = new Point(543, 193);
            BtnSDivide.Margin = new Padding(0);
            BtnSDivide.Name = "BtnSDivide";
            BtnSDivide.Size = new Size(100, 50);
            BtnSDivide.TabIndex = 43;
            BtnSDivide.Text = "/";
            BtnSDivide.UseVisualStyleBackColor = false;
            BtnSDivide.Click += OperationButton_Click;
            // 
            // BtnSOneperX
            // 
            BtnSOneperX.BackColor = Color.FromArgb(64, 64, 64);
            BtnSOneperX.FlatAppearance.BorderSize = 0;
            BtnSOneperX.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSOneperX.FlatStyle = FlatStyle.Flat;
            BtnSOneperX.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSOneperX.ForeColor = Color.White;
            BtnSOneperX.Location = new Point(226, 193);
            BtnSOneperX.Margin = new Padding(0);
            BtnSOneperX.Name = "BtnSOneperX";
            BtnSOneperX.Size = new Size(100, 50);
            BtnSOneperX.TabIndex = 51;
            BtnSOneperX.Text = "1/x";
            BtnSOneperX.UseVisualStyleBackColor = false;
            BtnSOneperX.Click += OneOverXButton_Click;
            // 
            // BtnSSquare
            // 
            BtnSSquare.BackColor = Color.FromArgb(64, 64, 64);
            BtnSSquare.FlatAppearance.BorderSize = 0;
            BtnSSquare.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSSquare.FlatStyle = FlatStyle.Flat;
            BtnSSquare.Image = (Image)resources.GetObject("BtnSSquare.Image");
            BtnSSquare.Location = new Point(326, 193);
            BtnSSquare.Margin = new Padding(0);
            BtnSSquare.Name = "BtnSSquare";
            BtnSSquare.Size = new Size(100, 50);
            BtnSSquare.TabIndex = 50;
            BtnSSquare.UseVisualStyleBackColor = false;
            BtnSSquare.Click += SquareButton_Click;
            // 
            // BtnSSqrt
            // 
            BtnSSqrt.BackColor = Color.FromArgb(64, 64, 64);
            BtnSSqrt.FlatAppearance.BorderSize = 0;
            BtnSSqrt.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSSqrt.FlatStyle = FlatStyle.Flat;
            BtnSSqrt.Image = (Image)resources.GetObject("BtnSSqrt.Image");
            BtnSSqrt.Location = new Point(426, 193);
            BtnSSqrt.Margin = new Padding(0);
            BtnSSqrt.Name = "BtnSSqrt";
            BtnSSqrt.Size = new Size(100, 50);
            BtnSSqrt.TabIndex = 49;
            BtnSSqrt.UseVisualStyleBackColor = false;
            BtnSSqrt.Click += SquareRootButton_Click;
            // 
            // BtnSPercent
            // 
            BtnSPercent.BackColor = Color.FromArgb(64, 64, 64);
            BtnSPercent.FlatAppearance.BorderSize = 0;
            BtnSPercent.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSPercent.FlatStyle = FlatStyle.Flat;
            BtnSPercent.Image = (Image)resources.GetObject("BtnSPercent.Image");
            BtnSPercent.Location = new Point(226, 145);
            BtnSPercent.Margin = new Padding(0);
            BtnSPercent.Name = "BtnSPercent";
            BtnSPercent.Size = new Size(100, 50);
            BtnSPercent.TabIndex = 48;
            BtnSPercent.UseVisualStyleBackColor = false;
            BtnSPercent.Click += PercentageButton_Click;
            // 
            // BtnSin
            // 
            BtnSin.BackColor = Color.FromArgb(64, 64, 64);
            BtnSin.FlatAppearance.BorderSize = 0;
            BtnSin.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSin.FlatStyle = FlatStyle.Flat;
            BtnSin.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSin.ForeColor = Color.White;
            BtnSin.Location = new Point(9, 145);
            BtnSin.Margin = new Padding(0);
            BtnSin.Name = "BtnSin";
            BtnSin.Size = new Size(100, 50);
            BtnSin.TabIndex = 52;
            BtnSin.Text = "Sin";
            BtnSin.UseVisualStyleBackColor = false;
            BtnSin.Click += BtnSin_Click;
            // 
            // BtnCos
            // 
            BtnCos.BackColor = Color.FromArgb(64, 64, 64);
            BtnCos.FlatAppearance.BorderSize = 0;
            BtnCos.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnCos.FlatStyle = FlatStyle.Flat;
            BtnCos.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCos.ForeColor = Color.White;
            BtnCos.Location = new Point(9, 195);
            BtnCos.Margin = new Padding(0);
            BtnCos.Name = "BtnCos";
            BtnCos.Size = new Size(100, 50);
            BtnCos.TabIndex = 53;
            BtnCos.Text = "Cos";
            BtnCos.UseVisualStyleBackColor = false;
            BtnCos.Click += BtnCos_Click;
            // 
            // BtnTan
            // 
            BtnTan.BackColor = Color.FromArgb(64, 64, 64);
            BtnTan.FlatAppearance.BorderSize = 0;
            BtnTan.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnTan.FlatStyle = FlatStyle.Flat;
            BtnTan.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTan.ForeColor = Color.White;
            BtnTan.Location = new Point(9, 245);
            BtnTan.Margin = new Padding(0);
            BtnTan.Name = "BtnTan";
            BtnTan.Size = new Size(100, 50);
            BtnTan.TabIndex = 54;
            BtnTan.Text = "Tan";
            BtnTan.UseVisualStyleBackColor = false;
            BtnTan.Click += BtnTan_Click;
            // 
            // BtnCosec
            // 
            BtnCosec.BackColor = Color.FromArgb(64, 64, 64);
            BtnCosec.FlatAppearance.BorderSize = 0;
            BtnCosec.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnCosec.FlatStyle = FlatStyle.Flat;
            BtnCosec.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCosec.ForeColor = Color.White;
            BtnCosec.Location = new Point(9, 295);
            BtnCosec.Margin = new Padding(0);
            BtnCosec.Name = "BtnCosec";
            BtnCosec.Size = new Size(100, 50);
            BtnCosec.TabIndex = 55;
            BtnCosec.Text = "Cosec";
            BtnCosec.UseVisualStyleBackColor = false;
            BtnCosec.Click += BtnCosec_Click;
            // 
            // BtnSinH
            // 
            BtnSinH.BackColor = Color.FromArgb(64, 64, 64);
            BtnSinH.FlatAppearance.BorderSize = 0;
            BtnSinH.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSinH.FlatStyle = FlatStyle.Flat;
            BtnSinH.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSinH.ForeColor = Color.White;
            BtnSinH.Location = new Point(9, 345);
            BtnSinH.Margin = new Padding(0);
            BtnSinH.Name = "BtnSinH";
            BtnSinH.Size = new Size(100, 50);
            BtnSinH.TabIndex = 56;
            BtnSinH.Text = "SinH";
            BtnSinH.UseVisualStyleBackColor = false;
            BtnSinH.Click += BtnSinH_Click;
            // 
            // BtnCosH
            // 
            BtnCosH.BackColor = Color.FromArgb(64, 64, 64);
            BtnCosH.FlatAppearance.BorderSize = 0;
            BtnCosH.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnCosH.FlatStyle = FlatStyle.Flat;
            BtnCosH.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCosH.ForeColor = Color.White;
            BtnCosH.Location = new Point(9, 395);
            BtnCosH.Margin = new Padding(0);
            BtnCosH.Name = "BtnCosH";
            BtnCosH.Size = new Size(100, 50);
            BtnCosH.TabIndex = 57;
            BtnCosH.Text = "CosH";
            BtnCosH.UseVisualStyleBackColor = false;
            BtnCosH.Click += BtnCosH_Click;
            // 
            // BtnTanH
            // 
            BtnTanH.BackColor = Color.FromArgb(64, 64, 64);
            BtnTanH.FlatAppearance.BorderSize = 0;
            BtnTanH.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnTanH.FlatStyle = FlatStyle.Flat;
            BtnTanH.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTanH.ForeColor = Color.White;
            BtnTanH.Location = new Point(9, 445);
            BtnTanH.Margin = new Padding(0);
            BtnTanH.Name = "BtnTanH";
            BtnTanH.Size = new Size(100, 50);
            BtnTanH.TabIndex = 58;
            BtnTanH.Text = "TanH";
            BtnTanH.UseVisualStyleBackColor = false;
            BtnTanH.Click += BtnTanH_Click;
            // 
            // BtnInX
            // 
            BtnInX.BackColor = Color.FromArgb(64, 64, 64);
            BtnInX.FlatAppearance.BorderSize = 0;
            BtnInX.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnInX.FlatStyle = FlatStyle.Flat;
            BtnInX.Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnInX.ForeColor = Color.White;
            BtnInX.Location = new Point(109, 395);
            BtnInX.Margin = new Padding(0);
            BtnInX.Name = "BtnInX";
            BtnInX.Size = new Size(100, 50);
            BtnInX.TabIndex = 59;
            BtnInX.Text = "In x";
            BtnInX.UseVisualStyleBackColor = false;
            BtnInX.Click += InxButton_Click;
            // 
            // LabelVersion
            // 
            LabelVersion.AutoSize = true;
            LabelVersion.Font = new Font("Ubuntu Light", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            LabelVersion.ForeColor = Color.White;
            LabelVersion.Location = new Point(156, 495);
            LabelVersion.Margin = new Padding(0);
            LabelVersion.Name = "LabelVersion";
            LabelVersion.Size = new Size(18, 21);
            LabelVersion.TabIndex = 60;
            LabelVersion.Text = "0";
            // 
            // BtnPie
            // 
            BtnPie.BackColor = Color.FromArgb(64, 64, 64);
            BtnPie.FlatAppearance.BorderSize = 0;
            BtnPie.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnPie.FlatStyle = FlatStyle.Flat;
            BtnPie.Image = (Image)resources.GetObject("BtnPie.Image");
            BtnPie.Location = new Point(109, 195);
            BtnPie.Margin = new Padding(0);
            BtnPie.Name = "BtnPie";
            BtnPie.Size = new Size(100, 50);
            BtnPie.TabIndex = 62;
            BtnPie.UseVisualStyleBackColor = false;
            BtnPie.Click += PiButton_Click;
            // 
            // ScienceCalculator
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(660, 518);
            Controls.Add(BtnPie);
            Controls.Add(LabelVersion);
            Controls.Add(BtnTanH);
            Controls.Add(BtnInX);
            Controls.Add(BtnCosH);
            Controls.Add(BtnSinH);
            Controls.Add(BtnCosec);
            Controls.Add(BtnTan);
            Controls.Add(BtnCos);
            Controls.Add(BtnSin);
            Controls.Add(BtnSOneperX);
            Controls.Add(BtnSSquare);
            Controls.Add(BtnSSqrt);
            Controls.Add(BtnSPercent);
            Controls.Add(BtnSEqual);
            Controls.Add(BtnSPlus);
            Controls.Add(BtnSMinus);
            Controls.Add(BtnSMultiply);
            Controls.Add(BtnSDivide);
            Controls.Add(ButtonSDoubleZero);
            Controls.Add(BtnSPlusMinus);
            Controls.Add(BtnSDot);
            Controls.Add(BtnSZero);
            Controls.Add(BtnSOne);
            Controls.Add(BtnSTwo);
            Controls.Add(ButtonSThree);
            Controls.Add(ButtonSFour);
            Controls.Add(ButtonSFive);
            Controls.Add(ButtonSSix);
            Controls.Add(BtnSSeven);
            Controls.Add(BtnSEight);
            Controls.Add(BtnSNine);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnSClearEntry);
            Controls.Add(BtnSClear);
            Controls.Add(BtnSRemove);
            Controls.Add(TxtOut0S);
            Controls.Add(TxtOut1S);
            Controls.Add(BtnSMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ScienceCalculator";
            Text = "Science Calculator Mode";
            FormClosing += ScienceCalculator_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtOut0S;
        private TextBox TxtOut1S;
        private Button BtnSMenu;
        private Button BtnSClearEntry;
        private Button BtnSClear;
        private Button BtnSRemove;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button BtnSPlusMinus;
        private Button BtnSDot;
        private Button BtnSZero;
        private Button BtnSOne;
        private Button BtnSTwo;
        private Button ButtonSThree;
        private Button ButtonSFour;
        private Button ButtonSFive;
        private Button ButtonSSix;
        private Button BtnSSeven;
        private Button BtnSEight;
        private Button BtnSNine;
        private Button ButtonSDoubleZero;
        private Button BtnSEqual;
        private Button BtnSPlus;
        private Button BtnSMinus;
        private Button BtnSMultiply;
        private Button BtnSDivide;
        private Button BtnSOneperX;
        private Button BtnSSquare;
        private Button BtnSSqrt;
        private Button BtnSPercent;
        private Button BtnSin;
        private Button BtnCos;
        private Button BtnTan;
        private Button BtnCosec;
        private Button BtnSinH;
        private Button BtnCosH;
        private Button BtnTanH;
        private Button BtnInX;
        private Label LabelVersion;
        private Button BtnPie;
        private ToolTip toolTip1;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
    }
}