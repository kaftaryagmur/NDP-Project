namespace NdpProject
{
    partial class mainForm
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
            this.shapesButton = new System.Windows.Forms.Button();
            this.collisionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapesButton
            // 
            this.shapesButton.Location = new System.Drawing.Point(132, 337);
            this.shapesButton.Name = "shapesButton";
            this.shapesButton.Size = new System.Drawing.Size(200, 150);
            this.shapesButton.TabIndex = 0;
            this.shapesButton.Text = "Shapes";
            this.shapesButton.UseVisualStyleBackColor = true;
            this.shapesButton.Click += new System.EventHandler(this.shapesButton_Click);
            // 
            // collisionsButton
            // 
            this.collisionsButton.Location = new System.Drawing.Point(515, 337);
            this.collisionsButton.Name = "collisionsButton";
            this.collisionsButton.Size = new System.Drawing.Size(200, 150);
            this.collisionsButton.TabIndex = 1;
            this.collisionsButton.Text = "Collisions";
            this.collisionsButton.UseVisualStyleBackColor = true;
            this.collisionsButton.Click += new System.EventHandler(this.collisionsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.collisionsButton);
            this.Controls.Add(this.shapesButton);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shapesButton;
        private System.Windows.Forms.Button collisionsButton;
    }
}

