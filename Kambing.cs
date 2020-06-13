using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Kambing : Darat
    {
        public Kambing()
        {
            Warna = "hijau";
            JumlahKaki = 4;
            Kecepatan = 40;

        }

        public override void Berhenti()
        {
            Console.WriteLine("Kambing Bergerak .. !!!");
        }
    }
}