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
    public partial class PointRectPrsimCollisionForm : Form
    {
        public PointRectPrsimCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int pX = (int)pointXNumericUpDown.Value;
            int pY = (int)pointYNumericUpDown.Value;

            int rpX = (int)numericUpDownRectPrismX.Value;
            int rpY = (int)numericUpDownRectPrismY.Value;
            int rpHeight = (int)numericUpDownRectPrismHeight.Value;
            int rpWidth = (int)numericUpDownRectPrismWidth.Value;
            int rpDepth = (int)numericUpDownRectPrismDepth.Value;

            Point point = new Point { X = pX, Y = pY };
            RectangularPrism prism = new RectangularPrism { X = rpX, Y = rpY, Height = rpHeight, Width = rpWidth, Depth = rpDepth };

            if (CollisionCheck.PointPrismCollision(point, prism))
            {
                MessageBox.Show("The point and the rectangular prism collide.");
            }
            else
            {
                MessageBox.Show("The point and the rectangular prism do not collide.");
            }
        }

        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int pX = (int)pointXNumericUpDown.Value;
            int pY = (int)pointYNumericUpDown.Value;

            int X = (int)numericUpDownRectPrismX.Value;
            int Y = (int)numericUpDownRectPrismY.Value;
            int Height = (int)numericUpDownRectPrismHeight.Value;
            int Width = (int)numericUpDownRectPrismWidth.Value;
            int Depth = (int)numericUpDownRectPrismDepth.Value;

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Red, 2);
            Rectangle circle = new Rectangle(pX, pY, 1, 1);
            object1.DrawEllipse(pen, circle);

            System.Drawing.Graphics object2, object3, line1, line2, line3, line4;
            object2 = this.CreateGraphics();
            object3 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen2 = new Pen(Color.Black, 3);
            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            Rectangle rectangle2 = new Rectangle(X + Depth, Y + Depth, Width, Height);
            object2.DrawRectangle(pen2, rectangle);
            object3.DrawRectangle(pen2, rectangle2);
            line1.DrawLine(pen2, X, Y, X + Depth, Y + Depth);
            line2.DrawLine(pen2, X + Width, Y, X + Width + Depth, Y + Depth);
            line3.DrawLine(pen2, X, Y + Height, X + Depth, Y + Height + Depth);
            line4.DrawLine(pen2, X + Width, Y + Height, X + Width + Depth, Y + Height + Depth);

        }
        public void radioButtonPointRectPrism_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPointRectPrism.Checked)
            {
                MessageBox.Show("Thank you!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}