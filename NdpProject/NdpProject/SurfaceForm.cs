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
    public partial class SurfaceForm : Form
    {
        public SurfaceForm()
        {
            InitializeComponent();
            buttonBack.Visible = false;

        }

        private void surfaceButton_Click(object sender, EventArgs e)
        {
            groupBoxSurface.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Width = (int)numericUpDownWidth.Value;
            int Depth = (int)numericUpDownDepth.Value;

            System.Drawing.Graphics line1, line2, line3, line4;
           
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkBlue, 3);
            
            line1.DrawLine(pen, X, Y, X + Depth, Y + Depth);
            line2.DrawLine(pen, X + Width, Y, X + Width + Depth, Y + Depth);
            line3.DrawLine(pen, X, Y, X + Width, Y);
            line4.DrawLine(pen, X + Depth, Y+Depth, X + Depth + Width, Y+Depth);
          
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShapesForm form = new ShapesForm();
            form.Show();
            this.Close();
        }
    }
}
