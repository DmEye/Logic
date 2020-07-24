using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Tile
    {
        public byte TileSize { get; } = 5;
        public PointB index { get; }
        private Bitmap bmp;
        public TypeTile type;
        public Tile(PointB ind)
        {
            index = ind;
            type = TypeTile.EMPTY;
            bmp = new Bitmap((int)TileSize, (int)TileSize);
        }
        public Tile(PointB ind, TypeTile t)
        {
            index = ind;
            type = t;
            bmp = new Bitmap((int)TileSize, (int)TileSize);
        }
        public void change(TypeTile t)
        {
            type = t;
        }
        public void draw()
        {
            switch (type)
            {
                case TypeTile.UP:
                    {
                        clear();
                        bmp.SetPixel(2, 0, Color.Black);
                        bmp.SetPixel(2, 1, Color.Black);
                        bmp.SetPixel(2, 2, Color.Black);
                        bmp.SetPixel(2, 3, Color.Black);
                        bmp.SetPixel(2, 4, Color.Black);
                        bmp.SetPixel(1, 1, Color.Black);
                        bmp.SetPixel(0, 2, Color.Black);
                        bmp.SetPixel(3, 1, Color.Black);
                        bmp.SetPixel(4, 2, Color.Black);
                        break;
                    }
                case TypeTile.DOWN:
                    {
                        clear();
                        bmp.SetPixel(2, 0, Color.Black);
                        bmp.SetPixel(2, 1, Color.Black);
                        bmp.SetPixel(2, 2, Color.Black);
                        bmp.SetPixel(2, 3, Color.Black);
                        bmp.SetPixel(2, 4, Color.Black);
                        bmp.SetPixel(1, 3, Color.Black);
                        bmp.SetPixel(0, 2, Color.Black);
                        bmp.SetPixel(3, 3, Color.Black);
                        bmp.SetPixel(4, 2, Color.Black);
                        break;
                    }
                case TypeTile.LEFT:
                    {
                        clear();
                        bmp.SetPixel(4, 2, Color.Black);
                        bmp.SetPixel(3, 2, Color.Black);
                        bmp.SetPixel(2, 2, Color.Black);
                        bmp.SetPixel(1, 2, Color.Black);
                        bmp.SetPixel(0, 2, Color.Black);
                        bmp.SetPixel(1, 1, Color.Black);
                        bmp.SetPixel(2, 0, Color.Black);
                        bmp.SetPixel(1, 3, Color.Black);
                        bmp.SetPixel(2, 4, Color.Black);
                        break;
                    }
                case TypeTile.RIGHT:
                    {
                        clear();
                        bmp.SetPixel(4, 2, Color.Black);
                        bmp.SetPixel(3, 2, Color.Black);
                        bmp.SetPixel(2, 2, Color.Black);
                        bmp.SetPixel(1, 2, Color.Black);
                        bmp.SetPixel(0, 2, Color.Black);
                        bmp.SetPixel(3, 1, Color.Black);
                        bmp.SetPixel(2, 0, Color.Black);
                        bmp.SetPixel(3, 3, Color.Black);
                        bmp.SetPixel(2, 4, Color.Black);
                        break;
                    }
                case TypeTile.ANDUP:
                    {
                        clear();
                        bmp.SetPixel(4, 2, Color.Blue);
                        bmp.SetPixel(3, 2, Color.Blue);
                        bmp.SetPixel(2, 2, Color.Blue);
                        bmp.SetPixel(1, 2, Color.Blue);
                        bmp.SetPixel(0, 2, Color.Blue);
                        bmp.SetPixel(3, 1, Color.Blue);
                        bmp.SetPixel(3, 3, Color.Blue);
                        bmp.SetPixel(1, 1, Color.Blue);
                        bmp.SetPixel(1, 3, Color.Blue);
                        break;
                    }
                case TypeTile.ORUP:
                    {

                        break;
                    }
                case TypeTile.EMPTY:
                    {
                        clear();
                        break;
                    }
                default:
                    break;
            }
            for (int i = (int)index.X * (int)TileSize; i < (int)index.X * (int)TileSize +  5; i++)
            {
                for (int j = (int)index.Y * (int)TileSize; j < (int)index.Y * (int)TileSize + 5; j++)
                {
                    MainForm.map.bmp.SetPixel(i, j, bmp.GetPixel(i - (int)index.X * (int)TileSize, j - (int)index.Y * (int)TileSize));
                }
            }
            MainForm.map.GetPictureBox.Image = MainForm.map.bmp;
        }
        public void clear()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bmp.SetPixel(i, j, Color.White);
                }
            }
        }
    }
}
