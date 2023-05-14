using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NdpProject
{
    public partial class ShapesForm : Form
    {
        public ShapesForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (shapesComboBox.Text == "Circle")
            {
                CircleForm circle = new CircleForm();
                circle.ShowDialog();
            }
            if (shapesComboBox.Text == "Cylinder")
            {
                CylinderForm cylinder = new CylinderForm();
                cylinder.ShowDialog();
            }
            if (shapesComboBox.Text == "Point")
            {
                PointForm point = new PointForm();
                point.ShowDialog();
            }
            if (shapesComboBox.Text == "Rectangle")
            {
                RectangleForm rectangle = new RectangleForm();
                rectangle.ShowDialog();
            }
            if (shapesComboBox.Text == "Rectangular Prism")
            {
                RectPrismForm recPrism = new RectPrismForm();
                recPrism.ShowDialog();
            }
            if (shapesComboBox.Text == "Sphere")
            {
                SphereForm sphere = new SphereForm();
                sphere.ShowDialog();
            }
            if (shapesComboBox.Text == "Surface")
            {
                SurfaceForm surface = new SurfaceForm();
                surface.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm();
            form.Show();
            this.Close();
        }
    }
}