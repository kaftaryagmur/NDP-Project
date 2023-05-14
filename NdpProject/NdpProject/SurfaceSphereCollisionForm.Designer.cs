namespace NdpProject
{
    partial class SurfaceSphereCollisionForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.surfaceDepthLabel = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.surfaceWidthLabel = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.surfaceXLabel = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.surfaceYLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownZ2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRad2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad2)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(464, 445);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(112, 53);
            this.showButton.TabIndex = 40;
            this.showButton.Text = "Show Collision";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(298, 445);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(112, 53);
            this.checkButton.TabIndex = 39;
            this.checkButton.Text = "Collision Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.surfaceDepthLabel);
            this.groupBox2.Controls.Add(this.numericUpDownDepth);
            this.groupBox2.Controls.Add(this.surfaceWidthLabel);
            this.groupBox2.Controls.Add(this.numericUpDownWidth);
            this.groupBox2.Controls.Add(this.numericUpDownX);
            this.groupBox2.Controls.Add(this.surfaceXLabel);
            this.groupBox2.Controls.Add(this.numericUpDownY);
            this.groupBox2.Controls.Add(this.surfaceYLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 350);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Surface";
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
            1000,
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
            1000,
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
            1000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX.TabIndex = 0;
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
            1000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownZ2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownX2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownY2);
            this.groupBox1.Controls.Add(this.numericUpDownRad2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(627, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 343);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing Sphere ";
            // 
            // numericUpDownZ2
            // 
            this.numericUpDownZ2.Location = new System.Drawing.Point(15, 220);
            this.numericUpDownZ2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownZ2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownZ2.Name = "numericUpDownZ2";
            this.numericUpDownZ2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownZ2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Z point";
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.Location = new System.Drawing.Point(12, 65);
            this.numericUpDownX2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownX2.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "X point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Radius";
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.Location = new System.Drawing.Point(15, 143);
            this.numericUpDownY2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownY2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY2.TabIndex = 1;
            // 
            // numericUpDownRad2
            // 
            this.numericUpDownRad2.Location = new System.Drawing.Point(15, 298);
            this.numericUpDownRad2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRad2.Name = "numericUpDownRad2";
            this.numericUpDownRad2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRad2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y point";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(363, 544);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 42;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SurfaceSphereCollisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "SurfaceSphereCollisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surface-Sphere Collision Check";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label surfaceDepthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label surfaceWidthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label surfaceXLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label surfaceYLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownZ2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.NumericUpDown numericUpDownRad2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBack;
    }
}