using System;
using System.Collections.Generic;

namespace Skat
{
    class Program
    {
        static void Main(string[] args)
        {
            // test database
            var spieler = new List<Spieler>();
            var spieler1 = new Spieler("Jan");
            var spieler2 = new Spieler("Magnus");
            var spieler3 = new Spieler("Johannes");
            
            spieler.Add(spieler1);
            spieler.Add(spieler2);
            spieler.Add(spieler3);
            
            var abend = new Abend(spieler);

            using (var skatContext = new SkatContext())
            {
                skatContext.abende.Add(abend);
                skatContext.SaveChanges();
                
            }
           







        }
    }
}