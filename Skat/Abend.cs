using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Skat
{
    public class Abend
    {
        public int id { get; set; }
        public List<Spieler> spieler;
        public List<Spiel> spiele;
        public DateTime datetime;
        public AbendRegeln abendRegeln;
        public List<int> spielStand;
        
        public Abend(List<Spieler> spieler, AbendRegeln abendRegeln)
        {
            this.datetime = System.DateTime.Now;
            this.spieler = spieler;
            this.spiele = new List<Spiel>();
            this.abendRegeln = abendRegeln;
            this.spielStand = new List<int>{0,0,0};
        
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
        // calculate the current spielstand based on the list of games, later the database will be queried
        public List<int> calculateSpielStand()
        {
            List<int> _spielStand = new List<int>{0,0,0};
            switch (abendRegeln.zaehlweise)
            {
                   case Zaehlweise.KLASSISCH:
                       for (int i = 0; i < spiele.Count; i++)
                       {
                           for (int j = 0; j < 3; j++)
                           {
                               _spielStand[j] += spiele[i].spielwert;
                           }
                       } 
            } 
        }
    }
}