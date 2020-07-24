using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Signal
    {
        public Color color;
        public Point position;
        public readonly byte size = 5;

        public PictureBox pbox;
        private Bitmap bmp;
        public Signal(Point pos)
        {
            position = pos;
            color = Color.Red;

            pbox = new PictureBox();
            pbox.Location = new Point(position.X * size, position.Y * size);
            pbox.Size = new Size(size, size);
            bmp = new Bitmap(size, size);
            draw();
            pbox.Image = bmp;
        }
        public Signal(Point pos, Color c)
        {
            position = pos;
            color = c;

            pbox = new PictureBox();
            pbox.Location = new Point(position.X * size, position.Y * size);
            pbox.Size = new Size(size, size);
            bmp = new Bitmap(size, size);
            draw();
            pbox.Image = bmp;
        }
        public void move()
        {
            switch (MainForm.map[position.X, position.Y].type)
            {
                case TypeTile.UP:
                    {
                        position.Y -= 1;
                        pbox.Location = new Point(position.X * size, position.Y * size);
                        break;
                    }
                case TypeTile.DOWN:
                    {
                        position.Y += 1;
                        pbox.Location = new Point(position.X * size, position.Y * size);
                        break;
                    }
                case TypeTile.LEFT:
                    {
                        position.X -= 1;
                        pbox.Location = new Point(position.X * size, position.Y * size);
                        break;
                    }
                case TypeTile.RIGHT:
                    {
                        position.X += 1;
                        pbox.Location = new Point(position.X * size, position.Y * size);
                        break;
                    }
                case TypeTile.ANDUP:
                    {
                        int count = 0;
                        foreach (Signal signal in MainForm.signals)
                        {
                            if (signal.position == this.position)
                            {
                                count += 1;
                            }
                        }
                        if (count >= 2)
                        {
                            position.Y -= 1;
                            pbox.Location = new Point(position.X * size, position.Y * size);
                        }
                        break;
                    }
                case TypeTile.ORUP:
                    break;
                case TypeTile.EMPTY:
                    {
                        MainForm.signals.Remove(this);
                        pbox.Dispose();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        break;
                    }
                default:
                    break;
            }
        }
        private void draw()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bmp.SetPixel(i, j, color);
                }
            }
        }
    }
}
