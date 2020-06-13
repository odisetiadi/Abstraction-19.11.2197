using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Hewan
    {
        private int _jumlahKaki;
        private int _kecepatan;
        private string _warna;

        public int JumlahKaki
        {
            get { return _jumlahKaki; }
            set { _jumlahKaki = value; }
        }

        public int Kecepatan
        {
            get { return _kecepatan; }
            set { _kecepatan = value; }
        }

        public String Warna
        {
            get { return _warna; }
            set { _warna = value; }
        }

        public virtual void Berhenti()
        {
            Console.WriteLine("Hewan Berhenti .. !!!");
        }

        public void Bergerak()
        {
            Console.WriteLine("Hewan Bergerak .. !!!");
        }
    }
}
