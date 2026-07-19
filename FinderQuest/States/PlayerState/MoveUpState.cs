using FinderQuest.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinderQuest.States.PlayerState
{
    public class MoveUpState : CoreStateMachine<Player>
    {
        public void Enter(Player player)
        {

        }

        public void Update(Player player)
        {
            player.Picture.Location = new Point(player.Picture.Location.X, player.Picture.Location.Y - 5);
            player.Picture.Image = Properties.Resources.player_back;
        }

        public void Exit(Player player)
        {

        }
    }
}
