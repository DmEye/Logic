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
        static public Map map;
        private TypeTile chosen;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chosen = TypeTile.UP;
            map = new Map();
            map.GetPictureBox.MouseClick += GetPictureBox_MouseClick;
            this.Controls.Add(map.GetPictureBox);
            map.update();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            /*map[0, 0].change(TypeTile.DOWN);
            map[0, 0].draw();*/
            /*map[0, 0].change(TypeTile.DOWN);*/
        }
        private void GetPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (up_radio.Checked)
            {
                chosen = TypeTile.UP;
            }
            if (down_radio.Checked)
            {
                chosen = TypeTile.DOWN;
            }
            if (left_radio.Checked)
            {
                chosen = TypeTile.LEFT;
            }
            if (right_radio.Checked)
            {
                chosen = TypeTile.RIGHT;
            }
            if (empty_radio.Checked)
            {
                chosen = TypeTile.EMPTY;
            }
            if (e.X <= 500 && e.Y <= 500 && e.X >= 0 && e.Y >= 0)
            {
                map[e.X / 5, e.Y / 5].change(chosen);
                map[e.X / 5, e.Y / 5].draw();
            }
        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            map.clear();
        }
    }
}
