namespace NdpProject
{
    partial class CylinderForm
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
            this.groupBoxCylinder = new System.Windows.Forms.GroupBox();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonWidth = new System.Windows.Forms.RadioButton();
            this.radioButtonHeight = new System.Windows.Forms.RadioButton();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.cylinderButton = new System.Windows.Forms.Button();
            this.circleXLabel = new System.Windows.Forms.Label();
            this.circleRadLabel = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRad = new System.Windows.Forms.NumericUpDown();
            this.circleYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxCylinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCylinder
            // 
            this.groupBoxCylinder.Controls.Add(this.numericUpDownWidth);
            this.groupBoxCylinder.Controls.Add(this.label1);
            this.groupBoxCylinder.Controls.Add(this.radioButtonWidth);
            this.groupBoxCylinder.Controls.Add(this.radioButtonHeight);
            this.groupBoxCylinder.Controls.Add(this.numericUpDownHeight);
            this.groupBoxCylinder.Controls.Add(this.numericUpDownX);
            this.groupBoxCylinder.Controls.Add(this.cylinderButton);
            this.groupBoxCylinder.Controls.Add(this.circleXLabel);
            this.groupBoxCylinder.Controls.Add(this.circleRadLabel);
            this.groupBoxCylinder.Controls.Add(this.numericUpDownY);
            this.groupBoxCylinder.Controls.Add(this.numericUpDownRad);
            this.groupBoxCylinder.Controls.Add(this.circleYLabel);
            this.groupBoxCylinder.Location = new System.Drawing.Point(31, 108);
            this.groupBoxCylinder.Name = "groupBoxCylinder";
            this.groupBoxCylinder.Size = new System.Drawing.Size(274, 519);
            this.groupBoxCylinder.TabIndex = 8;
            this.groupBoxCylinder.TabStop = false;
            this.groupBoxCylinder.Text = "Drawing Cylinder";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(15, 374);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWidth.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "If you want horizontal cylinder select \r\nWidth value, otherwise select Height.\r\n";
            // 
            // radioButtonWidth
            // 
            this.radioButtonWidth.AutoSize = true;
            this.radioButtonWidth.Location = new System.Drawing.Point(6, 348);
            this.radioButtonWidth.Name = "radioButtonWidth";
            this.radioButtonWidth.Size = new System.Drawing.Size(62, 20);
            this.radioButtonWidth.TabIndex = 10;
            this.radioButtonWidth.TabStop = true;
            this.radioButtonWidth.Text = "Width";
            this.radioButtonWidth.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeight
            // 
            this.radioButtonHeight.AutoSize = true;
            this.radioButtonHeight.Location = new System.Drawing.Point(6, 274);
            this.radioButtonHeight.Name = "radioButtonHeight";
            this.radioButtonHeight.Size = new System.Drawing.Size(67, 20);
            this.radioButtonHeight.TabIndex = 9;
            this.radioButtonHeight.TabStop = true;
            this.radioButtonHeight.Text = "Height";
            this.radioButtonHeight.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(15, 300);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHeight.TabIndex = 7;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(12, 65);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX.TabIndex = 0;
            // 
            // cylinderButton
            // 
            this.cylinderButton.Location = new System.Drawing.Point(35, 465);
            this.cylinderButton.Name = "cylinderButton";
            this.cylinderButton.Size = new System.Drawing.Size(168, 30);
            this.cylinderButton.TabIndex = 6;
            this.cylinderButton.Text = "Confirm";
            this.cylinderButton.UseVisualStyleBackColor = true;
            this.cylinderButton.Click += new System.EventHandler(this.cylinderButton_Click);
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
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(15, 143);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY.TabIndex = 1;
            // 
            // numericUpDownRad
            // 
            this.numericUpDownRad.Location = new System.Drawing.Point(15, 223);
            this.numericUpDownRad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRad.Name = "numericUpDownRad";
            this.numericUpDownRad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRad.TabIndex = 2;
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
            this.buttonBack.Location = new System.Drawing.Point(696, 579);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CylinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxCylinder);
            this.Name = "CylinderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cylinder";
            this.groupBoxCylinder.ResumeLayout(false);
            this.groupBoxCylinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCylinder;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonWidth;
        private System.Windows.Forms.RadioButton radioButtonHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Button cylinderButton;
        private System.Windows.Forms.Label circleXLabel;
        private System.Windows.Forms.Label circleRadLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownRad;
        private System.Windows.Forms.Label circleYLabel;
        private System.Windows.Forms.Button buttonBack;
    }
}