using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Ikan : Air
    {
        public Ikan()
        {
            Warna = "Merah";
            JumlahKaki = 0;
            Kecepatan = 100;

        }

        public override void Berhenti()
        {
            Console.WriteLine("Burung Berhenti .. !!!");
        }
    }
}
