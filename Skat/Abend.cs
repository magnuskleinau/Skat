using System;
using System.Collections.Generic;

namespace Skat
{
    public class Abend
    {
        public Guid id;
        public List<Spieler> spieler;
        public List<Spiel> spiele;
        public DateTime datetime;
        
        public Abend(List<Spieler> spieler)
        {
            this.id = new Guid("secret");
            this.datetime = System.DateTime.Now;
            this.spieler = spieler;
            this.spiele = new List<Spiel>();       
        
        }


        public void addSpiel(Spiel spiel)
        {
            this.spiele.Add(spiel);
        }

        public Spiel getNextSpiel()
        {
            
        }
    }
}