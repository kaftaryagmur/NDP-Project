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
    public partial class SphereCylinderCollisionForm : Form
    {
        public SphereCylinderCollisionForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int sX = (int)numericUpDownX1.Value;
            int sY = (int)numericUpDownY1.Value;
            int sRad = (int)numericUpDownRad1.Value;

            int cX = (int)cylinderXNumericUpDown.Value;
            int cY = (int)cylinderYNumericUpDown.Value;
            int cRad = (int)cylinderRadNumericUpDown.Value;
            int cHeight = (int)cylinderHNumericUpDown.Value;

            Sphere sphere = new Sphere { X = sX, Y = sY, Radius = sRad };
            Cylinder cylinder = new Cylinder { X = cX, Y = cY, Radius = cRad, Height = cHeight };

            if (CollisionCheck.SphereCylinderCollision(sphere, cylinder))
            {
                MessageBox.Show("The sphere and the cylinder collide.");
            }
            else
            {
                MessageBox.Show("The sphere and the cylinder do not collide.");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int sX = (int)numericUpDownX1.Value;
            int sY = (int)numericUpDownY1.Value;
            int sRad = (int)numericUpDownRad1.Value;

            int cX = (int)cylinderXNumericUpDown.Value;
            int cY = (int)cylinderYNumericUpDown.Value;
            int cRad = (int)cylinderRadNumericUpDown.Value;
            int cHeight = (int)cylinderHNumericUpDown.Value;

            System.Drawing.Graphics object1, object2;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();

            Pen pen1 = new Pen(Color.Chocolate, 5);
            Pen pen2 = new Pen(Color.Bisque, 5);

            Rectangle circle1 = new Rectangle(sX, sY, sRad, sRad);
            object1.DrawEllipse(pen1, circle1);
            object2.DrawArc(pen2, sX, sY + sRad / 3, sRad, sRad / 4, 180, 360);

            Graphics object3, object4, line1, line2;
            object3 = this.CreateGraphics();
            object4 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();

            Pen pen3 = new Pen(Color.BlueViolet, 5);

            Rectangle circle2 = new Rectangle(cX, cY, cRad, cRad / 2);
            Rectangle circle3 = new Rectangle(cX, cY + cHeight, cRad, cRad / 2);

            object3.DrawEllipse(pen3, circle2);
            object4.DrawEllipse(pen3, circle3);
            line1.DrawLine(pen3, cX, cY + cRad / 4, cX, cY + cRad / 4 + cHeight);
            line2.DrawLine(pen3, cX + cRad, cY + cRad / 4, cX + cRad, cY + cHeight + cRad / 4);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
