using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning6
{
    class Point3D
    {
        private int z;
        
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        
        public Point3D(int x, int y, int z)
        {
            Z = z;
        }
        
        public static implicit operator Point(Point3D point3D)
        {
            return new Point(5,8);
        }
    }
}
