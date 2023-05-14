namespace NdpProject
{
    partial class CircleForm
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
            this.numericUpDownCircleX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircleRad = new System.Windows.Forms.NumericUpDown();
            this.circleXLabel = new System.Windows.Forms.Label();
            this.circleYLabel = new System.Windows.Forms.Label();
            this.circleRadLabel = new System.Windows.Forms.Label();
            this.circleButton = new System.Windows.Forms.Button();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleRad)).BeginInit();
            this.groupBoxCircle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // circleXLabel
            // 
            this.circleXLabel.AutoSize = true;
            this.circleXLabel.Location = new System.Drawing.Point(12, 28);
            this.circleXLabel.Name = "circleXLabel";
            this.circleXLabel.Size = new System.Drawing.Size(47, 16);
            this.circleXLabel.TabIndex = 3;
            this.circleXLabel.Text = "X point";
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
            // circleRadLabel
            // 
            this.circleRadLabel.AutoSize = true;
            this.circleRadLabel.Location = new System.Drawing.Point(12, 186);
            this.circleRadLabel.Name = "circleRadLabel";
            this.circleRadLabel.Size = new System.Drawing.Size(50, 16);
            this.circleRadLabel.TabIndex = 5;
            this.circleRadLabel.Text = "Radius";
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(25, 260);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(168, 30);
            this.circleButton.TabIndex = 6;
            this.circleButton.Text = "Confirm";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // groupBoxCircle
            // 
            this.groupBoxCircle.Controls.Add(this.numericUpDownCircleX);
            this.groupBoxCircle.Controls.Add(this.circleButton);
            this.groupBoxCircle.Controls.Add(this.circleXLabel);
            this.groupBoxCircle.Controls.Add(this.circleRadLabel);
            this.groupBoxCircle.Controls.Add(this.numericUpDownCircleY);
            this.groupBoxCircle.Controls.Add(this.numericUpDownCircleRad);
            this.groupBoxCircle.Controls.Add(this.circleYLabel);
            this.groupBoxCircle.Location = new System.Drawing.Point(30, 304);
            this.groupBoxCircle.Name = "groupBoxCircle";
            this.groupBoxCircle.Size = new System.Drawing.Size(243, 308);
            this.groupBoxCircle.TabIndex = 7;
            this.groupBoxCircle.TabStop = false;
            this.groupBoxCircle.Text = "Drawing Circle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 645);
            this.panel1.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(665, 559);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(151, 48);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.groupBoxCircle);
            this.Controls.Add(this.panel1);
            this.Name = "CircleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircleRad)).EndInit();
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCircleX;
        private System.Windows.Forms.NumericUpDown numericUpDownCircleY;
        private System.Windows.Forms.NumericUpDown numericUpDownCircleRad;
        private System.Windows.Forms.Label circleXLabel;
        private System.Windows.Forms.Label circleYLabel;
        private System.Windows.Forms.Label circleRadLabel;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.GroupBox groupBoxCircle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
    }
}