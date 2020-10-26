using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace cowsNbulls_client
{
    public partial class game : Form
    {
        GameLogic g { get; set; }
        List<string> names;

        private delegate void SafeCallDelegate(string serverReply, int numb);
        private delegate void SafeCallDelegateClear();



        public game(GameLogic g)
        {
            InitializeComponent();
            this.g = g;
            //g.NumOfPlayers = Convert.ToInt32(g.GetMsg());
            g.NumOfRounds = g.NumOfPlayers;
            names = new List<string>();
            for (int i = 0; i < g.NumOfPlayers; i++)
            {
                string tmpr = g.GetMsg();
                if (tmpr == "-1")
                {
                    MessageBox.Show("Connection error!");
                    g.ConnectionError();
                    Close();
                }
                names.Add(tmpr);
                if (names[i] == g.Name)
                {
                    g.MyNum = i;
                }
            }
            string tmp = g.GetMsg();
            if (tmp == "-1")
            {
                MessageBox.Show("Connection error!");
                g.ConnectionError();
                Close();
            }
            if (tmp == "1")
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

        }

        private void game_Shown(object sender, EventArgs e)
        {
            Thread gameThread = new Thread(new ThreadStart(game_process));
            gameThread.Start();
        }

        private void game_process()
        {
            for (int i = 0; i < g.NumOfRounds; i++)
            {
                g.Victory = false;
                if (!g.Comp)
                {
                    int numb = Convert.ToInt32(g.GetMsg());
                    if (numb == -1)
                    {
                        MessageBox.Show("Connection error!");
                        g.ConnectionError();
                        Close();
                    }
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
                        if (tmpReply == "-1")
                        {
                            MessageBox.Show("Connection error!");
                            g.ConnectionError();
                            Close();
                        }
                        if (tmpReply == "V")
                        {
                            g.Victory = true;
                            break;
                        }
                        int numb = Convert.ToInt32(tmpReply);//Номер отвечающего
                        //MessageBox.Show(Convert.ToString(numb));
                        if (numb == 86)
                        {
                            g.Victory = true;
                            break;
                        }
                        if (numb == g.MyNum)
                        {
                            SendAnswer();
                        }
                        else
                        {
                            //Thread.Sleep(10000);
                        }

                        string serverReply = g.GetMsg();
                        if (serverReply == "-1")
                        {
                            MessageBox.Show("Connection error!");
                            g.ConnectionError();
                            Close();
                        }
                        SafeTableWrite(serverReply, numb);
                    }
                }
                MessageBox.Show("Victory!"); SafeTableClear();
            }
            resultsTable tab = new resultsTable(g);
            tab.ShowDialog();
        }


        private void SafeTableWrite(string serverReply, int numb)
        {
            if (answersTable.InvokeRequired)
            {
                var d = new SafeCallDelegate(SafeTableWrite);
                answersTable.Invoke(d, serverReply, numb);
            }
            else
            {
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
        private void SafeTableClear()
        {
            if (answersTable.InvokeRequired)
            {
                var d = new SafeCallDelegateClear(SafeTableClear);
                answersTable.Invoke(d);
            }
            else
            {
                answersTable.Rows.Clear();
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
