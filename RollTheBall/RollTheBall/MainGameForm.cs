using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RollTheBall
{
    public partial class MainGameForm : Form
    {
        
        public MainGameForm()
        {
            InitializeComponent();
            Game.BuildLevel(Playground);
            Game.Gameloop = new Thread(() => Game.Update(Playground,Moves_counter_label));
            Game.Gameloop.Start();
            Target_counter_label.Text = Game.Active_level.BestMoves.ToString();
        }
        private void Undo_Click(object sender, EventArgs e)
        {
            Game.Undo(Moves_counter_label);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Playground.Controls.Clear();
            Moves_counter_label.Text = "0";
            Game.Reset();
            Game.BuildLevel(Playground);
        }

        private void MainGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void MainGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
