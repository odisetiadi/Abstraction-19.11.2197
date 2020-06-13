using System;

namespace Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Ayam ayam = new Ayam();
            Kambing kambing = new Kambing();
            Ikan ikan = new Ikan();
            Burung burung = new Burung();

            ayam.Warna = "putih";
            ayam.JumlahKaki = 2;
            ayam.Kecepatan = 20;
            ayam.Bergerak();
            Console.WriteLine("Warna Ayam :{0} ", ayam.Warna);
            Console.WriteLine("Kecepatan Ayam :{0} ", ayam.Kecepatan);
            Console.WriteLine("Jumlah Kaki Ayam :{0} ", ayam.JumlahKaki);
            Console.WriteLine("---------------------");

           
            Console.WriteLine("Warna kambing :{0} ", kambing.Warna);
            Console.WriteLine("Kecepatan kambing :{0} ", kambing.Kecepatan);
            Console.WriteLine("Jumlah Kaki kambing :{0} ", kambing.JumlahKaki);
            Console.WriteLine("---------------------");

           
            Console.WriteLine("Warna ikan :{0} ", ikan.Warna);
            Console.WriteLine("Kecepatan ikan :{0} ", ikan.Kecepatan);
            Console.WriteLine("Jumlah Kaki ikan :{0} ", ikan.JumlahKaki);
            Console.WriteLine("---------------------");

           
            Console.WriteLine("Warna Burung :{0} ", burung.Warna);
            Console.WriteLine("Kecepatan Burung :{0} ", burung.Kecepatan);
            Console.WriteLine("Jumlah Kaki Burung :{0} ", burung.JumlahKaki);
            Console.WriteLine("---------------------");

            Console.ReadKey();
        }
    }
}