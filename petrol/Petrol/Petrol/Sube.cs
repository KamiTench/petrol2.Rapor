namespace Petrol
{
    public class Subel  
    {
        public int SubeId { get; set; }
        public string SubeAd { get; set; }
        public string SubeAdres { get; set; }


        public Subel(int id, string ad, string adres)
        {
            SubeId = id;
            SubeAd = ad;
            SubeAdres = adres;
        }

  
        public Subel() { }
    }
}
