using FinderQuest.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.States.PlayerState
{
    public class MoveRightState : CoreStateMachine<Player>
    {
        public void Enter(Player player)
        {
            Console.WriteLine("entering move right");
        }

        public void Update(Player player)
        {
            player.Picture.Location = new Point(player.Picture.Location.X + 30, player.Picture.Location.Y);
            player.Picture.Image = Properties.Resources.player_right;
        }

        public void Exit(Player player)
        {

        }
    }
}
