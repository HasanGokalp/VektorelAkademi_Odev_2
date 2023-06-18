using Employee.Models.Abstract;

namespace Employee.Models
{
    public class StajyerPersonel : BasePersonel
    {
        public int Saat { get; set; }
        public int Saatlik { get; set; }
        public StajyerPersonel(int id , string soyad, string ad,int saat, int saatlik)
            :base(id, soyad, ad)
        {
            this.Saat = saat;
            this.Saatlik = saatlik;
        }

        public override int AylikHesapla()
        {
            return Saat * Saatlik;
        }
    }
}