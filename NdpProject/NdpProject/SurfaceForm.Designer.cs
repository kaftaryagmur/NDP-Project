namespace NdpProject
{
    partial class SurfaceForm
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
            this.groupBoxSurface = new System.Windows.Forms.GroupBox();
            this.surfaceDepthLabel = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.surfaceWidthLabel = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.surfaceButton = new System.Windows.Forms.Button();
            this.surfaceXLabel = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.surfaceYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxSurface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSurface
            // 
            this.groupBoxSurface.Controls.Add(this.surfaceDepthLabel);
            this.groupBoxSurface.Controls.Add(this.numericUpDownDepth);
            this.groupBoxSurface.Controls.Add(this.surfaceWidthLabel);
            this.groupBoxSurface.Controls.Add(this.numericUpDownWidth);
            this.groupBoxSurface.Controls.Add(this.numericUpDownX);
            this.groupBoxSurface.Controls.Add(this.surfaceButton);
            this.groupBoxSurface.Controls.Add(this.surfaceXLabel);
            this.groupBoxSurface.Controls.Add(this.numericUpDownY);
            this.groupBoxSurface.Controls.Add(this.surfaceYLabel);
            this.groupBoxSurface.Location = new System.Drawing.Point(31, 221);
            this.groupBoxSurface.Name = "groupBoxSurface";
            this.groupBoxSurface.Size = new System.Drawing.Size(243, 410);
            this.groupBoxSurface.TabIndex = 10;
            this.groupBoxSurface.TabStop = false;
            this.groupBoxSurface.Text = "Drawing Surface";
            // 
            // surfaceDepthLabel
            // 
            this.surfaceDepthLabel.AutoSize = true;
            this.surfaceDepthLabel.Location = new System.Drawing.Point(6, 269);
            this.surfaceDepthLabel.Name = "surfaceDepthLabel";
            this.surfaceDepthLabel.Size = new System.Drawing.Size(43, 16);
            this.surfaceDepthLabel.TabIndex = 12;
            this.surfaceDepthLabel.Text = "Depth";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(9, 306);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDepth.TabIndex = 11;
            // 
            // surfaceWidthLabel
            // 
            this.surfaceWidthLabel.AutoSize = true;
            this.surfaceWidthLabel.Location = new System.Drawing.Point(6, 191);
            this.surfaceWidthLabel.Name = "surfaceWidthLabel";
            this.surfaceWidthLabel.Size = new System.Drawing.Size(41, 16);
            this.surfaceWidthLabel.TabIndex = 8;
            this.surfaceWidthLabel.Text = "Width";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(9, 228);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWidth.TabIndex = 7;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(6, 75);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX.TabIndex = 0;
            // 
            // surfaceButton
            // 
            this.surfaceButton.Location = new System.Drawing.Point(27, 361);
            this.surfaceButton.Name = "surfaceButton";
            this.surfaceButton.Size = new System.Drawing.Size(168, 30);
            this.surfaceButton.TabIndex = 6;
            this.surfaceButton.Text = "Confirm";
            this.surfaceButton.UseVisualStyleBackColor = true;
            this.surfaceButton.Click += new System.EventHandler(this.surfaceButton_Click);
            // 
            // surfaceXLabel
            // 
            this.surfaceXLabel.AutoSize = true;
            this.surfaceXLabel.Location = new System.Drawing.Point(6, 38);
            this.surfaceXLabel.Name = "surfaceXLabel";
            this.surfaceXLabel.Size = new System.Drawing.Size(47, 16);
            this.surfaceXLabel.TabIndex = 3;
            this.surfaceXLabel.Text = "X point";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(9, 153);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY.TabIndex = 1;
            // 
            // surfaceYLabel
            // 
            this.surfaceYLabel.AutoSize = true;
            this.surfaceYLabel.Location = new System.Drawing.Point(6, 116);
            this.surfaceYLabel.Name = "surfaceYLabel";
            this.surfaceYLabel.Size = new System.Drawing.Size(48, 16);
            this.surfaceYLabel.TabIndex = 4;
            this.surfaceYLabel.Text = "Y point";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(709, 582);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SurfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxSurface);
            this.Name = "SurfaceForm";
            this.Text = "Surface";
            this.groupBoxSurface.ResumeLayout(false);
            this.groupBoxSurface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSurface;
        private System.Windows.Forms.Label surfaceDepthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label surfaceWidthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Button surfaceButton;
        private System.Windows.Forms.Label surfaceXLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label surfaceYLabel;
        private System.Windows.Forms.Button buttonBack;
    }
}