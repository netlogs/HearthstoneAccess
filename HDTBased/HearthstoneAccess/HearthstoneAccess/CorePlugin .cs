using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HearthstoneAccess
{
    public class CorePlugin : IPlugin
    {
        public string Name => "HearthstoneAccess";

        public string Description => "A plugin for Hearthstone Blind players";

        public string ButtonText => "BUTTON TEXT";

        public string Author => "954-Ivory";

        public Version Version => new Version(0, 0, 1);

        public MenuItem MenuItem => null;

        public void OnButtonPress()
        {
            throw new NotImplementedException();
        }

        public void OnLoad()
        {
            GameEvents.OnGameStart.Add(Core.GameStart);
            GameEvents.OnTurnStart.Add(Core.TurnStart);
        }

        public void OnUnload()
        {
            throw new NotImplementedException();
        }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
