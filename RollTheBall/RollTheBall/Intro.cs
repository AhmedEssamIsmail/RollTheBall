using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollTheBall
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (LevelSelector.Text != "Select Level")
            {
                Game.CurrentLvl = Convert.ToInt32(LevelSelector.Text.ToString());
                MainGameForm MainApp = new MainGameForm();
                MainApp.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Select A Level First.");
            }
        }
        private void Intro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
