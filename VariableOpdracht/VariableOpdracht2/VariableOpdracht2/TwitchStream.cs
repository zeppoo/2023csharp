using System;

namespace VariableOpdracht2
{
    internal class TwitchStream
    {
        //maak hier class variables aan:
        // type=string, naam: name,
        // type=string, naam: lastStreamName
        // type=Game, naam: streamGame
        // type=int, naam: followers
        // type=bool, naam: automod
        private string name;
        private string lastStreamName;
        private Game streamGame;
        private int followers;
        private bool automod;

        public TwitchStream(string name, string lastStreamName, Game streamGame, int followers, bool automod)
        {
            this.name = name;
            this.lastStreamName = lastStreamName;
            this.streamGame = streamGame;
            this.followers = followers;
            this.automod = automod;
        }
    }
}