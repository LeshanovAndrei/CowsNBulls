using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cowsNbulls_client
{
    public partial class resultsTable : Form
    {
        GameLogic g;
        public resultsTable(GameLogic g)
        {
            InitializeComponent();
            this.g = g;
            Shown += resultsTable_Shown;

        }

        private void resultsTable_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < g.NumOfPlayers; i++)
            {
                string reply = g.GetMsg();
                if (reply == "-1")
                {
                    MessageBox.Show("Connection error!");
                    g.ConnectionError();
                    Close();
                }
                string name = null;
                int j = 0;
                while (reply[j] != ' ')
                {
                    name += reply[j];
                    j++;
                }
                dataGridView1.Rows.Add(i+1, name, reply[reply.Length - 1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
