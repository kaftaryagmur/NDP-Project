using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpProject
{
    public static class CollisionCheck
    {
        public static bool PointRectangleCollision(Point point, Rectangles rectangle)
        {
            if (point.X >= rectangle.X && point.X <= rectangle.X + rectangle.Width &&
                point.Y >= rectangle.Y && point.Y <= rectangle.Y + rectangle.Height)
            {
                return true;
            }
            return false;
        }
        public static bool PointCircleCollision(Point point, Circle circle)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - circle.X, 2) + Math.Pow(point.Y - circle.Y, 2));
            if (distance <= circle.Radius)
            {
                return true;
            }
            return false;
        }
        public static bool RectangleCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            if (rectangle1.X < rectangle2.X + rectangle2.Width &&
                rectangle1.X + rectangle1.Width > rectangle2.X &&
                rectangle1.Y < rectangle2.Y + rectangle2.Height &&
                rectangle1.Y + rectangle1.Height > rectangle2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool RectangleCircleCollision(Rectangles rectangle, Circle circle)
        {

            double closestX = calculation(circle.X, rectangle.X, rectangle.Y + rectangle.Width);
            double closestY = calculation(circle.Y, rectangle.X, rectangle.Y + rectangle.Height);
            double distance = Math.Sqrt(Math.Pow(circle.X - closestX, 2) + Math.Pow(circle.Y - closestY, 2));

            return distance <= circle.Radius;
        }
        public static double calculation(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            else if (value > max)
            {
                return max;
            }
            else
            {
                return value;
            }
        }
        public static bool CircleCircleCollision(Circle circle1, Circle circle2)
        {
            double distance = Math.Sqrt(Math.Pow(circle1.X - circle2.X, 2) + Math.Pow(circle1.Y - circle2.Y, 2));
            double radiusSum = circle1.Radius + circle2.Radius;

            if (distance <= radiusSum)
            {
                return true;
            }
            return false;
        }
        public static bool PointPrismCollision(Point point, RectangularPrism prism)
        {
            float halfWidth = prism.Width / 2f;
            float halfHeight = prism.Height / 2f;
            float halfDepth = prism.Depth / 2f;

            float distanceX = Math.Abs(point.X - prism.X);
            float distanceY = Math.Abs(point.Y - prism.Y);

            if (distanceX > halfWidth || distanceY > halfHeight)
                return false;

            return true;
        }
        public static bool PrismPrismCollision(RectangularPrism prism1, RectangularPrism prism2)
        {
            int cx1 = prism1.X + prism1.Width / 2;
            int cy1 = prism1.Y + prism1.Height / 2;
            int cx2 = prism2.X + prism2.Width / 2;
            int cy2 = prism2.Y + prism2.Height / 2;

            int minX1 = prism1.X;
            int maxX1 = prism1.X + prism1.Width;
            int minY1 = prism1.Y;
            int maxY1 = prism1.Y + prism1.Height;

            int minX2 = prism2.X;
            int maxX2 = prism2.X + prism2.Width;
            int minY2 = prism2.Y;
            int maxY2 = prism2.Y + prism2.Height;

            if (Math.Abs(cx1 - cx2) > (prism1.Width + prism2.Width) / 2) return false;
            if (Math.Abs(cy1 - cy2) > (prism1.Height + prism2.Height) / 2) return false;

            else return true;
        }
        public static bool CylinderCylinderCollision(Cylinder cylinder1, Cylinder cylinder2)
        {
            int distanceX = cylinder1.X - cylinder2.X;
            int distanceY = cylinder1.Y - cylinder2.Y;

            int distanceSquared = distanceX * distanceX + distanceY * distanceY;
            int radiusSum = cylinder1.Radius + cylinder2.Radius;

            if (distanceSquared <= radiusSum * radiusSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PointCylinderCollision(Point point, Cylinder cylinder)
        {
            float distanceX = point.X - cylinder.X;
            float distanceY = point.Y - cylinder.Y;
            if (Math.Sqrt(distanceX * distanceX + distanceY * distanceY) <= cylinder.Radius)
            {
                return true;
            }
            return false;
        }
        public static bool PointSphereCollision(Point point, Sphere sphere)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - (sphere.X + sphere.Radius / 2), 2) + Math.Pow(point.Y - sphere.Y + (sphere.Radius / 2), 2));
            if (distance <= sphere.Radius)
            {
                return true;
            }
            return false;
        }
        public static bool SphereSphereCollision(Sphere sphere1, Sphere sphere2)
        {
            double distance = Math.Sqrt(Math.Pow(sphere1.X - sphere2.X, 2) + Math.Pow(sphere1.Y - sphere2.Y, 2));
            double radiusSum = sphere1.Radius + sphere2.Radius;
            if (distance <= radiusSum)
            {
                return true;
            }
            return false;
        }
        public static bool SphereCylinderCollision(Sphere sphere, Cylinder cylinder)
        {
            int distanceX = Math.Max(cylinder.X - sphere.X - cylinder.Height / 2, 0);
            distanceX = Math.Min(distanceX, cylinder.Height);
            int distanceY = Math.Max(cylinder.Y - sphere.Y - cylinder.Height / 2, 0);
            distanceY = Math.Min(distanceY, cylinder.Height);

            int distanceSq = distanceX * distanceX + distanceY * distanceY;

            if (distanceSq <= sphere.Radius * sphere.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpherePrismCollision(Sphere sphere, RectangularPrism prism)
        {
            int distanceX = Math.Max(prism.X - sphere.X - prism.Width / 2, 0);
            distanceX = Math.Min(distanceX, prism.Width / 2);
            int distanceY = Math.Max(prism.Y - sphere.Y - prism.Height / 2, 0);
            distanceY = Math.Min(distanceY, prism.Height / 2);

            int distanceSquared = distanceX * distanceX + distanceY * distanceY;

            if (distanceSquared <= sphere.Radius * sphere.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SurfaceCylinderCollision(Surface surface, Cylinder cylinder)
        {
            int closestX = Math.Max(surface.X - cylinder.X - surface.Width / 2, 0);
            closestX = Math.Min(closestX, surface.Width);
            int closestY = Math.Max(surface.Y - cylinder.Y - surface.Depth / 2, 0);
            closestY = Math.Min(closestY, surface.Depth);

            int distanceSquared = closestX * closestX + closestY * closestY;

            if (distanceSquared <= cylinder.Radius * cylinder.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SurfacePrismCollision(Surface surface, RectangularPrism prism)
        {
            int rectangleRight = surface.X + surface.Width;
            int rectangleBottom = surface.Y + surface.Depth;

            int prismRight = prism.X + prism.Width;
            int prismBottom = prism.Y + prism.Height;

            if (surface.X > prismRight || rectangleRight < prism.X ||
                surface.Y > prismBottom || rectangleBottom < prism.Y)
            {
                return false;
            }
            if (prism.Y > surface.Y || prism.X > surface.X)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool SurfaceSphereCollision(Surface surface, Sphere sphere)
        {
            int closestX = Math.Max(surface.X - sphere.X - surface.Width / 2, 0);
            closestX = Math.Min(closestX, surface.Width);
            int closestY = Math.Max(surface.Y - sphere.Y - surface.Depth / 2, 0);
            closestY = Math.Min(closestY, surface.Depth);
           
            if (sphere.Y+sphere.Radius > surface.Y || sphere.X+sphere.Radius > surface.X)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
