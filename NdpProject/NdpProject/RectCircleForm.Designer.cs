namespace NdpProject
{
    partial class RectCircleForm
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
            this.showButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rectWidthLabel = new System.Windows.Forms.Label();
            this.numericUpDownRectWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRectX = new System.Windows.Forms.NumericUpDown();
            this.rectXLabel = new System.Windows.Forms.Label();
            this.rectHeightLabel = new System.Windows.Forms.Label();
            this.numericUpDownRectY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRectHeight = new System.Windows.Forms.NumericUpDown();
            this.rectYLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCircleX = new System.Windows.Forms.NumericUpDown();
            this.circleXLabel = new System.Windows.Forms.Label();
            this.circleRadLabel = new System.Windows.Forms.Label();
            this.numericUpDownCircleY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleRad = new System.Windows.Forms.NumericUpDown();
            this.circleYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleRad)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(462, 474);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(112, 53);
            this.showButton.TabIndex = 26;
            this.showButton.Text = "Show Collision";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(296, 474);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(112, 53);
            this.checkButton.TabIndex = 25;
            this.checkButton.Text = "Collision Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rectWidthLabel);
            this.groupBox1.Controls.Add(this.numericUpDownRectWidth);
            this.groupBox1.Controls.Add(this.numericUpDownRectX);
            this.groupBox1.Controls.Add(this.rectXLabel);
            this.groupBox1.Controls.Add(this.rectHeightLabel);
            this.groupBox1.Controls.Add(this.numericUpDownRectY);
            this.groupBox1.Controls.Add(this.numericUpDownRectHeight);
            this.groupBox1.Controls.Add(this.rectYLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 346);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Rectangle";
            // 
            // rectWidthLabel
            // 
            this.rectWidthLabel.AutoSize = true;
            this.rectWidthLabel.Location = new System.Drawing.Point(12, 272);
            this.rectWidthLabel.Name = "rectWidthLabel";
            this.rectWidthLabel.Size = new System.Drawing.Size(41, 16);
            this.rectWidthLabel.TabIndex = 8;
            this.rectWidthLabel.Text = "Width";
            // 
            // numericUpDownRectWidth
            // 
            this.numericUpDownRectWidth.Location = new System.Drawing.Point(15, 309);
            this.numericUpDownRectWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRectWidth.Name = "numericUpDownRectWidth";
            this.numericUpDownRectWidth.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRectWidth.TabIndex = 7;
            // 
            // numericUpDownRectX
            // 
            this.numericUpDownRectX.Location = new System.Drawing.Point(12, 65);
            this.numericUpDownRectX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRectX.Name = "numericUpDownRectX";
            this.numericUpDownRectX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRectX.TabIndex = 0;
            // 
            // rectXLabel
            // 
            this.rectXLabel.AutoSize = true;
            this.rectXLabel.Location = new System.Drawing.Point(12, 28);
            this.rectXLabel.Name = "rectXLabel";
            this.rectXLabel.Size = new System.Drawing.Size(47, 16);
            this.rectXLabel.TabIndex = 3;
            this.rectXLabel.Text = "X point";
            // 
            // rectHeightLabel
            // 
            this.rectHeightLabel.AutoSize = true;
            this.rectHeightLabel.Location = new System.Drawing.Point(12, 186);
            this.rectHeightLabel.Name = "rectHeightLabel";
            this.rectHeightLabel.Size = new System.Drawing.Size(46, 16);
            this.rectHeightLabel.TabIndex = 5;
            this.rectHeightLabel.Text = "Height";
            // 
            // numericUpDownRectY
            // 
            this.numericUpDownRectY.Location = new System.Drawing.Point(15, 143);
            this.numericUpDownRectY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRectY.Name = "numericUpDownRectY";
            this.numericUpDownRectY.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRectY.TabIndex = 1;
            // 
            // numericUpDownRectHeight
            // 
            this.numericUpDownRectHeight.Location = new System.Drawing.Point(15, 223);
            this.numericUpDownRectHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRectHeight.Name = "numericUpDownRectHeight";
            this.numericUpDownRectHeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRectHeight.TabIndex = 2;
            // 
            // rectYLabel
            // 
            this.rectYLabel.AutoSize = true;
            this.rectYLabel.Location = new System.Drawing.Point(12, 106);
            this.rectYLabel.Name = "rectYLabel";
            this.rectYLabel.Size = new System.Drawing.Size(48, 16);
            this.rectYLabel.TabIndex = 4;
            this.rectYLabel.Text = "Y point";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownCircleX);
            this.groupBox2.Controls.Add(this.circleXLabel);
            this.groupBox2.Controls.Add(this.circleRadLabel);
            this.groupBox2.Controls.Add(this.numericUpDownCircleY);
            this.groupBox2.Controls.Add(this.numericUpDownCircleRad);
            this.groupBox2.Controls.Add(this.circleYLabel);
            this.groupBox2.Location = new System.Drawing.Point(627, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 346);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Circle";
            // 
            // numericUpDownCircleX
            // 
            this.numericUpDownCircleX.Location = new System.Drawing.Point(12, 65);
            this.numericUpDownCircleX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownCircleX.Name = "numericUpDownCircleX";
            this.numericUpDownCircleX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCircleX.TabIndex = 0;
            // 
            // circleXLabel
            // 
            this.circleXLabel.AutoSize = true;
            this.circleXLabel.Location = new System.Drawing.Point(12, 28);
            this.circleXLabel.Name = "circleXLabel";
            this.circleXLabel.Size = new System.Drawing.Size(47, 16);
            this.circleXLabel.TabIndex = 3;
            this.circleXLabel.Text = "X point";
            // 
            // circleRadLabel
            // 
            this.circleRadLabel.AutoSize = true;
            this.circleRadLabel.Location = new System.Drawing.Point(12, 186);
            this.circleRadLabel.Name = "circleRadLabel";
            this.circleRadLabel.Size = new System.Drawing.Size(50, 16);
            this.circleRadLabel.TabIndex = 5;
            this.circleRadLabel.Text = "Radius";
            // 
            // numericUpDownCircleY
            // 
            this.numericUpDownCircleY.Location = new System.Drawing.Point(15, 143);
            this.numericUpDownCircleY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownCircleY.Name = "numericUpDownCircleY";
            this.numericUpDownCircleY.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCircleY.TabIndex = 1;
            // 
            // numericUpDownCircleRad
            // 
            this.numericUpDownCircleRad.Location = new System.Drawing.Point(15, 223);
            this.numericUpDownCircleRad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownCircleRad.Name = "numericUpDownCircleRad";
            this.numericUpDownCircleRad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCircleRad.TabIndex = 2;
            // 
            // circleYLabel
            // 
            this.circleYLabel.AutoSize = true;
            this.circleYLabel.Location = new System.Drawing.Point(12, 106);
            this.circleYLabel.Name = "circleYLabel";
            this.circleYLabel.Size = new System.Drawing.Size(48, 16);
            this.circleYLabel.TabIndex = 4;
            this.circleYLabel.Text = "Y point";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(362, 560);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RectCircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.checkButton);
            this.Name = "RectCircleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangle-Circle Collision Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleRad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label rectWidthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownRectWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownRectX;
        private System.Windows.Forms.Label rectXLabel;
        private System.Windows.Forms.Label rectHeightLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownRectY;
        private System.Windows.Forms.NumericUpDown numericUpDownRectHeight;
        private System.Windows.Forms.Label rectYLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownCircleX;
        private System.Windows.Forms.Label circleXLabel;
        private System.Windows.Forms.Label circleRadLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownCircleY;
        private System.Windows.Forms.NumericUpDown numericUpDownCircleRad;
        private System.Windows.Forms.Label circleYLabel;
        private System.Windows.Forms.Button buttonBack;
    }
}