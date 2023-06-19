using System;
using Employee.Models;
using Employee.Models.Abstract;

namespace Employee
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BasePersonel BP = new KadroluPersonel(1, "GOKALP","Hasan",3000,3);
            int aylik = BP.AylikHesapla();
            Console.WriteLine("Adi Soyadi : " + BP.AdSoyadGetir() + " Maasi " + aylik.ToString());

            BasePersonel BP2 = new SozlesmeliPersonel(2, "IMAL","Muhammed",13000,5);
            int aylik2 = BP2.AylikHesapla();
            Console.WriteLine("Adi Soyadi : " + BP2.AdSoyadGetir() + " Maasi " + aylik2.ToString());
            
            BasePersonel BP3 = new StajyerPersonel(3, "CETIN","Sinan",7000,7);
            int aylik3 = BP3.AylikHesapla();
            Console.WriteLine("Adi Soyadi : " + BP3.AdSoyadGetir() + " Maasi " + aylik3.ToString());
        }
    }
}
