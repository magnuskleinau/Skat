using System;

namespace Skat
{
    public enum Spieltyp
    {
        FARBE, GRAND, NULL, RAMSCH
    }

    public enum Farbe
    {
        KREUZ = 12, PIK = 11, HERZ = 10, KARO = 9
    }

    public enum Spielstaerke
    {
        M1 = 2, M2 = 3, M3 = 4, M4 = 5, O1 = 2, O2 = 3, O3 = 4, O4 = 5
    }

    public enum Ansage
    {
        KEINE, SCHNEIDER, SCHWARZ
    }

    public class Spiel
    {
        //passed variables
        public Spieler spieler;
        public Spieler geber;

        public Guid id;
        public Guid abendId;

        public Spieltyp spieltyp;
        public Farbe farbe;
        public Spielstaerke spielstaerke;
        public Ansage ansage;

        public bool bock;
        public bool re;
        public bool kontra;
        public bool hand;
        public bool ouvert;

        public int punkte;
        public int spielNummer;

        //other variables
        public DateTime datetime;

        public bool gewonnen;

        public int spielwert;


        public Spiel(Guid abendId, Guid id, int spielNummer, Spieler spieler, Spieler geber, Spieltyp spieltyp, Farbe farbe, Spielstaerke spielstaerke, Ansage ansage, bool bock, bool re, bool kontra, bool hand, bool ouvert, int punkte)
        {
            //pass parameters to local variables
            this.abendId = abendId;
            this.id = id;
            this.spielNummer = spielNummer;
            this.spieler = spieler;
            this.geber = geber;
            this.spieltyp = spieltyp;
            this.farbe = farbe;
            this.spielstaerke = spielstaerke;
            this.ansage = ansage;
            this.bock = bock;
            this.re = re;
            this.kontra = kontra;
            this.hand = hand;
            this.ouvert = ouvert;
            this.punkte = punkte;

            //init other variables
            this.datetime = DateTime.Now;
            calculateSpielwert();
        }

        private void calculateSpielwert()
        {
            spielwert = (int)farbe * (int)spielstaerke;
        }

        public Spiel(Guid abendId, Ansage ansage)
        {
            this.abendId = abendId;

        }
    }
}