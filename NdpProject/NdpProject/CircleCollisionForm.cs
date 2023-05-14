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
    public partial class CircleCollisionForm : Form
    {
        public CircleCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)circleColX1NumericUpDown.Value;
            int Y1 = (int)circleColY1NumericUpDown.Value;
            int Rad1 = (int)circleColRad1NumericUpDown.Value;

            int X2 = (int)circleColX2NumericUpDown.Value;
            int Y2 = (int)circleColY2NumericUpDown.Value;
            int Rad2 = (int)circleColRad2NumericUpDown.Value;

            Circle circle1 = new Circle { X = X1, Y = Y1, Radius = Rad1 };
            Circle circle2 = new Circle { X = X2, Y = Y2, Radius = Rad2 };

            if (CollisionCheck.CircleCircleCollision(circle1, circle2))
            {
                MessageBox.Show("Two circles collide.");
            }
            else
            {
                MessageBox.Show("Two circles do not collide.");
            }

        }

        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)circleColX1NumericUpDown.Value;
            int Y1 = (int)circleColY1NumericUpDown.Value;
            int Rad1 = (int)circleColRad1NumericUpDown.Value;

            int X2 = (int)circleColX2NumericUpDown.Value;
            int Y2 = (int)circleColY2NumericUpDown.Value;
            int Rad2 = (int)circleColRad2NumericUpDown.Value;

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen1 = new Pen(System.Drawing.Color.Violet, 5);
            Rectangle circle1 = new Rectangle(X1, Y1, Rad1, Rad1);
            object1.DrawEllipse(pen1, circle1);

            System.Drawing.Graphics object2;
            object2 = this.CreateGraphics();
            Pen pen2 = new Pen(System.Drawing.Color.DarkOrange, 5);
            Rectangle circle2 = new Rectangle(X2, Y2, Rad2, Rad2);
            object1.DrawEllipse(pen2, circle2);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }

        
    }
}
