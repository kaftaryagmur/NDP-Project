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
    public partial class SphereForm : Form
    {
        public SphereForm()
        {
            InitializeComponent();
            buttonBack.Visible = false;

        }

        private void sphereButton_Click(object sender, EventArgs e)
        {
            groupBoxSphere.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Radius = (int)numericUpDownRad.Value;

            System.Drawing.Graphics object1, object2;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Chocolate, 5);
            Pen pen2 = new Pen(System.Drawing.Color.Bisque, 5);

            Rectangle circle = new Rectangle(X, Y, Radius, Radius);
            object1.DrawEllipse(pen, circle);
            object2.DrawArc(pen2, X, Y + Radius / 3, Radius, Radius / 4, 180, 360);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShapesForm form = new ShapesForm();
            form.Show();
            this.Close();
        }
    }
}
