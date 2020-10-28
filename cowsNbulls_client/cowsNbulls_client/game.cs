using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace cowsNbulls_client
{
    public partial class game : Form
    {
        GameLogic g { get; set; }
        List<string> names;
        Thread gameThread;

        private delegate void SafeCallDelegate(string serverReply, int numb);
        private delegate void SafeCallDelegateClear();

        public game(GameLogic g)
        {
            InitializeComponent();
            this.g = g;
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
            FormClosing += game_Closing;

        }

        private void game_Load(object sender, EventArgs e)
        {
            
        }

        //private void SendAnswer()
        //{
        //    sendButton.Enabled = true;
        //}

        private void game_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gameThread.Abort();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void game_Shown(object sender, EventArgs e)
        {
            gameThread = new Thread(new ThreadStart(game_process));
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
                        gameThread.Abort();
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
                            gameThread.Abort();
                        }
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
                        else
                        { 

                        }

                        string serverReply = g.GetMsg();
                        if (serverReply == "-1")
                        {
                            MessageBox.Show("Connection error!");
                            g.ConnectionError();
                            gameThread.Abort();
                        }
                        SafeTableWrite(serverReply, numb);
                    }
                }
                MessageBox.Show("Victory!"); SafeTableClear();
            }
            resultsTable tab = new resultsTable(g);
            tab.ShowDialog();
            gameThread.Abort();
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
            answerForm ansForm = new answerForm(g);
            ansForm.ShowDialog();
        }
    }
}
