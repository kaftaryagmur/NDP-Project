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
    public partial class RectCircleForm : Form
    {
        public RectCircleForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownRectX.Value;
            int Y = (int)numericUpDownRectY.Value;
            int Height = (int)numericUpDownRectHeight.Value;
            int Width = (int)numericUpDownRectWidth.Value;

            int cX = (int)numericUpDownCircleX.Value;
            int cY = (int)numericUpDownCircleY.Value;
            int Radius = (int)numericUpDownCircleRad.Value;

            Rectangles rectangle = new Rectangles { X = X, Y = Y, Width = Width, Height = Height };
            Circle circle = new Circle { X = cX, Y = cY, Radius = Radius };

            if (CollisionCheck.RectangleCircleCollision(rectangle,circle))
            {
                MessageBox.Show("The rectangle and the circle collide.");
            }
            else
            {
                MessageBox.Show("The rectangle and the circle do not collide.");
            }
        }

        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownRectX.Value;
            int Y = (int)numericUpDownRectY.Value;
            int Height = (int)numericUpDownRectHeight.Value;
            int Width = (int)numericUpDownRectWidth.Value;

            int cX = (int)numericUpDownCircleX.Value;
            int cY = (int)numericUpDownCircleY.Value;
            int Radius = (int)numericUpDownCircleRad.Value;

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen1 = new Pen(System.Drawing.Color.Black, 2);
            Rectangle circle = new Rectangle(cX, cY, Radius, Radius);
            object1.DrawEllipse(pen1, circle);

            System.Drawing.Graphics object2;
            object2 = this.CreateGraphics();
            Pen pen2 = new Pen(System.Drawing.Color.Red, 3);
            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            object2.DrawRectangle(pen2, rectangle);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
