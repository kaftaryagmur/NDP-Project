namespace NdpProject
{
    partial class PointCylinderCollisionForm
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
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.pointXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleColX1Label = new System.Windows.Forms.Label();
            this.pointYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleColY1Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cylinderHNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cylinderXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleXLabel = new System.Windows.Forms.Label();
            this.circleRadLabel = new System.Windows.Forms.Label();
            this.cylinderYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cylinderRadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleYLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderHNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderRadNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(457, 469);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(112, 53);
            this.showButton.TabIndex = 18;
            this.showButton.Text = "Show Collision";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(291, 469);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(112, 53);
            this.checkButton.TabIndex = 17;
            this.checkButton.Text = "Collision Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPoint);
            this.groupBox1.Controls.Add(this.pointXNumericUpDown);
            this.groupBox1.Controls.Add(this.circleColX1Label);
            this.groupBox1.Controls.Add(this.pointYNumericUpDown);
            this.groupBox1.Controls.Add(this.circleColY1Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 308);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Point";
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.AutoSize = true;
            this.radioButtonPoint.Location = new System.Drawing.Point(15, 209);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(210, 36);
            this.radioButtonPoint.TabIndex = 15;
            this.radioButtonPoint.TabStop = true;
            this.radioButtonPoint.Text = "The point will be small and you\r\n have to look carefully. ";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.radioButtonPoint_CheckedChanged);
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
            // circleColX1Label
            // 
            this.circleColX1Label.AutoSize = true;
            this.circleColX1Label.Location = new System.Drawing.Point(12, 28);
            this.circleColX1Label.Name = "circleColX1Label";
            this.circleColX1Label.Size = new System.Drawing.Size(47, 16);
            this.circleColX1Label.TabIndex = 3;
            this.circleColX1Label.Text = "X point";
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
            // circleColY1Label
            // 
            this.circleColY1Label.AutoSize = true;
            this.circleColY1Label.Location = new System.Drawing.Point(12, 106);
            this.circleColY1Label.Name = "circleColY1Label";
            this.circleColY1Label.Size = new System.Drawing.Size(48, 16);
            this.circleColY1Label.TabIndex = 4;
            this.circleColY1Label.Text = "Y point";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cylinderHNumericUpDown);
            this.groupBox2.Controls.Add(this.cylinderXNumericUpDown);
            this.groupBox2.Controls.Add(this.circleXLabel);
            this.groupBox2.Controls.Add(this.circleRadLabel);
            this.groupBox2.Controls.Add(this.cylinderYNumericUpDown);
            this.groupBox2.Controls.Add(this.cylinderRadNumericUpDown);
            this.groupBox2.Controls.Add(this.circleYLabel);
            this.groupBox2.Location = new System.Drawing.Point(613, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 345);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Cylinder ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Height";
            // 
            // cylinderHNumericUpDown
            // 
            this.cylinderHNumericUpDown.Location = new System.Drawing.Point(15, 294);
            this.cylinderHNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.cylinderHNumericUpDown.Name = "cylinderHNumericUpDown";
            this.cylinderHNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.cylinderHNumericUpDown.TabIndex = 12;
            // 
            // cylinderXNumericUpDown
            // 
            this.cylinderXNumericUpDown.Location = new System.Drawing.Point(12, 65);
            this.cylinderXNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.cylinderXNumericUpDown.Name = "cylinderXNumericUpDown";
            this.cylinderXNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.cylinderXNumericUpDown.TabIndex = 0;
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
            // cylinderYNumericUpDown
            // 
            this.cylinderYNumericUpDown.Location = new System.Drawing.Point(15, 143);
            this.cylinderYNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.cylinderYNumericUpDown.Name = "cylinderYNumericUpDown";
            this.cylinderYNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.cylinderYNumericUpDown.TabIndex = 1;
            // 
            // cylinderRadNumericUpDown
            // 
            this.cylinderRadNumericUpDown.Location = new System.Drawing.Point(15, 223);
            this.cylinderRadNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.cylinderRadNumericUpDown.Name = "cylinderRadNumericUpDown";
            this.cylinderRadNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.cylinderRadNumericUpDown.TabIndex = 2;
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
            this.buttonBack.Location = new System.Drawing.Point(351, 551);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PointCylinderCollisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "PointCylinderCollisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-Cylinder Collision Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderHNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderRadNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.NumericUpDown pointXNumericUpDown;
        private System.Windows.Forms.Label circleColX1Label;
        private System.Windows.Forms.NumericUpDown pointYNumericUpDown;
        private System.Windows.Forms.Label circleColY1Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cylinderHNumericUpDown;
        private System.Windows.Forms.NumericUpDown cylinderXNumericUpDown;
        private System.Windows.Forms.Label circleXLabel;
        private System.Windows.Forms.Label circleRadLabel;
        private System.Windows.Forms.NumericUpDown cylinderYNumericUpDown;
        private System.Windows.Forms.NumericUpDown cylinderRadNumericUpDown;
        private System.Windows.Forms.Label circleYLabel;
        private System.Windows.Forms.Button buttonBack;
    }
}