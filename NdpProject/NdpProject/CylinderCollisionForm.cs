using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NdpProject
{
    public partial class CylinderCollisionForm : Form
    {
        public CylinderCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)numericUpDownX1.Value;
            int Y1 = (int)numericUpDownY1.Value;
            int Rad1 = (int)numericUpDownRad1.Value;
            int Height = (int)numericUpDownHeight.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Rad2 = (int)numericUpDownRad2.Value;
            int Width = (int)numericUpDownWidth.Value;

            Cylinder cylinder1 = new Cylinder { X = X1, Y = Y1, Radius = Rad1, Height = Height };
            Cylinder cylinder2 = new Cylinder { X = X2, Y = Y2, Radius = Rad2, Height = Width };

            if (CollisionCheck.CylinderCylinderCollision(cylinder1, cylinder2))
            {
                MessageBox.Show("Two cylinders collide.");
            }
            else
            {
                MessageBox.Show("Two cylinders do not collide.");
            }
        }
        public void showButton_Click(object sender, EventArgs e)
        {
            int X1 = (int)numericUpDownX1.Value;
            int Y1 = (int)numericUpDownY1.Value;
            int Rad1 = (int)numericUpDownRad1.Value;
            int Height = (int)numericUpDownHeight.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Rad2 = (int)numericUpDownRad2.Value;
            int Width = (int)numericUpDownWidth.Value;

            Pen pen = new Pen(Color.BlueViolet, 5);
            Pen pen2 = new Pen(Color.DarkGreen, 5);

            Graphics object1, object2, line1, line2;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();

            Rectangle circle1 = new Rectangle(X1, Y1, Rad1, Rad1 / 2);
            Rectangle circle2 = new Rectangle(X1, Y1 + Height, Rad1, Rad1 / 2);

            object1.DrawEllipse(pen, circle1);
            object2.DrawEllipse(pen, circle2);
            line1.DrawLine(pen, X1, Y1 + Rad1 / 4, X1, Y1 + Rad1 / 4 + Height);
            line2.DrawLine(pen, X1 + Rad1, Y1 + Rad1 / 4, X1 + Rad1, Y1 + Height + Rad1 / 4);

            Graphics object3, object4, line3, line4;
            object3 = this.CreateGraphics();
            object4 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();

            Rectangle circle3 = new Rectangle(X2, Y2, Rad2, Rad2 / 2);
            Rectangle circle4 = new Rectangle(X2 + Width, Y2 + Width, Rad2, Rad2 / 2);

            object3.DrawEllipse(pen2, circle3);
            object4.DrawEllipse(pen2, circle4);
            line3.DrawLine(pen2, X2, Y2 + Rad2 / 4, X2 + Width, Y2 + Width + Rad2 / 4);
            line4.DrawLine(pen2, X2 + Rad2, Y2 + Rad2 / 4, X2 + Rad2 + Width, Y2 + Width + Rad2 / 4);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
