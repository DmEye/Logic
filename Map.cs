using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Map
    {
        public Bitmap bmp;
        public PictureBox GetPictureBox { get; }
        public byte GetSize { get; } = 100;
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
            GetPictureBox = new PictureBox();
            GetPictureBox.Size = new Size(GetSize*5, GetSize * 5);
            GetPictureBox.Location = new Point();
            bmp = new Bitmap(GetSize * 5, GetSize * 5);
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
        public void update()
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
            for (int i = 0; i < GetSize; i++)
            {
                for (int j = 0; j < GetSize; j++)
                {
                    tiles[i, j].type = TypeTile.EMPTY;
                }
            }
            update();
        }
    }
}
