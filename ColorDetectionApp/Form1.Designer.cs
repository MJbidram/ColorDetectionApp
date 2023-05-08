namespace ColorDetectionApp
{
    partial class Form1
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
            this.Mainpicture = new System.Windows.Forms.PictureBox();
            this.Detectpicture = new System.Windows.Forms.PictureBox();
            this.OpenImage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.LineSetting = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LineStroke = new System.Windows.Forms.NumericUpDown();
            this.LineColor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LblLower = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumGreenLow = new System.Windows.Forms.NumericUpDown();
            this.NumBlueLow = new System.Windows.Forms.NumericUpDown();
            this.NumRedLow = new System.Windows.Forms.NumericUpDown();
            this.NumBlueHighLbl = new System.Windows.Forms.Label();
            this.NumGreenHighlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumGreenHigh = new System.Windows.Forms.NumericUpDown();
            this.NumBlueHigh = new System.Windows.Forms.NumericUpDown();
            this.NumRedHigh = new System.Windows.Forms.NumericUpDown();
            this.coBoxColorDetect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detectpicture)).BeginInit();
            this.Settings.SuspendLayout();
            this.LineSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineStroke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreenLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlueLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRedLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreenHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlueHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRedHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainpicture
            // 
            this.Mainpicture.Location = new System.Drawing.Point(12, 132);
            this.Mainpicture.Name = "Mainpicture";
            this.Mainpicture.Size = new System.Drawing.Size(652, 470);
            this.Mainpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mainpicture.TabIndex = 0;
            this.Mainpicture.TabStop = false;
            // 
            // Detectpicture
            // 
            this.Detectpicture.Location = new System.Drawing.Point(670, 132);
            this.Detectpicture.Name = "Detectpicture";
            this.Detectpicture.Size = new System.Drawing.Size(652, 470);
            this.Detectpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Detectpicture.TabIndex = 1;
            this.Detectpicture.TabStop = false;
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(12, 26);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(96, 35);
            this.OpenImage.TabIndex = 2;
            this.OpenImage.Text = "OpenImage";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Detect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.LineSetting);
            this.Settings.Controls.Add(this.label9);
            this.Settings.Controls.Add(this.LblLower);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.NumGreenLow);
            this.Settings.Controls.Add(this.NumBlueLow);
            this.Settings.Controls.Add(this.NumRedLow);
            this.Settings.Controls.Add(this.NumBlueHighLbl);
            this.Settings.Controls.Add(this.NumGreenHighlbl);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.NumGreenHigh);
            this.Settings.Controls.Add(this.NumBlueHigh);
            this.Settings.Controls.Add(this.NumRedHigh);
            this.Settings.Controls.Add(this.coBoxColorDetect);
            this.Settings.Location = new System.Drawing.Point(224, 9);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(937, 114);
            this.Settings.TabIndex = 4;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // LineSetting
            // 
            this.LineSetting.Controls.Add(this.label11);
            this.LineSetting.Controls.Add(this.label10);
            this.LineSetting.Controls.Add(this.LineStroke);
            this.LineSetting.Controls.Add(this.LineColor);
            this.LineSetting.Location = new System.Drawing.Point(698, 17);
            this.LineSetting.Name = "LineSetting";
            this.LineSetting.Size = new System.Drawing.Size(226, 91);
            this.LineSetting.TabIndex = 18;
            this.LineSetting.TabStop = false;
            this.LineSetting.Text = "LineSetting";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Stroke";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Color";
            // 
            // LineStroke
            // 
            this.LineStroke.Location = new System.Drawing.Point(66, 56);
            this.LineStroke.Name = "LineStroke";
            this.LineStroke.Size = new System.Drawing.Size(71, 22);
            this.LineStroke.TabIndex = 19;
            this.LineStroke.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LineStroke.ValueChanged += new System.EventHandler(this.LineStroke_ValueChanged);
            // 
            // LineColor
            // 
            this.LineColor.FormattingEnabled = true;
            this.LineColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.LineColor.Location = new System.Drawing.Point(66, 27);
            this.LineColor.Name = "LineColor";
            this.LineColor.Size = new System.Drawing.Size(121, 24);
            this.LineColor.TabIndex = 16;
            this.LineColor.Text = "Red";
            this.LineColor.SelectedIndexChanged += new System.EventHandler(this.LineColor_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "higherRange :";
            // 
            // LblLower
            // 
            this.LblLower.AutoSize = true;
            this.LblLower.Location = new System.Drawing.Point(203, 67);
            this.LblLower.Name = "LblLower";
            this.LblLower.Size = new System.Drawing.Size(90, 16);
            this.LblLower.TabIndex = 14;
            this.LblLower.Text = "LowerRange :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Green";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Red";
            // 
            // NumGreenLow
            // 
            this.NumGreenLow.Location = new System.Drawing.Point(478, 66);
            this.NumGreenLow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumGreenLow.Name = "NumGreenLow";
            this.NumGreenLow.Size = new System.Drawing.Size(71, 22);
            this.NumGreenLow.TabIndex = 10;
            this.NumGreenLow.ValueChanged += new System.EventHandler(this.NumGreenLow_ValueChanged);
            // 
            // NumBlueLow
            // 
            this.NumBlueLow.Location = new System.Drawing.Point(603, 65);
            this.NumBlueLow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumBlueLow.Name = "NumBlueLow";
            this.NumBlueLow.Size = new System.Drawing.Size(71, 22);
            this.NumBlueLow.TabIndex = 9;
            this.NumBlueLow.ValueChanged += new System.EventHandler(this.NumBlueLow_ValueChanged);
            // 
            // NumRedLow
            // 
            this.NumRedLow.Location = new System.Drawing.Point(339, 66);
            this.NumRedLow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumRedLow.Name = "NumRedLow";
            this.NumRedLow.Size = new System.Drawing.Size(71, 22);
            this.NumRedLow.TabIndex = 8;
            this.NumRedLow.ValueChanged += new System.EventHandler(this.NumRedLow_ValueChanged);
            // 
            // NumBlueHighLbl
            // 
            this.NumBlueHighLbl.AutoSize = true;
            this.NumBlueHighLbl.Location = new System.Drawing.Point(564, 41);
            this.NumBlueHighLbl.Name = "NumBlueHighLbl";
            this.NumBlueHighLbl.Size = new System.Drawing.Size(34, 16);
            this.NumBlueHighLbl.TabIndex = 7;
            this.NumBlueHighLbl.Text = "Blue";
            // 
            // NumGreenHighlbl
            // 
            this.NumGreenHighlbl.AutoSize = true;
            this.NumGreenHighlbl.Location = new System.Drawing.Point(428, 41);
            this.NumGreenHighlbl.Name = "NumGreenHighlbl";
            this.NumGreenHighlbl.Size = new System.Drawing.Size(44, 16);
            this.NumGreenHighlbl.TabIndex = 6;
            this.NumGreenHighlbl.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color";
            // 
            // NumGreenHigh
            // 
            this.NumGreenHigh.Location = new System.Drawing.Point(478, 38);
            this.NumGreenHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumGreenHigh.Name = "NumGreenHigh";
            this.NumGreenHigh.Size = new System.Drawing.Size(71, 22);
            this.NumGreenHigh.TabIndex = 3;
            this.NumGreenHigh.ValueChanged += new System.EventHandler(this.NumGreenHigh_ValueChanged);
            // 
            // NumBlueHigh
            // 
            this.NumBlueHigh.Location = new System.Drawing.Point(603, 37);
            this.NumBlueHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumBlueHigh.Name = "NumBlueHigh";
            this.NumBlueHigh.Size = new System.Drawing.Size(71, 22);
            this.NumBlueHigh.TabIndex = 2;
            this.NumBlueHigh.ValueChanged += new System.EventHandler(this.NumBlueHigh_ValueChanged);
            // 
            // NumRedHigh
            // 
            this.NumRedHigh.Location = new System.Drawing.Point(339, 38);
            this.NumRedHigh.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumRedHigh.Name = "NumRedHigh";
            this.NumRedHigh.Size = new System.Drawing.Size(71, 22);
            this.NumRedHigh.TabIndex = 1;
            this.NumRedHigh.ValueChanged += new System.EventHandler(this.NumRedHigh_ValueChanged);
            // 
            // coBoxColorDetect
            // 
            this.coBoxColorDetect.FormattingEnabled = true;
            this.coBoxColorDetect.Items.AddRange(new object[] {
            "Green",
            "Red",
            "Blue",
            "Custom..."});
            this.coBoxColorDetect.Location = new System.Drawing.Point(66, 51);
            this.coBoxColorDetect.Name = "coBoxColorDetect";
            this.coBoxColorDetect.Size = new System.Drawing.Size(121, 24);
            this.coBoxColorDetect.TabIndex = 0;
            this.coBoxColorDetect.Text = "Green";
            this.coBoxColorDetect.SelectedIndexChanged += new System.EventHandler(this.coBoxColorDetect_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 615);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.Detectpicture);
            this.Controls.Add(this.Mainpicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mainpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detectpicture)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.LineSetting.ResumeLayout(false);
            this.LineSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineStroke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreenLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlueLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRedLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreenHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlueHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRedHigh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Mainpicture;
        private System.Windows.Forms.PictureBox Detectpicture;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.Label LblLower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumGreenLow;
        private System.Windows.Forms.NumericUpDown NumBlueLow;
        private System.Windows.Forms.NumericUpDown NumRedLow;
        private System.Windows.Forms.Label NumBlueHighLbl;
        private System.Windows.Forms.Label NumGreenHighlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumGreenHigh;
        private System.Windows.Forms.NumericUpDown NumBlueHigh;
        private System.Windows.Forms.NumericUpDown NumRedHigh;
        private System.Windows.Forms.ComboBox coBoxColorDetect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LineColor;
        private System.Windows.Forms.GroupBox LineSetting;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown LineStroke;
    }
}

