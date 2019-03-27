using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace JogodoGalo
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {

            InitializeComponent();

            listBox1.DataSource = System.IO.File.ReadAllLines("jogo.txt");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void conesao()
        {
            string conectionstring = "Server = 127.0.0.1; Database = highscore; Uid = root; Pwd = ''; ";

            MySqlConnection dado = new MySqlConnection(conectionstring);

            dado.Open();

            MySqlCommand datas = new MySqlCommand();

            datas.Connection = dado;

            datas.CommandText = "SELECT * FROM jogadores WHERE filtros = 0";

            MySqlDataReader score = datas.ExecuteReader();

            while (score.Read())
            {
                listBox1.Items.Add(score["nomejoga"].ToString());
            }

            dado.Close();

        }
    }
}
