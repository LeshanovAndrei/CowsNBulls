using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_client
{
    class Program
    {
        static void SendMsg(string msg)
        {
            var buffer = new byte[msg.Length];
            //buffer[msg.Length] = 0;
            for (int i = 0; i < msg.Length; i++)
            {
                buffer[i] = Convert.ToByte(msg[i]);
            }
            var sizeBuf = new byte[2];
            sizeBuf[0] = 0;
            sizeBuf[1] = 0;
            sizeBuf[0] = Convert.ToByte(buffer.Length);
            socket.Send(sizeBuf);
            socket.Send(buffer);
        }
        static string GetMsg()
        {
            string res = String.Empty;
            var sizeBuf = new byte[2];
            sizeBuf[0] = 0;
            sizeBuf[1] = 0;
            socket.Receive(sizeBuf);
            var buffer = new byte[sizeBuf[0]];
            socket.Receive(buffer);
            //for (int i = 0; i < sizeBuf[0]; i++)
            //{
            //    res += Convert.ToBase64String(buffer[i]);
            //}
            res = Encoding.ASCII.GetString(buffer);
            return res;
        }
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static int numOfPlayers;
        static int numOfRounds;
        static string name;
        static bool comp = false;
        static bool victory;
        static int myNum;
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();
            socket.Connect(ip, 1111);


            name = Console.ReadLine();
            //Послать имя
            SendMsg(name);

            //Получить количество игроков
            numOfPlayers = Convert.ToInt32(GetMsg());
            Console.WriteLine(numOfPlayers);
            numOfRounds = numOfPlayers;
            myNum = 0; //ВРЕМЕННО!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //Получить список игроков
            for (int i = 0; i < numOfPlayers; i++)
            {
                string tmp = GetMsg();
                Console.WriteLine(tmp);
            }

            //получить флаг игры с компьютером
            if (GetMsg() != "0")
            {
                Console.WriteLine("1");
                comp = true;
            }

            //раунды
            for (int i = 0; i < numOfRounds; i++)
            {
                victory = false;
                if (!comp)
                {
                    //получить Номер того, кто загадывает
                    int numb = Convert.ToInt32(GetMsg());
                    if (numb == myNum)
                    {
                        //Отправить загадку
                        string tmp = Console.ReadLine();
                        SendMsg(tmp);
                    }
                }

                while(!victory)
                {
                    for (int j = 0; j < numOfPlayers; j++)
                    {
                        if (!comp && i == j)
                        {
                            continue;
                        }
                        //Получить номер отвечающего
                        string tmpReply = GetMsg();
                        if (tmpReply == "V")
                        {
                            victory = true;
                            break;
                        }
                        int numb = Convert.ToInt32(tmpReply);
                        if (numb == 86)
                        {
                            victory = true;
                            break;
                        }
                        if (numb == myNum)
                        {
                            //Отправить свой ответ
                            string tmp = Console.ReadLine();
                            SendMsg(tmp);
                        }
                        //Получить ответ и реакцию
                        Console.WriteLine(GetMsg());
                    }
                }
            }



            //Таблица результатов
            for (int i = 0; i < numOfPlayers; i++)
            {
                Console.WriteLine(GetMsg());
            }
            Console.ReadLine();
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
        

    }
}
