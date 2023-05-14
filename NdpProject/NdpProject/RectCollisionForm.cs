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
    public partial class RectCollisionForm : Form
    {
        public RectCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)rectX1NumericUpDown.Value;
            int Y1 = (int)rectY1NumericUpDown.Value;
            int Height1 = (int)rectH1NumericUpDown.Value;
            int Width1 = (int)rectW1NumericUpDown.Value;

            int X2 = (int)rectX2NumericUpDown.Value;
            int Y2 = (int)rectY2NumericUpDown.Value;
            int Height2 = (int)rectH2NumericUpDown.Value;
            int Width2 = (int)rectW2NumericUpDown.Value;

            Rectangles rectangle1 = new Rectangles { X = X1, Y = Y1, Height = Height1, Width = Width1 };
            Rectangles rectangle2 = new Rectangles { X = X2, Y = Y2, Height = Height2, Width = Width2 };

            if (CollisionCheck.RectangleCollision(rectangle1, rectangle2))
            {
                MessageBox.Show("Two rectangles collide.");
            }
            else
            {
                MessageBox.Show("Two rectangles do not collide.");
            }
        }

        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)rectX1NumericUpDown.Value;
            int Y1 = (int)rectY1NumericUpDown.Value;
            int Height1 = (int)rectH1NumericUpDown.Value;
            int Width1 = (int)rectW1NumericUpDown.Value;

            int X2 = (int)rectX2NumericUpDown.Value;
            int Y2 = (int)rectY2NumericUpDown.Value;
            int Height2 = (int)rectH2NumericUpDown.Value;
            int Width2 = (int)rectW2NumericUpDown.Value;

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen1 = new Pen(System.Drawing.Color.Silver, 3);
            Rectangle rectangle1 = new Rectangle(X1, Y1, Width1, Height1);
            object1.DrawRectangle(pen1, rectangle1);

            System.Drawing.Graphics object2;
            object2 = this.CreateGraphics();
            Pen pen2 = new Pen(System.Drawing.Color.DarkGreen, 3);
            Rectangle rectangle2 = new Rectangle(X2, Y2, Width2, Height2);
            object2.DrawRectangle(pen2, rectangle2);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
