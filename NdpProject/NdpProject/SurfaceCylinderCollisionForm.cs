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
    public partial class SurfaceCylinderCollisionForm : Form
    {
        public SurfaceCylinderCollisionForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Width = (int)numericUpDownWidth.Value;
            int Depth = (int)numericUpDownDepth.Value;

            int cX = (int)cylinderXNumericUpDown.Value;
            int cY = (int)cylinderYNumericUpDown.Value;
            int cRad = (int)cylinderRadNumericUpDown.Value;
            int cHeight = (int)cylinderHNumericUpDown.Value;

            Surface surface = new Surface { X = X, Y = Y, Width = Width, Depth = Depth, };
            Cylinder cylinder = new Cylinder { X = cX, Y = cY, Radius = cRad, Height = cHeight };

            if (CollisionCheck.SurfaceCylinderCollision(surface, cylinder))
            {
                MessageBox.Show("The surface and the cylinder collide.");
            }
            else
            {
                MessageBox.Show("The surface and the cylinder do not collide.");
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

            int cX = (int)cylinderXNumericUpDown.Value;
            int cY = (int)cylinderYNumericUpDown.Value;
            int cRad = (int)cylinderRadNumericUpDown.Value;
            int cHeight = (int)cylinderHNumericUpDown.Value;

            System.Drawing.Graphics line1, line2, line3, line4;

            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkBlue, 3);

            line1.DrawLine(pen, X, Y, X + Depth, Y + Depth);
            line2.DrawLine(pen, X + Width, Y, X + Width + Depth, Y + Depth);
            line3.DrawLine(pen, X, Y, X + Width, Y);
            line4.DrawLine(pen, X + Depth, Y + Depth, X + Depth + Width, Y + Depth);

            Graphics object1, object2, line5, line6;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();
            line5 = this.CreateGraphics();
            line6 = this.CreateGraphics();

            Pen pen2 = new Pen(Color.BlueViolet, 5);

            Rectangle circle2 = new Rectangle(cX, cY, cRad, cRad / 2);
            Rectangle circle3 = new Rectangle(cX, cY + cHeight, cRad, cRad / 2);

            object1.DrawEllipse(pen2, circle2);
            object2.DrawEllipse(pen2, circle3);
            line5.DrawLine(pen2, cX, cY + cRad / 4, cX, cY + cRad / 4 + cHeight);
            line6.DrawLine(pen2, cX + cRad, cY + cRad / 4, cX + cRad, cY + cHeight + cRad / 4);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
