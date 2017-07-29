using System;

namespace Skat
{

    public class Spieler
    {
        public int id { get; set; }
        public String name;


        public Spieler(string name)
        {
            this.name = name;
        }
    }
}