using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawThe3D
{
    class Point3D : Draw3D
    {
        public Point3D(xyz point) {
            Name = "point";
            pointList = new xyz[1];
            pointList[0] = point;
        }
        public Point3D(float x, float y, float z) {
            Name = "point";
            pointList = new xyz[1];
            pointList[0] = new xyz();
            pointList[0].x = x;
            pointList[0].y = y;
            pointList[0].z = z;
        }
    }
}