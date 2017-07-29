using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Skat
{
    public class Abend
    {
        public int AbendId { get; set; }
        public List<Spieler> spieler;
        public List<Spiel> spiele;
        public DateTime datetime;
        public AbendRegeln abendRegeln;
        
        public Abend(List<Spieler> spieler, AbendRegeln abendRegeln)
        {
            this.datetime = System.DateTime.Now;
            this.spieler = spieler;
            this.spiele = new List<Spiel>();
            this.abendRegeln = abendRegeln;
        
        }

        private Abend()
        {
            
        }


        public void addSpiel(Spiel spiel)
        {
            this.spiele.Add(spiel);
        }

        public Spiel getNextSpiel()
        {
            throw new NotImplementedException();
        }
    }
}