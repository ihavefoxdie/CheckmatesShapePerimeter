using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkmates
{
    class Tile
    {
        private int _sides;
        private int[] _coords = new int[2];

        public int Sides
        {
            get { return _sides; }
            set { _sides = value; }
        }

        public int[] Coords
        {
            get { return _coords; }
            set { _coords = value; }
        }

        public Tile(int x, int y)
        {
            _coords[0] = x;
            _coords[1] = y;
            _sides = 4;
        }
    }
}