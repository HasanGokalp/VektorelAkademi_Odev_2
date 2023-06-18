using Employee.Models.Abstract;

namespace Employee.Models
{
    public class SozlesmeliPersonel : BasePersonel
    {
        public int Gun { get; set; }
        public int Gunluk { get; set; }
        
        public SozlesmeliPersonel(int id , string soyad, string ad,int gun, int gunluk)
            :base(id, soyad, ad)
        {
            this.Gun = gun;
            this.Gunluk = gunluk;
        }

        public override int AylikHesapla()
        {
            return Gun * Gunluk;
        }
    }
}