using System;

namespace Skat
{

    public class Spieler
    {
        public Guid id;
        public String name;


        public Spieler(string name)
        {
            this.id = new Guid();
            this.name = name;
        }
    }
}