namespace NdpProject
{
    partial class PointRectCollisionForm
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
            this.radioButtonPointRect = new System.Windows.Forms.RadioButton();
            this.pointXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointXLabel = new System.Windows.Forms.Label();
            this.pointYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointYLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rectWidthLabel = new System.Windows.Forms.Label();
            this.numericUpDownRectWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRectX = new System.Windows.Forms.NumericUpDown();
            this.rectXLabel = new System.Windows.Forms.Label();
            this.rectHeightLabel = new System.Windows.Forms.Label();
            this.numericUpDownRectY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRectHeight = new System.Windows.Forms.NumericUpDown();
            this.rcetYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(457, 482);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(112, 53);
            this.showButton.TabIndex = 18;
            this.showButton.Text = "Show Collision";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(291, 482);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(112, 53);
            this.checkButton.TabIndex = 17;
            this.checkButton.Text = "Collision Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPointRect);
            this.groupBox1.Controls.Add(this.pointXNumericUpDown);
            this.groupBox1.Controls.Add(this.pointXLabel);
            this.groupBox1.Controls.Add(this.pointYNumericUpDown);
            this.groupBox1.Controls.Add(this.pointYLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 346);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Point";
            // 
            // radioButtonPointRect
            // 
            this.radioButtonPointRect.AutoSize = true;
            this.radioButtonPointRect.Location = new System.Drawing.Point(6, 248);
            this.radioButtonPointRect.Name = "radioButtonPointRect";
            this.radioButtonPointRect.Size = new System.Drawing.Size(210, 36);
            this.radioButtonPointRect.TabIndex = 8;
            this.radioButtonPointRect.TabStop = true;
            this.radioButtonPointRect.Text = "The point will be small and you\r\n have to look carefully. ";
            this.radioButtonPointRect.UseVisualStyleBackColor = true;
            this.radioButtonPointRect.CheckedChanged += new System.EventHandler(this.radioButtonPointRect_CheckedChanged);
            // 
            // pointXNumericUpDown
            // 
            this.pointXNumericUpDown.Location = new System.Drawing.Point(12, 65);
            this.pointXNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.pointXNumericUpDown.Name = "pointXNumericUpDown";
            this.pointXNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.pointXNumericUpDown.TabIndex = 0;
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
            // pointYNumericUpDown
            // 
            this.pointYNumericUpDown.Location = new System.Drawing.Point(15, 143);
            this.pointYNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.pointYNumericUpDown.Name = "pointYNumericUpDown";
            this.pointYNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.pointYNumericUpDown.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rectWidthLabel);
            this.groupBox2.Controls.Add(this.numericUpDownRectWidth);
            this.groupBox2.Controls.Add(this.numericUpDownRectX);
            this.groupBox2.Controls.Add(this.rectXLabel);
            this.groupBox2.Controls.Add(this.rectHeightLabel);
            this.groupBox2.Controls.Add(this.numericUpDownRectY);
            this.groupBox2.Controls.Add(this.numericUpDownRectHeight);
            this.groupBox2.Controls.Add(this.rcetYLabel);
            this.groupBox2.Location = new System.Drawing.Point(614, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 346);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Rectangle";
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
            // rcetYLabel
            // 
            this.rcetYLabel.AutoSize = true;
            this.rcetYLabel.Location = new System.Drawing.Point(12, 106);
            this.rcetYLabel.Name = "rcetYLabel";
            this.rcetYLabel.Size = new System.Drawing.Size(48, 16);
            this.rcetYLabel.TabIndex = 4;
            this.rcetYLabel.Text = "Y point";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(351, 562);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PointRectCollisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "PointRectCollisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-Rectangle Collision Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown pointXNumericUpDown;
        private System.Windows.Forms.Label pointXLabel;
        private System.Windows.Forms.NumericUpDown pointYNumericUpDown;
        private System.Windows.Forms.Label pointYLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label rectWidthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownRectWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownRectX;
        private System.Windows.Forms.Label rectXLabel;
        private System.Windows.Forms.Label rectHeightLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownRectY;
        private System.Windows.Forms.NumericUpDown numericUpDownRectHeight;
        private System.Windows.Forms.Label rcetYLabel;
        private System.Windows.Forms.RadioButton radioButtonPointRect;
        private System.Windows.Forms.Button buttonBack;
    }
}