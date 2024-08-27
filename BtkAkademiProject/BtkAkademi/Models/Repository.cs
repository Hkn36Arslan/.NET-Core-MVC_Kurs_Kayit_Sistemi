namespace BtkAkademi.Models
{
    public static class Repository // Tek bir kopya olarak bulunması ve sayfa yenilendiğinde hafızanın boşaltılması ve Ssnıfın üyelerinin değiştirilmemesi ve her yerden sınıfın ismi ile erişiminin sağlanması için static bir sınıf oluşturuldu.
    {
        private static List<Candidate> applications = new(); // Verileri saklamak için değiştirilemez bir liste oluşturuldu.

        public static IEnumerable<Candidate> Applications => applications; // IEnumerable<Candidate> bu yapı ile dışarıdan değiştirilemeyen ve applications listesini okuyarak  verileri dışarıya bir koleksiyon halinde sunan yapı oluşturuldu.

        public static void Add(Candidate candidate) // applications listesine yeni bir Candidate nesnesi eklemek için fonksiyon oluşturuldu. Bu method da static olduğundan sadece sınıf ismi ile çağrılabilir.
        {
            applications.Add(candidate);
        }
    }
}