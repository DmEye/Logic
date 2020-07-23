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
        public PictureBox GetPictureBox { get; }
        private Bitmap bmp;
        public TypeTile type;
        public Tile(PointB ind)
        {
            index = ind;
            type = TypeTile.EMPTY;
            GetPictureBox = new PictureBox();
            GetPictureBox.Location = new Point(index.X * 5, index.Y * 5);
            GetPictureBox.Size = new Size(5, 5);
            bmp = new Bitmap((int)TileSize, (int)TileSize);
        }
        public Tile(PointB ind, TypeTile t)
        {
            index = ind;
            type = t;
            GetPictureBox = new PictureBox();
            GetPictureBox.Location = new Point(index.X * 5, index.Y * 5);
            GetPictureBox.Size = new Size(5, 5);
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

                        break;
                    }
                case TypeTile.LEFT:
                    {

                        break;
                    }
                case TypeTile.RIGHT:
                    {

                        break;
                    }
                case TypeTile.AND:
                    {

                        break;
                    }
                case TypeTile.OR:
                    {

                        break;
                    }
                case TypeTile.EMPTY:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                bmp.SetPixel(i, j, Color.White);
                            }
                        }
                        break;
                    }
                default:
                    break;
            }
            GetPictureBox.Image = bmp;
        }
    }
}
