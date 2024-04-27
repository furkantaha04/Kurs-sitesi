namespace KursSitesi.Models
{
    public static class Repository
    {
        private static List<CandiDate> applications = new();
        public static IEnumerable<CandiDate> Applications => applications; //Numara edilebilir 
           //form'dan gelen elemanları ekleme 
           public static void Add(CandiDate candiDate)
           {
            applications.Add(candiDate);
           }
    }
    //STATİK OLARAK TANIMLAMA SEBEBİ HERKES AYNI YAPIYI KULLANSIN VE ÖZEL ALAN OLSUN 
}