using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProject
{
    public partial class RectPrismForm : Form
    {
        public RectPrismForm()
        {
            InitializeComponent();
            buttonBack.Visible = false;

        }

        private void rectPrsimButton_Click(object sender, EventArgs e)
        {
            groupBoxRectPrism.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownRectPrismX.Value;
            int Y = (int)numericUpDownRectPrismY.Value;
            //int Z = (int)numericUpDownRectPrismZ.Value;
            int Height = (int)numericUpDownRectPrismHeight.Value;
            int Width = (int)numericUpDownRectPrismWidth.Value;
            int Depth = (int)numericUpDownRectPrismDepth.Value;

            System.Drawing.Graphics object1, object2, line1, line2, line3, line4;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            Rectangle rectangle2 = new Rectangle(X + Depth, Y + Depth, Width, Height);
            object1.DrawRectangle(pen, rectangle);
            object2.DrawRectangle(pen, rectangle2);
            line1.DrawLine(pen, X, Y, X + Depth, Y + Depth);
            line2.DrawLine(pen, X + Width, Y, X + Width + Depth, Y + Depth);
            line3.DrawLine(pen, X, Y + Height, X + Depth, Y + Height + Depth);
            line4.DrawLine(pen, X + Width, Y + Height, X + Width + Depth, Y + Height + Depth);



        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShapesForm form = new ShapesForm();
            form.Show();
            this.Close();
        }
    }
}
