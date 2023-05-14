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
    public partial class PointRectCollisionForm : Form
    {
        public PointRectCollisionForm()
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

            int X = (int)numericUpDownRectX.Value;
            int Y = (int)numericUpDownRectY.Value;
            int Height = (int)numericUpDownRectHeight.Value;
            int Width = (int)numericUpDownRectWidth.Value;

            Point point = new Point { X = pX, Y = pY };
            Rectangles rectangle = new Rectangles { X = X, Y = Y, Height = Height, Width = Width };

            if (CollisionCheck.PointRectangleCollision(point, rectangle))
            {
                MessageBox.Show("The point and the rectangle collide.");
            }
            else
            {
                MessageBox.Show("The point and the rectangle do not collide.");
            }
        }
        public void showButton_Click(object sender, EventArgs e)
        {

            int pX = (int)pointXNumericUpDown.Value;
            int pY = (int)pointYNumericUpDown.Value;

            int X = (int)numericUpDownRectX.Value;
            int Y = (int)numericUpDownRectY.Value;
            int Height = (int)numericUpDownRectHeight.Value;
            int Width = (int)numericUpDownRectWidth.Value;

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Black, 2);
            Rectangle circle = new Rectangle(pX, pY, 1, 1);
            object1.DrawEllipse(pen, circle);

            System.Drawing.Graphics object2;
            object2 = this.CreateGraphics();
            Pen pen2 = new Pen(System.Drawing.Color.Red, 3);
            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            object2.DrawRectangle(pen2, rectangle);
        }

        public void radioButtonPointRect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPointRect.Checked)
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
