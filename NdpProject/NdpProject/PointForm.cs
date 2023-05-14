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
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
            buttonBack.Visible = false;

        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            groupBoxPoint.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownPointX.Value;
            int Y = (int)numericUpDownPointY.Value;

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Magenta, 2);
            Rectangle circle = new Rectangle(X, Y, 1, 1);
            object1.DrawEllipse(pen, circle);
        }

        private void radioButtonPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPoint.Checked)
            {
                MessageBox.Show("Thank you!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShapesForm form = new ShapesForm();
            form.Show();
            this.Close();
        }
    }
}
