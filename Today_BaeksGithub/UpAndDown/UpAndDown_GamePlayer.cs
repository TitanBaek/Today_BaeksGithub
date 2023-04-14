using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_BaeksGithub.UpAndDown
{
    public class UpAndDown_GamePlayer
    {
        private string playerName;
        public string PLAYERNAME
        {
            get { return playerName; }
            set { playerName = value; }
        }


        public UpAndDown_GamePlayer(string name)
        {
            this.playerName = name;
        }

    }
}
