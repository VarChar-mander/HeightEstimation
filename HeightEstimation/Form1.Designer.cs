namespace HeightEstimation
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
            this.momLabel = new System.Windows.Forms.Label();
            this.Dadlabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.SelectBoy = new System.Windows.Forms.RadioButton();
            this.selectGirl = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.momHeight = new System.Windows.Forms.NumericUpDown();
            this.dadHeight = new System.Windows.Forms.NumericUpDown();
            this.calcButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.momHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // momLabel
            // 
            this.momLabel.AutoSize = true;
            this.momLabel.Location = new System.Drawing.Point(32, 19);
            this.momLabel.Name = "momLabel";
            this.momLabel.Size = new System.Drawing.Size(122, 13);
            this.momLabel.TabIndex = 0;
            this.momLabel.Text = "Mother\'s Height (Inches)";
            // 
            // Dadlabel
            // 
            this.Dadlabel.AutoSize = true;
            this.Dadlabel.Location = new System.Drawing.Point(268, 19);
            this.Dadlabel.Name = "Dadlabel";
            this.Dadlabel.Size = new System.Drawing.Size(119, 13);
            this.Dadlabel.TabIndex = 1;
            this.Dadlabel.Text = "Father\'s Height (Inches)";
            this.Dadlabel.Click += new System.EventHandler(this.Dadlabel_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(32, 155);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(39, 13);
            this.Output.TabIndex = 2;
            this.Output.Text = "Output";
            this.Output.Visible = false;
            // 
            // SelectBoy
            // 
            this.SelectBoy.AutoSize = true;
            this.SelectBoy.Location = new System.Drawing.Point(191, 116);
            this.SelectBoy.Name = "SelectBoy";
            this.SelectBoy.Size = new System.Drawing.Size(43, 17);
            this.SelectBoy.TabIndex = 3;
            this.SelectBoy.TabStop = true;
            this.SelectBoy.Text = "Boy";
            this.SelectBoy.UseVisualStyleBackColor = true;
            this.SelectBoy.CheckedChanged += new System.EventHandler(this.SelectBoy_CheckedChanged);
            // 
            // selectGirl
            // 
            this.selectGirl.AutoSize = true;
            this.selectGirl.Location = new System.Drawing.Point(125, 116);
            this.selectGirl.Name = "selectGirl";
            this.selectGirl.Size = new System.Drawing.Size(40, 17);
            this.selectGirl.TabIndex = 4;
            this.selectGirl.TabStop = true;
            this.selectGirl.Text = "Girl";
            this.selectGirl.UseVisualStyleBackColor = true;
            this.selectGirl.CheckedChanged += new System.EventHandler(this.selectGirl_CheckedChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(32, 118);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(75, 13);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Child\'s Gender";
            this.genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // momHeight
            // 
            this.momHeight.DecimalPlaces = 1;
            this.momHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.momHeight.Location = new System.Drawing.Point(35, 57);
            this.momHeight.Name = "momHeight";
            this.momHeight.Size = new System.Drawing.Size(120, 20);
            this.momHeight.TabIndex = 6;
            this.momHeight.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.momHeight.ValueChanged += new System.EventHandler(this.momHeight_ValueChanged);
            // 
            // dadHeight
            // 
            this.dadHeight.DecimalPlaces = 1;
            this.dadHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.dadHeight.Location = new System.Drawing.Point(271, 57);
            this.dadHeight.Name = "dadHeight";
            this.dadHeight.Size = new System.Drawing.Size(120, 20);
            this.dadHeight.TabIndex = 7;
            this.dadHeight.Value = new decimal(new int[] {
            69,
            0,
            0,
            0});
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(330, 118);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(85, 52);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate\r\nHeight";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(330, 176);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 30);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 210);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.dadHeight);
            this.Controls.Add(this.momHeight);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.selectGirl);
            this.Controls.Add(this.SelectBoy);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Dadlabel);
            this.Controls.Add(this.momLabel);
            this.Name = "Form1";
            this.Text = "Children\'s Height Estimation";
            ((System.ComponentModel.ISupportInitialize)(this.momHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label momLabel;
        private System.Windows.Forms.Label Dadlabel;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.RadioButton SelectBoy;
        private System.Windows.Forms.RadioButton selectGirl;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.NumericUpDown momHeight;
        private System.Windows.Forms.NumericUpDown dadHeight;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button resetButton;
    }
}

