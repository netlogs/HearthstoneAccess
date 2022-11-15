using API = Hearthstone_Deck_Tracker.API;
using Core = Hearthstone_Deck_Tracker.Core;
using Hearthstone_Deck_Tracker.Plugins;
using HearthstoneAccess.Utils;
using System;
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
            //throw new NotImplementedException();
        }


        public void OnLoad()
        {
            PositionHelper positionHelper = new PositionHelper();
            API.GameEvents.OnGameStart.Add(Main.GameStart);
            API.GameEvents.OnTurnStart.Add(Main.TurnStart);
        }

        public void OnUnload()
        {
            //throw new NotImplementedException();
        }

        public void OnUpdate()
        {
            //throw new NotImplementedException();
        }
    }
}
