using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace JogodoGalo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Galo = new Form1();

            Galo.MdiParent = this;

            Galo.Show();



        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void fecharJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void scoreBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Scoreboard pontos = new Scoreboard();

            pontos.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
