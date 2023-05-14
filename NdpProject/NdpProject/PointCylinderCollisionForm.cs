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
    public partial class PointCylinderCollisionForm : Form
    {
        public PointCylinderCollisionForm()
        {
            InitializeComponent();
        }
        public void radioButtonPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPoint.Checked)
            {
                MessageBox.Show("Thank you!");
            }
        }
        public void checkButton_Click(object sender, EventArgs e)
        {
            int pX = (int)pointXNumericUpDown.Value;
            int pY = (int)pointYNumericUpDown.Value;

            int X = (int)cylinderXNumericUpDown.Value;
            int Y = (int)cylinderYNumericUpDown.Value;
            int Rad = (int)cylinderRadNumericUpDown.Value;
            int Height = (int)cylinderHNumericUpDown.Value;

            Point point = new Point { X = pX, Y = pY };
            Cylinder cylinder = new Cylinder { X = X, Y = Y, Radius = Rad, Height = Height };

            if (CollisionCheck.PointCylinderCollision(point, cylinder))
            {
                MessageBox.Show("The point and the cylinder collide.");
            }
            else
            {
                MessageBox.Show("The point and the cylinder do not collide.");
            }
        }
        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int pX = (int)pointXNumericUpDown.Value;
            int pY = (int)pointYNumericUpDown.Value;

            int X1 = (int)cylinderXNumericUpDown.Value;
            int Y1 = (int)cylinderYNumericUpDown.Value;
            int Rad1 = (int)cylinderRadNumericUpDown.Value;
            int Height = (int)cylinderHNumericUpDown.Value;

            Pen pen = new Pen(System.Drawing.Color.Black, 2);
            Pen pen2 = new Pen(Color.DarkGreen, 5);

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Rectangle circle = new Rectangle(pX, pY, 1, 1);
            object1.DrawEllipse(pen, circle);

            Graphics object2, object3, line1, line2;
            object2 = this.CreateGraphics();
            object3 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();

            Rectangle circle1 = new Rectangle(X1, Y1, Rad1, Rad1 / 2);
            Rectangle circle2 = new Rectangle(X1, Y1 + Height, Rad1, Rad1 / 2);

            object2.DrawEllipse(pen2, circle1);
            object3.DrawEllipse(pen2, circle2);
            line1.DrawLine(pen2, X1, Y1 + Rad1 / 4, X1, Y1 + Rad1 / 4 + Height);
            line2.DrawLine(pen2, X1 + Rad1, Y1 + Rad1 / 4, X1 + Rad1, Y1 + Height + Rad1 / 4);


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
