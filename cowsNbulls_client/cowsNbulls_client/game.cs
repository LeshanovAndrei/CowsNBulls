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
    public partial class game : Form
    {
        GameLogic g { get; set; }
        List<string> names;


        public game(GameLogic g)
        {
            InitializeComponent();
            this.g = g;
            g.NumOfPlayers = Convert.ToInt32(g.GetMsg());
            g.NumOfPlayers = g.NumOfRounds;
            names = new List<string>();
            for (int i = 0; i < g.NumOfPlayers; i++)
            {
                names.Add(g.GetMsg());
                if (names[i] == g.Name)
                {
                    g.MyNum = i;
                }
            }
            if (g.GetMsg() == "1")
            {
                g.Comp = true;
            }
            else
            {
                g.Comp = false;
            }
            Shown += game_Shown;
        }

        private void game_Load(object sender, EventArgs e)
        {
            
        }

        //private void SendAnswer()
        //{
        //    sendButton.Enabled = true;
        //}

        private void sendButton_Click(object sender, EventArgs e)
        {
            //if (answerBox.Text == "")
            //{
            //    MessageBox.Show("Error! Empty answer.");
            //    return;
            //}
            //if (answerBox.Text.Length != 4)
            //{
            //    MessageBox.Show("Error! Wrong answer format.");
            //}
            //g.SendMsg(answerBox.Text);
            //sendButton.Enabled = false;
        }

        private void game_Shown(object sender, EventArgs e)
        {
            
            for (int i = 0; i < g.NumOfRounds; i++)
            {
                if (!g.Comp)
                {
                    int numb = Convert.ToInt32(g.GetMsg());
                    if (numb == g.MyNum)
                    {
                        SendAnswer();
                    }
                }
                while (!g.Victory)
                {
                    for (int j = 0; j < g.NumOfPlayers; j++)
                    {
                        if (!g.Comp && i == j)
                        {
                            continue;
                        }
                        //Получить номер отвечающего
                        string tmpReply = g.GetMsg();
                        if (tmpReply == "V")
                        {
                            g.Victory = true;
                            break;
                        }
                        int numb = Convert.ToInt32(tmpReply);//Номер отвечающего
                        if (numb == 86)
                        {
                            g.Victory = true;
                            break;
                        }
                        if (numb == g.MyNum)
                        {
                            SendAnswer();
                        }
                        string serverReply = g.GetMsg();
                        answersTable.Rows.Add
                            (
                            names[numb],
                                Convert.ToString(serverReply[0])
                            + 
                                Convert.ToString(serverReply[1]) 
                            + 
                                Convert.ToString(serverReply[2]) 
                            +
                                Convert.ToString(serverReply[3]),
                            serverReply[5],
                            serverReply[7]
                            );
                    }
                }
                MessageBox.Show("Victory!");
                resultsTable tab = new resultsTable(g);
                tab.ShowDialog();
                Close();
            }
        }

        private void SendAnswer()
        {
            /*ДОБАВИТЬ ПРОВЕРКИ*/
            answerForm ansForm = new answerForm(g);
            ansForm.ShowDialog();
        }
    }
}
