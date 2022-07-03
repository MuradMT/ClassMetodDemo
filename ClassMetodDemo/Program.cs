namespace ClassMetodDemo
{
    class Musteri
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi:"+musteri.ID);
        }
        public void MusteriDelete(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi:"+musteri.ID);
        }
        public void MusteriList(Musteri musteri)
        {
            Console.WriteLine("Musteri Bilgileri:" + musteri.ID+" "+musteri.Name+" "+musteri.Surname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}