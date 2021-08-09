using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnythingButCreed
{
    class Song
    {
        public string Artist { get; set; }

        public string Name { get; set; }

        public Song(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }
    }
}
