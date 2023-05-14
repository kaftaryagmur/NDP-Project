using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NdpProject
{
    public partial class CylinderForm : Form
    {
        public CylinderForm()
        {
            InitializeComponent();
            buttonBack.Visible = false;

        }
        private void cylinderButton_Click(object sender, EventArgs e)
        {
            groupBoxCylinder.Visible = false;
            buttonBack.Visible = true;
            if (!radioButtonHeight.Checked && !radioButtonWidth.Checked)
            {
                MessageBox.Show("Please select one of the options!");
            }
            if (radioButtonHeight.Checked)
            {

                int X1 = (int)numericUpDownX.Value;
                int Y1 = (int)numericUpDownY.Value;
                int Rad1 = (int)numericUpDownRad.Value;
                int Height = (int)numericUpDownHeight.Value;

                Graphics object1, object2, line1, line2;
                object1 = this.CreateGraphics();
                object2 = this.CreateGraphics();
                line1 = this.CreateGraphics();
                line2 = this.CreateGraphics();

                Pen pen = new Pen(System.Drawing.Color.BlueViolet, 5);
                Pen pen2 = new Pen(System.Drawing.Color.Pink, 5);

                Rectangle circle1 = new Rectangle(X1, Y1, Rad1, Rad1 / 2);
                Rectangle circle2 = new Rectangle(X1, Y1 + Height, Rad1, Rad1 / 2);

                object1.DrawEllipse(pen, circle1);
                object2.DrawEllipse(pen, circle2);
                line1.DrawLine(pen2, X1, Y1 + Rad1 / 4, X1, Y1 + Rad1 / 4 + Height);
                line2.DrawLine(pen2, X1 + Rad1, Y1 + Rad1 / 4, X1 + Rad1, Y1 + Height + Rad1 / 4);

            }
            if (radioButtonWidth.Checked)
            {

                int X1 = (int)numericUpDownX.Value;
                int Y1 = (int)numericUpDownY.Value;
                int Rad1 = (int)numericUpDownRad.Value;
                int Width = (int)numericUpDownWidth.Value;

                Graphics object1, object2, line1, line2;
                object1 = this.CreateGraphics();
                object2 = this.CreateGraphics();
                line1 = this.CreateGraphics();
                line2 = this.CreateGraphics();

                Pen pen = new Pen(System.Drawing.Color.BlueViolet, 5);
                Pen pen2 = new Pen(System.Drawing.Color.Pink, 5);

                Rectangle circle1 = new Rectangle(X1, Y1, Rad1, Rad1 / 2);
                Rectangle circle2 = new Rectangle(X1 + Width, Y1 + Width, Rad1, Rad1 / 2);

                object1.DrawEllipse(pen, circle1);
                object2.DrawEllipse(pen, circle2);
                line1.DrawLine(pen2, X1, Y1 + Rad1 / 4, X1 + Width, Y1 + Width + Rad1 / 4);
                line2.DrawLine(pen2, X1 + Rad1, Y1 + Rad1 / 4, X1 + Rad1 + Width, Y1 + Width + Rad1 / 4);

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
