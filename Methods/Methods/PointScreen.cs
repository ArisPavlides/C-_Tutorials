using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class PointScreen
    {
        public int PointX;
        public int PointY;

        public PointScreen(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }

        public void Move(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }

        public void Move(PointScreen newLocation)
        {
            Move(newLocation.PointX, newLocation.PointY);
        }
    }
}
