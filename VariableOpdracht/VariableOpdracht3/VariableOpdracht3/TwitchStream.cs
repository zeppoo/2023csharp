﻿namespace VariableOpdracht3
{

    internal class TwitchStream
    {
        private string tag;

        internal TwitchStream(string tag)
        {
            this.tag = tag;
        }
        internal string GetTag()
        {
            return tag;
        }

        internal void SetTag(string tag)//maak hier een variable: type: string, name: tag
        {
            this.tag = tag;
        }
    }
}