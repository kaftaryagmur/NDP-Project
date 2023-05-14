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
    public partial class SphereRectPrismCollisionForm : Form
    {
        public SphereRectPrismCollisionForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)numericUpDownX1.Value;
            int Y1 = (int)numericUpDownY1.Value;
            int Rad1 = (int)numericUpDownRad1.Value;

            int rpX = (int)numericUpDownRectPrismX.Value;
            int rpY = (int)numericUpDownRectPrismY.Value;
            int rpHeight = (int)numericUpDownRectPrismHeight.Value;
            int rpWidth = (int)numericUpDownRectPrismWidth.Value;
            int rpDepth = (int)numericUpDownRectPrismDepth.Value;

            Sphere sphere = new Sphere { X = X1, Y = Y1, Radius = Rad1 };
            RectangularPrism prism = new RectangularPrism { X = rpX, Y = rpY, Height = rpHeight, Width = rpWidth, Depth = rpDepth };

            if (CollisionCheck.SpherePrismCollision(sphere, prism))
            {
                MessageBox.Show("The sphere and the rectangular prism collide.");
            }
            else
            {
                MessageBox.Show("The sphere and the rectangular prism do not collide.");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)numericUpDownX1.Value;
            int Y1 = (int)numericUpDownY1.Value;
            int Rad1 = (int)numericUpDownRad1.Value;

            int rpX = (int)numericUpDownRectPrismX.Value;
            int rpY = (int)numericUpDownRectPrismY.Value;
            int rpHeight = (int)numericUpDownRectPrismHeight.Value;
            int rpWidth = (int)numericUpDownRectPrismWidth.Value;
            int rpDepth = (int)numericUpDownRectPrismDepth.Value;

            System.Drawing.Graphics object1, object2;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();

            Pen pen1 = new Pen(System.Drawing.Color.DarkBlue, 5);
            Pen pen2 = new Pen(System.Drawing.Color.DarkCyan, 5);
            Rectangle circle = new Rectangle(X1, Y1, Rad1, Rad1);
            object1.DrawEllipse(pen1, circle);
            object2.DrawArc(pen2, X1, Y1 + Rad1 / 3, Rad1, Rad1 / 4, 180, 360);

            System.Drawing.Graphics object3, object4, line1, line2, line3, line4;
            object3 = this.CreateGraphics();
            object4 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen3 = new Pen(Color.Black, 3);
            Rectangle rectangle = new Rectangle(rpX, rpY, rpWidth, rpHeight);
            Rectangle rectangle2 = new Rectangle(rpX + rpDepth, rpY + rpDepth, rpWidth, rpHeight);
            object3.DrawRectangle(pen3, rectangle);
            object4.DrawRectangle(pen3, rectangle2);
            line1.DrawLine(pen3, rpX, rpY, rpX + rpDepth, rpY + rpDepth);
            line2.DrawLine(pen3, rpX + rpWidth, rpY, rpX + rpWidth + rpDepth, rpY + rpDepth);
            line3.DrawLine(pen3, rpX, rpY + rpHeight, rpX + rpDepth, rpY + rpHeight + rpDepth);
            line4.DrawLine(pen3, rpX + rpWidth, rpY + rpHeight, rpX + rpWidth + rpDepth, rpY + rpHeight + rpDepth);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
