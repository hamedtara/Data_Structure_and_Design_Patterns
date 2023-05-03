using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05.Decorator
{
    public abstract class PlayerEnhancer : Player
    {
        public Player player;
        public int bossVolume;
        public PlayerEnhancer(Player player) {
        
            this.player = player;
        
        }


        public virtual void play()
        {
            player.play();
        }

    }
}
