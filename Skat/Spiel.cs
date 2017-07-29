using System;

namespace Skat
{
    public enum Spieltyp
    {
        KREUZ, PIK , HERZ, KARO, GRAND, NULL
    }

    public class Spiel
    {
        public Guid id;
        public Guid abendId;
        public DateTime datetime;
        public bool won;
        public Spieltyp spieltyp;

      
        public Spiel(Guid abendId)
        {
            this.abendId = abendId;

        }
    }
}