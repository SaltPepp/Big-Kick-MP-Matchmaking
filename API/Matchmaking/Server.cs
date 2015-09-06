using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchmakingTypes
{
    public class OnlineConnection
    {
        public string userName;
        public string passWord;
        public string Host;
        public int Port;
    }

    public class Server
    {
        public string GMOD;
        public string Name;
        public string Host;
        public int Port;
        public int playerCount;
        public int playerCap;
    }

    public class Player
    {
        public string Name;
        public string Nick;
        public int Level;
        public string IP;
        public int Port;
        public bool isHost;
    }
}
