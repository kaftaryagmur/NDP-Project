using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProject
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
            buttonBack.Visible = false;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            groupBoxRect.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownRectX.Value;
            int Y = (int)numericUpDownRectY.Value;
            int Height = (int)numericUpDownRectHeight.Value;
            int Width = (int)numericUpDownRectWidth.Value;
            
            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Red, 3);
            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            object1.DrawRectangle(pen, rectangle);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShapesForm form = new ShapesForm();
            form.Show();
            this.Close();
        }
    }
}
