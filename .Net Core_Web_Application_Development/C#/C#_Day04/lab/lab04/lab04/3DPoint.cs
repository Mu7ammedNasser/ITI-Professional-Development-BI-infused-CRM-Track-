using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class _3DPoint : IComparable , ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint() : this(0, 0, 0) { }

        public _3DPoint(int x, int y) : this(x, y, 0) { }

        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({this.X}, {this.Y}, {this.Z})";
        }

        public override bool Equals(object? obj)
        {
            _3DPoint point = obj as _3DPoint;
            return (this.X == point.X &&
                this.Y == point.Y &&
                this.Z == point.Z);
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return -1;
            var point = obj as _3DPoint;

            if (this.X > point.X) return 1;
            if (this.X < point.X) return -1;

            if (this.Y > point.Y) return 1;
            if (this.Y < point.Y) return -1;

            

            return 0;

        }

        public object Clone()
        {
            return new _3DPoint()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }
    }


}
