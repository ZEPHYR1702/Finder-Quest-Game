using FinderQuest.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.States.PlayerState
{
    public class MoveDownState : CoreStateMachine<Player>
    {
        public void Enter(Player player)
        {

        }

        public void Update(Player player)
        {
            player.Picture.Location = new Point(player.Picture.Location.X, player.Picture.Location.Y + 5);
            player.Picture.Image = Properties.Resources.player_front;
        }

        public void Exit(Player player)
        {

        }
    }
}
