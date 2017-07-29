using System;

namespace Skat
{
    public enum Spieltyp
    {
        KREUZ, PIK , HERZ, KARO, GRAND, NULL, RAMSCH
    }

    public enum Ansage
    {
        KEINE, SCHNEIDER, SCHWARZ
    }

    public class Spiel
    {
        public Spieler spieler;
        public Spieler geber;

        public Guid id;
        public Guid abendId;

        public DateTime datetime;
        public Spieltyp spieltyp;
        
        public bool bock;
        public bool re;
        public bool kontra;
        public bool hand;
        public bool ouvert;

        public int punkte;
        public int spielNummer;

        public bool gewonnen;


        public Spiel(Guid abendId)
        {
            this.abendId = abendId;

        }

        public Spiel(Guid abendId, Ansage ansage)
        {
            this.abendId = abendId;

        }
    }
}