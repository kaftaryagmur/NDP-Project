namespace NdpProject
{
    partial class PointSphereCollisionForm
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
            this.radioButtonPointSphere = new System.Windows.Forms.RadioButton();
            this.pointXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointXLabel = new System.Windows.Forms.Label();
            this.pointYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointYLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.circleXLabel = new System.Windows.Forms.Label();
            this.circleRadLabel = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRad = new System.Windows.Forms.NumericUpDown();
            this.circleYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(461, 480);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(112, 53);
            this.showButton.TabIndex = 22;
            this.showButton.Text = "Show Collision";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(295, 480);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(112, 53);
            this.checkButton.TabIndex = 21;
            this.checkButton.Text = "Collision Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPointSphere);
            this.groupBox1.Controls.Add(this.pointXNumericUpDown);
            this.groupBox1.Controls.Add(this.pointXLabel);
            this.groupBox1.Controls.Add(this.pointYNumericUpDown);
            this.groupBox1.Controls.Add(this.pointYLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 280);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Point";
            // 
            // radioButtonPointSphere
            // 
            this.radioButtonPointSphere.AutoSize = true;
            this.radioButtonPointSphere.Location = new System.Drawing.Point(6, 209);
            this.radioButtonPointSphere.Name = "radioButtonPointSphere";
            this.radioButtonPointSphere.Size = new System.Drawing.Size(210, 36);
            this.radioButtonPointSphere.TabIndex = 8;
            this.radioButtonPointSphere.TabStop = true;
            this.radioButtonPointSphere.Text = "The point will be small and you\r\n have to look carefully. ";
            this.radioButtonPointSphere.UseVisualStyleBackColor = true;
            this.radioButtonPointSphere.CheckedChanged += new System.EventHandler(this.radioButtonPointSphere_CheckedChanged);
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
            this.groupBox2.Controls.Add(this.numericUpDownZ);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownX);
            this.groupBox2.Controls.Add(this.circleXLabel);
            this.groupBox2.Controls.Add(this.circleRadLabel);
            this.groupBox2.Controls.Add(this.numericUpDownY);
            this.groupBox2.Controls.Add(this.numericUpDownRad);
            this.groupBox2.Controls.Add(this.circleYLabel);
            this.groupBox2.Location = new System.Drawing.Point(627, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 343);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Sphere";
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(15, 220);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownZ.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Z point";
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
            this.circleRadLabel.Location = new System.Drawing.Point(12, 261);
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
            this.numericUpDownRad.Location = new System.Drawing.Point(15, 298);
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
            this.buttonBack.Location = new System.Drawing.Point(358, 562);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PointSphereCollisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "PointSphereCollisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-Sphere Collision Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPointSphere;
        private System.Windows.Forms.NumericUpDown pointXNumericUpDown;
        private System.Windows.Forms.Label pointXLabel;
        private System.Windows.Forms.NumericUpDown pointYNumericUpDown;
        private System.Windows.Forms.Label pointYLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label circleXLabel;
        private System.Windows.Forms.Label circleRadLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownRad;
        private System.Windows.Forms.Label circleYLabel;
        private System.Windows.Forms.Button buttonBack;
    }
}