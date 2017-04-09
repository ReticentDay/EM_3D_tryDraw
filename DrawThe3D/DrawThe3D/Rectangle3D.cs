using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawThe3D
{
    class Rectangle3D : Draw3D
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
                for (int i = 0; i < 4; i++) {
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
                for (int i = 0; i < 4; i++)
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
                for (int i = 0; i < 4; i++)
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
            }
        }
        public override float L
        {
            get
            {
                return 0;
            }
            set
            {
                
            }
        }

        public Rectangle3D(xyz r1, xyz r2,xyz r3,xyz r4)
        {
            pointList = new xyz[4];
            Name = "Rectangle";
            pointList[0] = r1;
            pointList[1] = r2;
            pointList[2] = r3;
            pointList[3] = r4;
        }
        public Rectangle3D(float onX, float onY, float onZ, float height,float weight) {
            pointList = new xyz[4];
            Name = "Rectangle";
            pointList[0] = new xyz();pointList[0].x = onX;pointList[0].y = onY;pointList[0].z = onZ;
            pointList[1] = new xyz(); pointList[1].x = onX + height;pointList[1].y = onY;pointList[1].z = onZ;
            pointList[2] = new xyz();pointList[2].x = onX + height;pointList[2].y = onY + weight;pointList[2].z = onZ;
            pointList[3] = new xyz();pointList[3].x = onX;pointList[3].y = onY + weight;pointList[3].z = onZ;
        }
        public void setRectangle(float onX, float onY, float onZ, float height, float weight) {
            pointList[0].x = onX; pointList[0].y = onY; pointList[0].z = onZ;
            pointList[1].x = onX + height; pointList[1].y = onY; pointList[1].z = onZ;
            pointList[2].x = onX + height; pointList[2].y = onY + weight; pointList[2].z = onZ;
            pointList[3].x = onX; pointList[3].y = onY + weight; pointList[3].z = onZ;
        }

        //印出
        public override void printIt(ref Graphics printP, Pen printPen, Brush printBrush)
        {
            Point[] xyList = new Point[4];
            xyz []newPointList = turnAround();
            count322(p, ref xyList, newPointList);
            printP.DrawPolygon(printPen, xyList);
        }

    }
}
