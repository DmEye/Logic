using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Map
    {
        public byte GetSize { get; } = 50;
        public Tile[,] tiles;
        public Tile this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < GetSize && j >= 0 && j < GetSize)
                {
                    return tiles[i, j];
                }
                else
                {
                    throw new IndexOutOfRangeException("Недопустимое значение индекса");
                }
            }
        }
        public Map()
        {
            tiles = new Tile[GetSize, GetSize];
            init();
        }
        private void init()
        {
            for (byte i = 0; i < GetSize; i++)
            {
                for (byte j = 0; j < GetSize; j++)
                {
                    tiles[i, j] = new Tile(new PointB(i, j));
                }
            }
        }
        public void draw(PointB index)
        {
            tiles[index.X, index.Y].draw();
        }
        public void change(PointB index, TypeTile t)
        {
            tiles[index.X, index.Y].change(t);
        }
        public void redraw()
        {
            for (int i = 0; i < GetSize; i++)
            {
                for (int j = 0; j < GetSize; j++)
                {
                    tiles[i, j].draw();
                }
            }
        }
        public void clear()
        {
            init();
        }
    }
}
