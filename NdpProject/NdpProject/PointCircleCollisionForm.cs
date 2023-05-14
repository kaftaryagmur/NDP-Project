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
    public partial class PointCircleCollisionForm : Form
    {
        public PointCircleCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)pointXNumericUpDown.Value;
            int Y = (int)pointYNumericUpDown.Value;

            int X1 = (int)circleXNumericUpDown.Value;
            int Y1 = (int)circleYNumericUpDown.Value;
            int Rad1 = (int)circleRadNumericUpDown.Value;

            Point point = new Point { X = X, Y = Y };
            Circle circle = new Circle { X = X1, Y = Y1, Radius = Rad1 };
            if (CollisionCheck.PointCircleCollision(point, circle))
            {
                MessageBox.Show("The point and the circle collide.");
            }
            else
            {
                MessageBox.Show("The point and the circle do not collide.");
            }
        }

        public void showButton_Click(object sender, EventArgs e)
        {
            int X = (int)pointXNumericUpDown.Value;
            int Y = (int)pointYNumericUpDown.Value;

            int X1 = (int)circleXNumericUpDown.Value;
            int Y1 = (int)circleYNumericUpDown.Value;
            int Rad1 = (int)circleRadNumericUpDown.Value;

            System.Drawing.Graphics object2;
            object2 = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Black, 2);
            Rectangle circle = new Rectangle(X, Y, 1, 1);
            object2.DrawEllipse(pen, circle);

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen1 = new Pen(System.Drawing.Color.BlueViolet, 5);
            Rectangle circle1 = new Rectangle(X1, Y1, Rad1, Rad1);
            object1.DrawEllipse(pen1, circle1);

        }
        public void radioButtonPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPoint.Checked)
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
