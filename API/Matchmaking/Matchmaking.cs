using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatchmakingTypes;

namespace Matchmaking
{
    public class MatchmakingAPI
    {
        private List<Server> GameServers = new List<Server>();
        private List<Player> Players = new List<Player>();
        public List<Server> getServers(OnlineConnection ServerListConnection, string GMOD)
        {
            return GameServers;
        }
    }
}
