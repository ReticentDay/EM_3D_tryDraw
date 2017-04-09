using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawThe3D
{
    class Box3D : Draw3D
    {
        public override float X
        {
            get
            {
                return pointList[0].x;
            }
            set
            {
                float move = value - pointList[0].x;
                for (int i = 0; i < 8; i++)
                {
                    pointList[i].x += move;
                }
            }
        }
        public override float Y
        {
            get
            {
                return pointList[0].y;
            }
            set
            {
                float move = value - pointList[0].y;
                for (int i = 0; i < 8; i++)
                {
                    pointList[i].y += move;
                }
            }
        }
        public override float Z
        {
            get
            {
                return pointList[0].z;
            }
            set
            {
                float move = value - pointList[0].z;
                for (int i = 0; i < 8; i++)
                {
                    pointList[i].z += move;
                }
            }
        }
        public override float H
        {
            get
            {
                return pointList[1].x - pointList[0].x;
            }
            set
            {
                this.pointList[1].x = pointList[0].x + value;
                this.pointList[2].x = pointList[0].x + value;
                this.pointList[5].x = pointList[0].x + value;
                this.pointList[6].x = pointList[0].x + value;
            }
        }
        public override float W
        {
            get
            {
                return pointList[3].y - pointList[0].y;
            }
            set
            {
                this.pointList[3].y = pointList[0].y + value;
                this.pointList[2].y = pointList[0].y + value;
                this.pointList[7].y = pointList[0].y + value;
                this.pointList[6].y = pointList[0].y + value;
            }
        }
        public override float L
        {
            get
            {
                return pointList[4].z - pointList[0].z;
            }
            set
            {
                this.pointList[4].z = pointList[0].z + value;
                this.pointList[5].z = pointList[0].z + value;
                this.pointList[6].z = pointList[0].z + value;
                this.pointList[7].z = pointList[0].z + value;
            }
        }
        public Box3D(float onX, float onY, float onZ, float height, float weight,float lon)
        {
            pointList = new xyz[8];
            Name = "Box";
            pointList[0] = new xyz(); pointList[0].x = onX; pointList[0].y = onY; pointList[0].z = onZ;
            pointList[1] = new xyz(); pointList[1].x = onX + height; pointList[1].y = onY; pointList[1].z = onZ;
            pointList[2] = new xyz(); pointList[2].x = onX + height; pointList[2].y = onY + weight; pointList[2].z = onZ;
            pointList[3] = new xyz(); pointList[3].x = onX; pointList[3].y = onY + weight; pointList[3].z = onZ;
            pointList[4] = new xyz(); pointList[4].x = onX; pointList[4].y = onY; pointList[4].z = onZ + lon;
            pointList[5] = new xyz(); pointList[5].x = onX + height; pointList[5].y = onY; pointList[5].z = onZ + lon;
            pointList[6] = new xyz(); pointList[6].x = onX + height; pointList[6].y = onY + weight; pointList[6].z = onZ + lon;
            pointList[7] = new xyz(); pointList[7].x = onX; pointList[7].y = onY + weight; pointList[7].z = onZ + lon;
        }
        public void setBox(float onX, float onY, float onZ, float height, float weight, float lon)
        {
            pointList[0].x = onX; pointList[0].y = onY; pointList[0].z = onZ;
            pointList[1].x = onX + height; pointList[1].y = onY; pointList[1].z = onZ;
            pointList[2].x = onX + height; pointList[2].y = onY + weight; pointList[2].z = onZ;
            pointList[3].x = onX; pointList[3].y = onY + weight; pointList[3].z = onZ;
            pointList[4].x = onX; pointList[4].y = onY; pointList[4].z = onZ + lon;
            pointList[5].x = onX + height; pointList[5].y = onY; pointList[5].z = onZ + lon;
            pointList[6].x = onX + height; pointList[6].y = onY + weight; pointList[6].z = onZ + lon;
            pointList[7].x = onX; pointList[7].y = onY + weight; pointList[7].z = onZ + lon;
        }

        //印出
        public override void printIt(ref Graphics printP, Pen printPen, Brush printBrush)
        {
            Point[] xyList = new Point[8];
            xyz[] newPointList = turnAround();
            count322(p, ref xyList, newPointList);
            printP.DrawLine(printPen, xyList[0], xyList[1]);
            printP.DrawLine(printPen, xyList[1], xyList[2]);
            printP.DrawLine(printPen, xyList[2], xyList[3]);
            printP.DrawLine(printPen, xyList[3], xyList[0]);
            printP.DrawLine(printPen, xyList[4], xyList[5]);
            printP.DrawLine(printPen, xyList[5], xyList[6]);
            printP.DrawLine(printPen, xyList[6], xyList[7]);
            printP.DrawLine(printPen, xyList[7], xyList[4]);
            printP.DrawLine(printPen, xyList[0], xyList[4]);
            printP.DrawLine(printPen, xyList[1], xyList[5]);
            printP.DrawLine(printPen, xyList[2], xyList[6]);
            printP.DrawLine(printPen, xyList[3], xyList[7]);
        }
    }
}
