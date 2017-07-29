namespace Skat
{
    public struct AbendRegeln
    {
        public SchneiderAb SchneiderAb;
        public BockRamsch BockRamsch;
        public bool KontraErlaubt;
        public bool ReErlaubt;
        public bool KontraNurBeiReizen;
        public Grandwerte Grandwerte;
        public bool GrandHandBeiRamsch;
        public bool EingepassterRamsch;


    }

    public enum SchneiderAb
    {
        DREISSIG=30,
        EINUNDDREISSIG=31
    }
    
    public enum Grandwerte
    {
        ACHTZEHN = 18,
        ZWANZIG=20,
        ZWEIUNDZWANZIG=22,
        VIERUNDZWANZIG=24
    }
    
    

    public struct BockRamsch
    {
        public bool KontraVerloren;
        public bool KontraGewonnen;
        public bool SchneiderVerloren;
        public bool SchneiderGewonnen;
        public bool Spaltarsch;
        
    }
    
    
}