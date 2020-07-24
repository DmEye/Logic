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
        ANDUP,
        ORUP,
        EMPTY,
        NULL
    }
    public partial class MainForm : Form
    {
        static public Map map;
        private TypeTile chosen;
        static public List<Signal> signals;
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
            signals = new List<Signal>();
            
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
            if (andup_radio.Checked)
            {
                chosen = TypeTile.ANDUP;
            }
            if (signal_radio.Checked)
            {
                chosen = TypeTile.NULL;
                if (e.X <= 500 && e.Y <= 500 && e.X >= 0 && e.Y >= 0)
                {
                    signals.Add(new Signal(new Point(e.X / 5, e.Y / 5)));
                    this.Controls.Remove(map.GetPictureBox);
                    this.Controls.Add(signals[signals.Count - 1].pbox);
                    this.Controls.Add(map.GetPictureBox);
                    signal_timer.Enabled = true;
                    
                }
            }
            if (e.X <= 500 && e.Y <= 500 && e.X >= 0 && e.Y >= 0 && chosen != TypeTile.NULL)
            {
                map[e.X / 5, e.Y / 5].change(chosen);
                map[e.X / 5, e.Y / 5].draw();
            }
        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            map.clear();
        }

        private void signal_timer_Tick(object sender, EventArgs e)
        {
            if (signals.Count == 0)
            {
                signal_timer.Enabled = false;
            }
            else
            {
                for (int i = 0; i < signals.Count; i++)
                {
                    signals[i].move();
                }
            }
        }
    }
}
