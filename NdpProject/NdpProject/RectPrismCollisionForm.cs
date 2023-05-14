using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NdpProject
{
    public partial class RectPrismCollisionForm : Form
    {
        public RectPrismCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownRectPrismX.Value;
            int Y = (int)numericUpDownRectPrismY.Value;
            int Height = (int)numericUpDownRectPrismHeight.Value;
            int Width = (int)numericUpDownRectPrismWidth.Value;
            int Depth = (int)numericUpDownRectPrismDepth.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Height2 = (int)numericUpDownH2.Value;
            int Width2 = (int)numericUpDownW2.Value;
            int Depth2 = (int)numericUpDownD2.Value;

            RectangularPrism prism1 = new RectangularPrism { X = X, Y = Y, Height = Height, Width = Width, Depth = Depth };
            RectangularPrism prism2 = new RectangularPrism { X = X2, Y = Y2, Height = Height2, Width = Width2, Depth = Depth2 };

            if (CollisionCheck.PrismPrismCollision(prism1, prism2))
            {
                MessageBox.Show("Two prisms collide.");
            }
            else
            {
                MessageBox.Show("Two prisms do not collide.");
            }

        }
        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownRectPrismX.Value;
            int Y = (int)numericUpDownRectPrismY.Value;
            int Height = (int)numericUpDownRectPrismHeight.Value;
            int Width = (int)numericUpDownRectPrismWidth.Value;
            int Depth = (int)numericUpDownRectPrismDepth.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Height2 = (int)numericUpDownH2.Value;
            int Width2 = (int)numericUpDownW2.Value;
            int Depth2 = (int)numericUpDownD2.Value;

            System.Drawing.Graphics object1, object2, line1, line2, line3, line4;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            Rectangle rectangle2 = new Rectangle(X + Depth, Y + Depth, Width, Height);
            object1.DrawRectangle(pen, rectangle);
            object2.DrawRectangle(pen, rectangle2);
            line1.DrawLine(pen, X, Y, X + Depth, Y + Depth);
            line2.DrawLine(pen, X + Width, Y, X + Width + Depth, Y + Depth);
            line3.DrawLine(pen, X, Y + Height, X + Depth, Y + Height + Depth);
            line4.DrawLine(pen, X + Width, Y + Height, X + Width + Depth, Y + Height + Depth);

            System.Drawing.Graphics object3, object4, line5, line6, line7, line8;
            object3 = this.CreateGraphics();
            object4 = this.CreateGraphics();
            line5 = this.CreateGraphics();
            line6 = this.CreateGraphics();
            line7 = this.CreateGraphics();
            line8 = this.CreateGraphics();
            Pen pen2 = new Pen(Color.Black, 3);
            Rectangle rectangle3 = new Rectangle(X2, Y2, Width2, Height2);
            Rectangle rectangle4 = new Rectangle(X2 + Depth2, Y2 + Depth2, Width2, Height2);
            object1.DrawRectangle(pen2, rectangle3);
            object2.DrawRectangle(pen2, rectangle4);
            line1.DrawLine(pen2, X2, Y2, X2 + Depth2, Y2 + Depth2);
            line2.DrawLine(pen2, X2 + Width2, Y2, X2 + Width2 + Depth2, Y2 + Depth2);
            line3.DrawLine(pen2, X2, Y2 + Height2, X2 + Depth2, Y2 + Height2 + Depth2);
            line4.DrawLine(pen2, X2 + Width2, Y2 + Height2, X2 + Width2 + Depth2, Y2 + Height2 + Depth2);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
