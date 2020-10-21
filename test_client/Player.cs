using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace test_client
{
    class Player
    {
        private string name;
        public string Name { get; set; }
        public void SendMsg(string msg) {  }
        public string GetMsg() { return "msg"; }
    }
}
