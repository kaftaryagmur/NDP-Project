namespace NdpProject
{
    partial class RectangleForm
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
            this.groupBoxRect = new System.Windows.Forms.GroupBox();
            this.rectWidthLabel = new System.Windows.Forms.Label();
            this.numericUpDownRectWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRectX = new System.Windows.Forms.NumericUpDown();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.circleXLabel = new System.Windows.Forms.Label();
            this.rectHeightLabel = new System.Windows.Forms.Label();
            this.numericUpDownRectY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRectHeight = new System.Windows.Forms.NumericUpDown();
            this.circleYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxRect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRect
            // 
            this.groupBoxRect.Controls.Add(this.rectWidthLabel);
            this.groupBoxRect.Controls.Add(this.numericUpDownRectWidth);
            this.groupBoxRect.Controls.Add(this.numericUpDownRectX);
            this.groupBoxRect.Controls.Add(this.rectangleButton);
            this.groupBoxRect.Controls.Add(this.circleXLabel);
            this.groupBoxRect.Controls.Add(this.rectHeightLabel);
            this.groupBoxRect.Controls.Add(this.numericUpDownRectY);
            this.groupBoxRect.Controls.Add(this.numericUpDownRectHeight);
            this.groupBoxRect.Controls.Add(this.circleYLabel);
            this.groupBoxRect.Location = new System.Drawing.Point(32, 200);
            this.groupBoxRect.Name = "groupBoxRect";
            this.groupBoxRect.Size = new System.Drawing.Size(243, 416);
            this.groupBoxRect.TabIndex = 8;
            this.groupBoxRect.TabStop = false;
            this.groupBoxRect.Text = "Drawing Rectangle";
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
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(35, 369);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(168, 30);
            this.rectangleButton.TabIndex = 6;
            this.rectangleButton.Text = "Confirm";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
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
            this.buttonBack.Location = new System.Drawing.Point(704, 569);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxRect);
            this.Name = "RectangleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangle";
            this.groupBoxRect.ResumeLayout(false);
            this.groupBoxRect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRect;
        private System.Windows.Forms.Label rectWidthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownRectWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownRectX;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Label circleXLabel;
        private System.Windows.Forms.Label rectHeightLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownRectY;
        private System.Windows.Forms.NumericUpDown numericUpDownRectHeight;
        private System.Windows.Forms.Label circleYLabel;
        private System.Windows.Forms.Button buttonBack;
    }
}