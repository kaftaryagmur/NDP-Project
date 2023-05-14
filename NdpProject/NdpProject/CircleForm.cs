using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NdpProject
{
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
            buttonBack.Visible = false;
        }

        public void circleButton_Click(object sender, EventArgs e)
        {
            groupBoxCircle.Visible = false;
            buttonBack.Visible = true;
            void panel1_Paint()
            {
                int X = (int)numericUpDownCircleX.Value;
                int Y = (int)numericUpDownCircleY.Value;
                int Radius = (int)numericUpDownCircleRad.Value;

                Graphics graphics = panel1.CreateGraphics();
                Pen pen = new Pen(Color.BlueViolet, 5);
                Rectangle circle = new Rectangle(X, Y, Radius, Radius);
                graphics.DrawEllipse(pen, circle);
            }
            panel1_Paint();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShapesForm form = new ShapesForm();
            form.Show(); 
            this.Close(); 
        }
    }
}
