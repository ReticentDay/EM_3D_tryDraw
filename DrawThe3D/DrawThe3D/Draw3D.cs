using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawThe3D
{
    public class Draw3D
    {
        string name = "Draw";
        const int drawSizeHeight = 400;
        const int drawSizeWeight = 800;

        public class xyz {
            public float x;
            public float y;
            public float z;
        }
        public class turn {
            public float turnX;
            public float turnY;
            public float turnZ;
        }
        public string Name{
            set {
                this.name = value;
            }
            get {
                return this.name;
            }
        }
        public turn sing = new turn();
        public xyz[] pointList;
        public Draw3D(){
            sing.turnX = sing.turnY = sing.turnZ = 0;
        }
        public virtual float X
        {
            get
            {
                return pointList[0].x;
            }
            set
            {
                pointList[0].x = value;
            }
        }
        public virtual float Y
        {
            get
            {
                return pointList[0].y;
            }
            set
            {
                pointList[0].y = value;
            }
        }
        public virtual float Z
        {
            get
            {
                return pointList[0].z;
            }
            set
            {
                pointList[0].z = value;
            }
        }
        public virtual float H {
            get {
                return 0;
            }
            set {
            }
        }
        public virtual float W
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }
        public virtual float L
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }
        public float getTurnX() { return sing.turnX; }
        public float getTurnY() { return sing.turnY; }
        public float getTurnZ() { return sing.turnZ; }

        public void setTurnX(float turnX, float turnY, float turnZ) {
            sing.turnX = turnX;
            sing.turnY = turnY;
            sing.turnZ = turnZ;
        }

        //3D轉2D
        public void count322(float p,ref Point []xyList,xyz []pointList)
        {
            for (int i = 0; i < pointList.Length; i++) {
                xyList[i] = new Point();
                xyList[i].X = (int)(pointList[i].x * (-p) / (pointList[i].z - p));
                xyList[i].Y = (int)(pointList[i].y * (-p) / (pointList[i].z - p));
                xyList[i].X += drawSizeWeight / 2;
                xyList[i].Y = 200 - xyList[i].Y;
            }
        }
        public xyz[] reXYZList;
        //旋轉
        public xyz[] turnAround() {
            reXYZList = new xyz[pointList.Length];
            reXYZList[0] = pointList[0];
            turn sings = new turn();
            sings.turnX = sing.turnX * (float)3.1416 / 180;
            sings.turnY = sing.turnY * (float)3.1416 / 180;
            sings.turnZ = sing.turnZ * (float)3.1416 / 180;
            for (int i = 1; i < pointList.Length; i++)
            {
                //定義旋轉軸點
                float x = pointList[i].x - pointList[0].x;
                float y = pointList[i].y - pointList[0].y;
                float z = pointList[i].z - pointList[0].z;
                //旋轉Y軸
                float x1 = (float)(x * Math.Cos(sings.turnY) + z * Math.Sin(sings.turnY));
                float y1 = y;
                float z1 = (float)(-x * Math.Sin(sings.turnY) + z * Math.Cos(sings.turnY));
                //旋轉X軸
                float x2 = x1;
                float y2 = (float)(y1 * Math.Cos(sings.turnX) - z1 * Math.Sin(sings.turnX));
                float z2 = (float)(y1 * Math.Sin(sings.turnX) + z1 * Math.Cos(sings.turnX));
                //旋轉Z軸
                float x3 = (float)(x2 * Math.Cos(sings.turnZ) - y2 * Math.Sin(sings.turnZ));
                float y3 = (float)(x2 * Math.Sin(sings.turnZ) + y2 * Math.Cos(sings.turnZ));
                float z3 = z2;
                //點位往回推
                reXYZList[i] = new xyz();
                reXYZList[i].x = x3 + pointList[0].x;
                reXYZList[i].y = y3 + pointList[0].y;
                reXYZList[i].z = z3 + pointList[0].z;
            }
            return reXYZList;
        }

        public static float p;

        //印出，可複寫
        public virtual void printIt(ref Graphics printP, Pen printPen,Brush printBrush)
        {
            Point[] xyList = new Point[1];
            xyz[] newPointList = turnAround();
            count322(p, ref xyList, newPointList);
            printP.FillEllipse(printBrush, xyList[0].X - (float)0.5, xyList[0].Y - (float)0.5, 1, 1);
        }
    }
}
