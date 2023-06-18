using Employee.Models.Abstract;

namespace Employee.Models
{
    public class KadroluPersonel : BasePersonel
    {
        public int Aylik { get; set; }
        public int Rapor { get; set; }

        public KadroluPersonel(int id , string soyad, string ad,int aylik, int rapor)
            :base(id, soyad, ad)
        {
            this.Aylik = aylik;
            this.Rapor = rapor;
        }

        public override int AylikHesapla()
        {
            if (Rapor <= 5)
                return Aylik;
            else
                return Aylik - (Aylik / 30) * Rapor;
        }
    }
}