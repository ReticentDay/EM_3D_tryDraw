using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawThe3D
{
    class Line3D : Draw3D
    {
        public Line3D(xyz on,xyz to) {
            pointList = new xyz[2];
            Name = "line";
            pointList[0] = on;
            pointList[1] = to; 
        }
        public override float H
        {
            get
            {
                return pointList[1].x;
            }
            set
            {
                this.pointList[1].x = value;
            }
        }
        public override float W
        {
            get
            {
                return pointList[1].y;
            }
            set
            {
                this.pointList[1].y = value;
            }
        }
        public override float L
        {
            get
            {
                return pointList[1].z;
            }
            set
            {
                this.pointList[1].z = value;
            }
        }
        public Line3D(float onX, float onY, float onZ, float toX, float toY, float toZ) {
            Name = "line";
            pointList = new xyz[2];
            pointList[0] = new xyz();
            pointList[0].x = onX;
            pointList[0].y = onY;
            pointList[0].z = onZ;
            pointList[1] = new xyz();
            pointList[1].x = toX;
            pointList[1].y = toY;
            pointList[1].z = toZ;
        }
        public void setLine(float onX, float onY, float onZ, float toX, float toY, float toZ) {
            pointList[0].x = onX;
            pointList[0].x = onY;
            pointList[0].x = onZ;
            pointList[1].x = toX;
            pointList[1].y = toY;
            pointList[1].z = toZ;
        }
        public override void printIt(ref Graphics printP, Pen printPen, Brush printBrush)
        {
            Point[] xyList = new Point[2];
            xyz[] newPointList = turnAround();
            count322(p, ref xyList, newPointList);
            printP.DrawLine(printPen,xyList[0],xyList[1]);
        }

    }
}
