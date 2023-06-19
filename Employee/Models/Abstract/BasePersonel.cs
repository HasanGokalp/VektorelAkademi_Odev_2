namespace Employee.Models.Abstract
{
    public abstract class BasePersonel
    {
        public int Id { get; set; }
        public string Soyad { get; set; }
        public string Ad { get; set; }
        
        public BasePersonel() {}

        public BasePersonel(int id , string soyad, string ad)
        {
            this.Id = id;
            this.Ad = ad;
            this.Soyad = soyad;
        }
        
        public string AdSoyadGetir()
        {
           string isim = this.Ad;
           string soyad = this.Soyad;
           string AdSoyad = isim + " " + soyad;
           return AdSoyad;
        }

        public virtual int AylikHesapla()
        {
            return 0;
        }
    }
}
