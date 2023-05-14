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
    public partial class CollisionsForm : Form
    {
        public CollisionsForm()
        {
            InitializeComponent();
        }

        private void pointRectangleButton_Click(object sender, EventArgs e)
        {
            PointRectCollisionForm pointRectCollision = new PointRectCollisionForm();
            pointRectCollision.ShowDialog(this);
        }

        private void pointCircleButton_Click(object sender, EventArgs e)
        {
            PointCircleCollisionForm pointCircleCollision = new PointCircleCollisionForm();
            pointCircleCollision.ShowDialog(this);
        }
        private void pointCylinderButton_Click(object sender, EventArgs e)
        {
            PointCylinderCollisionForm pointCylinderCollision = new PointCylinderCollisionForm();
            pointCylinderCollision.ShowDialog(this);
        }
        private void pointSphereButton_Click(object sender, EventArgs e)
        {
            PointSphereCollisionForm pointSphereCollision = new PointSphereCollisionForm();
            pointSphereCollision.ShowDialog(this);
        }
        private void pointRectPrismButton_Click(object sender, EventArgs e)
        {
            PointRectPrsimCollisionForm pointRectPrsimCollision = new PointRectPrsimCollisionForm();
            pointRectPrsimCollision.ShowDialog(this);
        }
        private void rectangleRectangleButton_Click(object sender, EventArgs e)
        {
            RectCollisionForm rectangleCollision = new RectCollisionForm();
            rectangleCollision.ShowDialog(this);
        }

        private void rectangleCircleButton_Click(object sender, EventArgs e)
        {
            RectCircleForm rectangleCircleCollision = new RectCircleForm();
            rectangleCircleCollision.ShowDialog(this);
        }

        private void circleCircleButton_Click(object sender, EventArgs e)
        {
            CircleCollisionForm circleCircleCollision = new CircleCollisionForm();
            circleCircleCollision.ShowDialog(this);
        }
        private void cylinderCylinderButton_Click(object sender, EventArgs e)
        {
            CylinderCollisionForm cylinderCylinderCollision = new CylinderCollisionForm();
            cylinderCylinderCollision.ShowDialog(this);
        }

        private void sphereSphereButton_Click(object sender, EventArgs e)
        {
            SphereCollisionForm sphereSphereCollision = new SphereCollisionForm();
            sphereSphereCollision.ShowDialog(this);
        }

        private void sphereCylinderButton_Click(object sender, EventArgs e)
        {
            SphereCylinderCollisionForm sphereCylinderCollision = new SphereCylinderCollisionForm();
            sphereCylinderCollision.ShowDialog(this);
        }

        private void sphereRectPrismButton_Click(object sender, EventArgs e)
        {
            SphereRectPrismCollisionForm sphereRectPrismCollision = new SphereRectPrismCollisionForm();
            sphereRectPrismCollision.ShowDialog(this);
        }

        private void rectPrismRectPrismButton_Click(object sender, EventArgs e)
        {
            RectPrismCollisionForm rectPrismsCollision = new RectPrismCollisionForm();
            rectPrismsCollision.ShowDialog(this);
        }

        private void surfaceSphereButton_Click(object sender, EventArgs e)
        {
            SurfaceSphereCollisionForm surfaceSphereCollision = new SurfaceSphereCollisionForm();
            surfaceSphereCollision.ShowDialog(this);
        }

        private void surfaceRectPrismButton_Click(object sender, EventArgs e)
        {
            SurfaceRectPrismCollisionForm surfaceRectPrismCollision = new SurfaceRectPrismCollisionForm();
            surfaceRectPrismCollision.ShowDialog(this);
        }

        private void surfaceCylinderButton_Click(object sender, EventArgs e)
        {
            SurfaceCylinderCollisionForm surfaceCylinderCollisionForm = new SurfaceCylinderCollisionForm();
            surfaceCylinderCollisionForm.ShowDialog(this);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm();
            form.Show();
            this.Close();
        }
    }
}
