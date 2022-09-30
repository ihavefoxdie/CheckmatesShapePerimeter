using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkmates
{
    class Shape
    {
        private readonly Tile[] _tiles;
        private int _perimeter = 0;

        public int Perimeter
        {
            get { return _perimeter; }
        }

        public Shape(int size, params int[] list)
        {
            if (list.Length % 2 != 0)
                throw new Exception("The amount of arguments given must be even!");
            if (size > 64 && list.Length / 2 != size)
                throw new Exception("Incorrect size or/and parameters' amount!");
            //Sizer(ref size);


            _tiles = new Tile[size];
            for (int i = 0; i < _tiles.Length; i++)
            {
                _tiles[i] = new(list[i * 2], list[i * 2 + 1]);
            }
            SideCheck();
            FindPerimeter();
        }


/*        private static void Sizer(ref int size)
        {
            if (size < 0) { size = 1; return; }
            if (size > 64) { size = 64; return; }
        }*/


        private void SideCheck()
        {
            for(int i = 0; i < _tiles.Length - 1; i++)
                for (int j = i + 1; j < _tiles.Length; j++)
                {
                    if (i == j)
                        continue;
                    if ((Math.Abs(_tiles[i].Coords[0] - _tiles[j].Coords[0]) == 1 && (_tiles[i].Coords[1] - _tiles[j].Coords[1] == 0)) ||
                            (Math.Abs(_tiles[i].Coords[1] - _tiles[j].Coords[1]) == 1 && (_tiles[i].Coords[0] - _tiles[j].Coords[0] == 0)))
                    {
                        _tiles[i].Sides--;
                        _tiles[j].Sides--;
                    }    
                }
        }


        private void FindPerimeter()
        {
            for (int i = 0; i < _tiles.Length; i++)
            {
                _perimeter += _tiles[i].Sides;
            }
        }
    }
}
