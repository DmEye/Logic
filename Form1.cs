using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public enum TypeTile
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        AND,
        OR,
        EMPTY
    }
    public partial class MainForm : Form
    {
        public Map map;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            map = new Map();
            init();
            map.redraw();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < map.GetSize; i++)
            {
                if (i % 2 != 0)
                {
                    map[i, 10].change(TypeTile.UP);
                    map.draw(map[i, 10].index);
                }
            }
        }
        private void init()
        {
            for (int i = 0; i < map.GetSize; i++)
            {
                for (int j = 0; j < map.GetSize; j++)
                {
                    this.Controls.Add(map[i, j].GetPictureBox);
                }
            }
        }
    }
}
