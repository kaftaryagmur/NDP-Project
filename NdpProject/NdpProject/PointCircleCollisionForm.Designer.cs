namespace NdpProject
{
    partial class PointCircleCollisionForm
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
            this.circleXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleColX2Label = new System.Windows.Forms.Label();
            this.circleColRad2Label = new System.Windows.Forms.Label();
            this.circleYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleRadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleColY2Label = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(455, 474);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(112, 53);
            this.showButton.TabIndex = 14;
            this.showButton.Text = "Show Collision";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(289, 474);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(112, 53);
            this.checkButton.TabIndex = 13;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 308);
            this.groupBox1.TabIndex = 11;
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
            this.groupBox2.Controls.Add(this.circleXNumericUpDown);
            this.groupBox2.Controls.Add(this.circleColX2Label);
            this.groupBox2.Controls.Add(this.circleColRad2Label);
            this.groupBox2.Controls.Add(this.circleYNumericUpDown);
            this.groupBox2.Controls.Add(this.circleRadNumericUpDown);
            this.groupBox2.Controls.Add(this.circleColY2Label);
            this.groupBox2.Location = new System.Drawing.Point(627, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 308);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Circle ";
            // 
            // circleXNumericUpDown
            // 
            this.circleXNumericUpDown.Location = new System.Drawing.Point(12, 65);
            this.circleXNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.circleXNumericUpDown.Name = "circleXNumericUpDown";
            this.circleXNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.circleXNumericUpDown.TabIndex = 0;
            // 
            // circleColX2Label
            // 
            this.circleColX2Label.AutoSize = true;
            this.circleColX2Label.Location = new System.Drawing.Point(12, 28);
            this.circleColX2Label.Name = "circleColX2Label";
            this.circleColX2Label.Size = new System.Drawing.Size(47, 16);
            this.circleColX2Label.TabIndex = 3;
            this.circleColX2Label.Text = "X point";
            // 
            // circleColRad2Label
            // 
            this.circleColRad2Label.AutoSize = true;
            this.circleColRad2Label.Location = new System.Drawing.Point(12, 186);
            this.circleColRad2Label.Name = "circleColRad2Label";
            this.circleColRad2Label.Size = new System.Drawing.Size(53, 16);
            this.circleColRad2Label.TabIndex = 5;
            this.circleColRad2Label.Text = "Radius ";
            // 
            // circleYNumericUpDown
            // 
            this.circleYNumericUpDown.Location = new System.Drawing.Point(15, 143);
            this.circleYNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.circleYNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.circleYNumericUpDown.Name = "circleYNumericUpDown";
            this.circleYNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.circleYNumericUpDown.TabIndex = 1;
            // 
            // circleRadNumericUpDown
            // 
            this.circleRadNumericUpDown.Location = new System.Drawing.Point(15, 223);
            this.circleRadNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.circleRadNumericUpDown.Name = "circleRadNumericUpDown";
            this.circleRadNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.circleRadNumericUpDown.TabIndex = 2;
            // 
            // circleColY2Label
            // 
            this.circleColY2Label.AutoSize = true;
            this.circleColY2Label.Location = new System.Drawing.Point(12, 106);
            this.circleColY2Label.Name = "circleColY2Label";
            this.circleColY2Label.Size = new System.Drawing.Size(48, 16);
            this.circleColY2Label.TabIndex = 4;
            this.circleColY2Label.Text = "Y point";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(352, 554);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PointCircleCollisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PointCircleCollisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-Circle Collision Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown pointXNumericUpDown;
        private System.Windows.Forms.Label circleColX1Label;
        private System.Windows.Forms.NumericUpDown pointYNumericUpDown;
        private System.Windows.Forms.Label circleColY1Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown circleXNumericUpDown;
        private System.Windows.Forms.Label circleColX2Label;
        private System.Windows.Forms.Label circleColRad2Label;
        private System.Windows.Forms.NumericUpDown circleYNumericUpDown;
        private System.Windows.Forms.NumericUpDown circleRadNumericUpDown;
        private System.Windows.Forms.Label circleColY2Label;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.Button buttonBack;
    }
}