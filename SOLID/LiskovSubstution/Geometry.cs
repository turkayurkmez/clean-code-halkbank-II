using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{

    public interface IArea
    {
        public int GetArea();
    }
    internal class Geometry
    {
        public IArea GetRectangle(int unit1, int? unit2 = null)
        {
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }
            return new Square() { EdgeLength=unit1};
        }
    }

  

    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;
    }

    public class Square : IArea //: Rectangle
    {
        //public override int Height { get => base.Height; set { base.Height = value; base.Width = value; } }
        //public override int Width { get => base.Height; set { base.Height = value; base.Width = value; } }

        public int EdgeLength { get; set; }

        public int GetArea() => EdgeLength * EdgeLength;

    }
}
