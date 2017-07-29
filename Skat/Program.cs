using System;
using System.Collections.Generic;
using System.Linq;

namespace Skat
{
    class Program
    {
        static void Main(string[] args)
        {
            // test database
            Tests.SeedData();
            Tests.DbTest();

        }
    }
}