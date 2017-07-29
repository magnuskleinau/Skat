using System;
using System.Collections.Generic;
using System.Linq;

namespace Skat
{
    public class Tests
    {

        public static void SeedData()
        {
            var spieler = new List<Spieler>();
            var spieler1 = new Spieler("Jan");
            var spieler2 = new Spieler("Magnus");
            var spieler3 = new Spieler("Johannes");
            
            spieler.Add(spieler1);
            spieler.Add(spieler2);
            spieler.Add(spieler3);


            AbendRegeln regeln = new AbendRegeln
            {
                bockRamsch = new BockRamsch
                {
                    KontraGewonnen = true,
                    KontraVerloren = true,
                    SchneiderGewonnen = true,
                    SchneiderVerloren = true,
                    Spaltarsch = true
                },
                eingepassterRamsch = true,
                grandHandBeiRamsch = false,
                grandwert = Grandwerte.ACHTZEHN,
                kontraErlaubt = true,
                kontraNurBeiReizen = true,
                reErlaubt = true,
                schneiderAb = SchneiderAb.DREISSIG

            };
            
            var abend = new Abend(spieler,regeln);

           
            
            
            var spiel = new Spiel(abend,abend.AbendId,0,spieler1,spieler2, Spieltyp.FARBE, Farbe.HERZ, Spielstaerke.M1, Ansage.KEINE, false, true, true, false, false, 59 ); 
            
            
            
            using (var skatContext = new SkatContext())
            {
                skatContext.abende.Add(abend);
                skatContext.spiele.Add(spiel);
                skatContext.SaveChanges();
            }
        }
        
        
        
        public static void DbTest()
        {
            
            using (var skatContext = new SkatContext())
            {
                var abende = skatContext.abende.ToList();
                var spiele = skatContext.spiele.ToList();
                Console.WriteLine($"Die Datenbank enthält momentan {abende.Count} Abende");
                Console.WriteLine($"ID des ersten Abends ist: {abende[0].AbendId}");
                Console.WriteLine($"Die Datenbank enthält momentan {spiele.Count} Spiele");
                Console.WriteLine($"ID des ersten Spiele ist: {spiele[0].id}");

            }
        }
    }
}