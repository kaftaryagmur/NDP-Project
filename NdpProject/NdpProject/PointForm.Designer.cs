namespace NdpProject
{
    partial class PointForm
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
            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.numericUpDownPointX = new System.Windows.Forms.NumericUpDown();
            this.pointButton = new System.Windows.Forms.Button();
            this.pointXLabel = new System.Windows.Forms.Label();
            this.numericUpDownPointY = new System.Windows.Forms.NumericUpDown();
            this.pointYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPoint
            // 
            this.groupBoxPoint.Controls.Add(this.radioButtonPoint);
            this.groupBoxPoint.Controls.Add(this.numericUpDownPointX);
            this.groupBoxPoint.Controls.Add(this.pointButton);
            this.groupBoxPoint.Controls.Add(this.pointXLabel);
            this.groupBoxPoint.Controls.Add(this.numericUpDownPointY);
            this.groupBoxPoint.Controls.Add(this.pointYLabel);
            this.groupBoxPoint.Location = new System.Drawing.Point(12, 333);
            this.groupBoxPoint.Name = "groupBoxPoint";
            this.groupBoxPoint.Size = new System.Drawing.Size(243, 308);
            this.groupBoxPoint.TabIndex = 8;
            this.groupBoxPoint.TabStop = false;
            this.groupBoxPoint.Text = "Drawing Point";
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.AutoSize = true;
            this.radioButtonPoint.Location = new System.Drawing.Point(15, 192);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(210, 36);
            this.radioButtonPoint.TabIndex = 7;
            this.radioButtonPoint.TabStop = true;
            this.radioButtonPoint.Text = "The point will be small and you\r\n have to look carefully. ";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.radioButtonPoint_CheckedChanged);
            // 
            // numericUpDownPointX
            // 
            this.numericUpDownPointX.Location = new System.Drawing.Point(12, 65);
            this.numericUpDownPointX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPointX.Name = "numericUpDownPointX";
            this.numericUpDownPointX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPointX.TabIndex = 0;
            // 
            // pointButton
            // 
            this.pointButton.Location = new System.Drawing.Point(25, 260);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(168, 30);
            this.pointButton.TabIndex = 6;
            this.pointButton.Text = "Confirm";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // pointXLabel
            // 
            this.pointXLabel.AutoSize = true;
            this.pointXLabel.Location = new System.Drawing.Point(12, 28);
            this.pointXLabel.Name = "pointXLabel";
            this.pointXLabel.Size = new System.Drawing.Size(47, 16);
            this.pointXLabel.TabIndex = 3;
            this.pointXLabel.Text = "X point";
            // 
            // numericUpDownPointY
            // 
            this.numericUpDownPointY.Location = new System.Drawing.Point(15, 143);
            this.numericUpDownPointY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPointY.Name = "numericUpDownPointY";
            this.numericUpDownPointY.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPointY.TabIndex = 1;
            // 
            // pointYLabel
            // 
            this.pointYLabel.AutoSize = true;
            this.pointYLabel.Location = new System.Drawing.Point(12, 106);
            this.pointYLabel.Name = "pointYLabel";
            this.pointYLabel.Size = new System.Drawing.Size(48, 16);
            this.pointYLabel.TabIndex = 4;
            this.pointYLabel.Text = "Y point";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(708, 593);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxPoint);
            this.Name = "PointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point";
            this.groupBoxPoint.ResumeLayout(false);
            this.groupBoxPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownPointX;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Label pointXLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownPointY;
        private System.Windows.Forms.Label pointYLabel;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.Button buttonBack;
    }
}