using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Burung : Udara
    {
        public Burung()
        {
            Warna = "Putih";
            JumlahKaki = 2;
            Kecepatan = 220;

        }

        public override void Berhenti()
        {
            Console.WriteLine("Burung Berhenti .. !!!");
        }
    }
}