public class OgrenciHelper
{

    public List<Ogrenci> Ogrenciler { get; set; }
    public OgrenciHelper()
    {
        // new komutu ile ogrenciler koleksiyonu belleğe çıkartalım
        Ogrenciler = new List<Ogrenci>();
    }
    public void OgrenciListele()
    {
        if (Ogrenciler.Count == 0)
        {
            Console.WriteLine("Öğrenci koleksiyonu boş");
            Console.WriteLine("Öğrenci eklemek için 3 tuşuna basınız!!");
        }
        else
        {
            foreach (Ogrenci ogr in Ogrenciler)
            {
                Console.WriteLine("Id : {0}", ogr.Id);
                Console.WriteLine("Ad : {0}", ogr.Name);
            }
        }
    }
    public void OgrenciEkle()
    {
        Console.WriteLine("Eklemek istediğiniz öğrencinin bilgilerini giriniz");
        Console.WriteLine("Öğrenci Adını Giriniz");
        string ogrenciAd = Console.ReadLine();
        Console.WriteLine("Öğrenci Numarasını ekleyiniz");
        int ogrenciNo = int.Parse(Console.ReadLine());

        Ogrenci eklenecekOgrenci = new Ogrenci()
        {
            Id = ogrenciNo,
            Name = ogrenciAd
        };
        Ogrenciler.Add(eklenecekOgrenci);
    }
    public void OgrenciSil()
    {
        Console.WriteLine("Silmek istediğiniz öğrencinin numarasını yazınız");
        int ogrenciNo = int.Parse(Console.ReadLine());

        foreach (Ogrenci ogr in Ogrenciler)
        {
            if (ogr.Id == ogrenciNo)
            {

                // Ogrenci nesnesi koleksiyondan silinmiştir!!!
                Ogrenciler.Remove(ogr);
                break;
            }
        }
    }
    public void OgrenciGuncelle()
    {

        Console.WriteLine("Güncellemek istediğiniz öğrencinin numarasını yazınız");
        int ogrenciNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Güncelleyeceğiniz adı giriniz");
        string ogrenciAd = Console.ReadLine();
        Console.WriteLine("Güncelleyeceğiniz öğrenci numarasını giriniz");
        int guncelOgrenciNo = int.Parse(Console.ReadLine());
        foreach (Ogrenci ogr in Ogrenciler)
        {
            if (ogr.Id == ogrenciNo)
            {
                //ogr ogrenci nesnem !!!!
                int ogrenciIndex = Ogrenciler.IndexOf(ogr);
                Ogrenciler[ogrenciIndex] = new Ogrenci()
                {

                    Id = guncelOgrenciNo,
                    Name = ogrenciAd
                };
                break;
            }
        }
    }
}