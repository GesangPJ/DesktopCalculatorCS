namespace GT_ModernCalculator
{
    partial class TimerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtHour = new TextBox();
            TxtMinute = new TextBox();
            TxtSecond = new TextBox();
            label4 = new Label();
            label5 = new Label();
            BtnStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ubuntu", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(166, 63);
            label1.Name = "label1";
            label1.Size = new Size(88, 33);
            label1.TabIndex = 0;
            label1.Text = "Hours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ubuntu", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(350, 63);
            label2.Name = "label2";
            label2.Size = new Size(115, 33);
            label2.TabIndex = 1;
            label2.Text = "Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ubuntu", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(554, 63);
            label3.Name = "label3";
            label3.Size = new Size(117, 33);
            label3.TabIndex = 2;
            label3.Text = "Seconds";
            // 
            // TxtHour
            // 
            TxtHour.BackColor = Color.FromArgb(32, 32, 32);
            TxtHour.BorderStyle = BorderStyle.None;
            TxtHour.Font = new Font("Ubuntu", 48F, FontStyle.Underline, GraphicsUnit.Point);
            TxtHour.ForeColor = Color.White;
            TxtHour.Location = new Point(158, 129);
            TxtHour.Name = "TxtHour";
            TxtHour.Size = new Size(96, 92);
            TxtHour.TabIndex = 3;
            TxtHour.Text = "00";
            TxtHour.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtMinute
            // 
            TxtMinute.BackColor = Color.FromArgb(32, 32, 32);
            TxtMinute.BorderStyle = BorderStyle.None;
            TxtMinute.Font = new Font("Ubuntu", 48F, FontStyle.Underline, GraphicsUnit.Point);
            TxtMinute.ForeColor = Color.White;
            TxtMinute.Location = new Point(356, 129);
            TxtMinute.Name = "TxtMinute";
            TxtMinute.Size = new Size(96, 92);
            TxtMinute.TabIndex = 4;
            TxtMinute.Text = "00";
            TxtMinute.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtSecond
            // 
            TxtSecond.BackColor = Color.FromArgb(32, 32, 32);
            TxtSecond.BorderStyle = BorderStyle.None;
            TxtSecond.Font = new Font("Ubuntu", 48F, FontStyle.Underline, GraphicsUnit.Point);
            TxtSecond.ForeColor = Color.White;
            TxtSecond.Location = new Point(554, 129);
            TxtSecond.Name = "TxtSecond";
            TxtSecond.Size = new Size(96, 92);
            TxtSecond.TabIndex = 5;
            TxtSecond.Text = "00";
            TxtSecond.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ubuntu", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(275, 129);
            label4.Name = "label4";
            label4.Size = new Size(60, 93);
            label4.TabIndex = 6;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ubuntu", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(473, 129);
            label5.Name = "label5";
            label5.Size = new Size(60, 93);
            label5.TabIndex = 7;
            label5.Text = ":";
            // 
            // BtnStart
            // 
            BtnStart.BackColor = Color.DodgerBlue;
            BtnStart.FlatAppearance.BorderSize = 0;
            BtnStart.FlatStyle = FlatStyle.Flat;
            BtnStart.Font = new Font("Ubuntu", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            BtnStart.ForeColor = Color.White;
            BtnStart.Location = new Point(275, 306);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(265, 59);
            BtnStart.TabIndex = 8;
            BtnStart.Text = "START";
            BtnStart.UseVisualStyleBackColor = false;
            // 
            // TimerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(810, 474);
            Controls.Add(BtnStart);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtSecond);
            Controls.Add(TxtMinute);
            Controls.Add(TxtHour);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Ubuntu", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "TimerForm";
            Text = "Timer Mode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtHour;
        private TextBox TxtMinute;
        private TextBox TxtSecond;
        private Label label4;
        private Label label5;
        private Button BtnStart;
    }
}