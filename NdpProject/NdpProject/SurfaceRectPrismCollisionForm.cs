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
    public partial class SurfaceRectPrismCollisionForm : Form
    {
        public SurfaceRectPrismCollisionForm()
        {
            InitializeComponent();
        }
        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Width = (int)numericUpDownWidth.Value;
            int Depth = (int)numericUpDownDepth.Value;

            int rpX = (int)numericUpDownRectPrismX.Value;
            int rpY = (int)numericUpDownRectPrismY.Value;
            int rpHeight = (int)numericUpDownRectPrismHeight.Value;
            int rpWidth = (int)numericUpDownRectPrismWidth.Value;
            int rpDepth = (int)numericUpDownRectPrismDepth.Value;

            Surface surface = new Surface { X = X, Y = Y, Width = Width, Depth = Depth, };
            RectangularPrism prism = new RectangularPrism { X = rpX, Y = rpY, Height = rpHeight, Width = rpWidth, Depth = rpDepth };

            if (CollisionCheck.SurfacePrismCollision(surface, prism))
            {
                MessageBox.Show("The surface and the rectangular prism collide.");
            }
            else
            {
                MessageBox.Show("The surface and the rectangular prism do not collide.");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Width = (int)numericUpDownWidth.Value;
            int Depth = (int)numericUpDownDepth.Value;

            int rpX = (int)numericUpDownRectPrismX.Value;
            int rpY = (int)numericUpDownRectPrismY.Value;
            int rpHeight = (int)numericUpDownRectPrismHeight.Value;
            int rpWidth = (int)numericUpDownRectPrismWidth.Value;
            int rpDepth = (int)numericUpDownRectPrismDepth.Value;

            System.Drawing.Graphics object3, object4, line1, line2, line3, line4;
            object3 = this.CreateGraphics();
            object4 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen2 = new Pen(Color.Black, 3);
            Rectangle rectangle = new Rectangle(rpX, rpY, rpWidth, rpHeight);
            Rectangle rectangle2 = new Rectangle(rpX + rpDepth, rpY + rpDepth, rpWidth, rpHeight);
            object3.DrawRectangle(pen2, rectangle);
            object4.DrawRectangle(pen2, rectangle2);
            line1.DrawLine(pen2, rpX, rpY, rpX + rpDepth, rpY + rpDepth);
            line2.DrawLine(pen2, rpX + rpWidth, rpY, rpX + rpWidth + rpDepth, rpY + rpDepth);
            line3.DrawLine(pen2, rpX, rpY + rpHeight, rpX + rpDepth, rpY + rpHeight + rpDepth);
            line4.DrawLine(pen2, rpX + rpWidth, rpY + rpHeight, rpX + rpWidth + rpDepth, rpY + rpHeight + rpDepth);

            System.Drawing.Graphics line5, line6, line7, line8;
            line5 = this.CreateGraphics();
            line6 = this.CreateGraphics();
            line7 = this.CreateGraphics();
            line8 = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkBlue, 3);
            line5.DrawLine(pen, X, Y, X + Depth, Y + Depth);
            line6.DrawLine(pen, X + Width, Y, X + Width + Depth, Y + Depth);
            line7.DrawLine(pen, X, Y, X + Width, Y);
            line8.DrawLine(pen, X + Depth, Y + Depth, X + Depth + Width, Y + Depth);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
