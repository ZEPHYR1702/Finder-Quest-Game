using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinderQuest
{
    public class PlayerControl
    {
        private Dictionary<Keys, Action> _inputMap;

        public static void InitializeInputMap()
        {
            _inputMap = new Dictionary<Keys, Action>
            {

            }
        }
    }
}
