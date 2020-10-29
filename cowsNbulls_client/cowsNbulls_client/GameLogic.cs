using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cowsNbulls_client
{
    public class GameLogic
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static int numOfPlayers;
        static int numOfRounds;
        static string name;
        static bool comp;
        static bool victory;
        static int myNum;


        public void init()
        {
            numOfPlayers = 1;
            numOfRounds = 1;
            name = "";
            comp = false;
            victory = false;
            myNum = 0;
        }

        public GameLogic()
        {
            numOfPlayers = 1;
            numOfRounds = 1;
            name = "";
            comp = false;
            victory = false;
            myNum = 0;
        }
        ~GameLogic()
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch (SocketException)
            {

            }
            catch (ObjectDisposedException)
            {

            }
            socket.Close();
        }
        public string Name { get { return name; } set { name = value; } }
        public bool Comp { get { return comp; } set { comp = value; } }
        public int NumOfPlayers { get { return numOfPlayers; } set { numOfPlayers = value; } }
        public int NumOfRounds { get { return numOfRounds; } set { numOfRounds = value; } }
        public bool Victory { get { return victory; } set { victory = value; } }
        public int MyNum { get { return myNum; } set { myNum = value; } }

        public void Connect(string ip)
        {
            try
            {
                socket.Connect(ip, 1111);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Connect error!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Connect error!");
            }
            catch (SocketException)
            {
                MessageBox.Show("Connect error!");
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Connect error!");
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Connect error!");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Connect error!");
            }

        }

        public void ConnectionError()
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch (SocketException)
            {

            }
            catch (ObjectDisposedException)
            {

            }
            socket.Close();
        }

        public void SendMsg(string msg)
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
            if (socket.Send(sizeBuf) == 0)
            {
                ConnectionError();
            }

            if (socket.Send(buffer) == 0)
            {
                ConnectionError();
            }
        }
        public string GetMsg()
        {
            string res = String.Empty;
            var sizeBuf = new byte[2];
            sizeBuf[0] = 0;
            sizeBuf[1] = 0;
            if (socket.Receive(sizeBuf) == 0)
            {
                ConnectionError();
                return "-1";
            }
            var buffer = new byte[sizeBuf[0]];
            socket.Receive(buffer);
            //for (int i = 0; i < sizeBuf[0]; i++)
            //{
            //    res += Convert.ToBase64String(buffer[i]);
            //}
            res = Encoding.ASCII.GetString(buffer);
            return res;
        }
    }
}