
// Generic : C# 2.0 ile birlikte gelen bir özelliktir.!!!
// Genericten önce, tüm koleksiyonlarda, boxing ve unboxing sorunu yaşanmaktaydı.

// Çünkü .net içerisinde generic gelene kadar tüm koleksiyonlar object tipinde çalışmaktaydı!!!.

// Koleksiyonlarda
// Sınıflarda 
// Metotlarda 

// Generic Kavramı tanım : Bir koleksiyonu sınıfı yada metodu, derleme aşamsında girmiş olduğunuz tipe göre
// çalıştırabileceğiniz bir özelliktir!!


// Generic Koleksiyonlar!!! 

// Generic koleksiyonlar, normal koleksiyonlarda farklıdır!! 

// Generic koleksiyonların en popüleri List koleksiyonudur!!

// List Koleksiyonu : 

// Syntax : 
// List<tip> listenin Adi = new List<tip>();

// int tipinde bir list koleksiyonu tanımlayalım

using System.Collections;


List<int> degisken = new List<int>();
degisken.Add(1);
degisken.Add(2);
degisken.Add(3);

// String tipinde bir list koleksiyonu tanımlayalım!!
List<string> stringKoleksiyon = new List<string>();
stringKoleksiyon.Add("ayşe");
stringKoleksiyon.Add("fatma");


//OGrenci tipinde bir koleksiyon tanımlayalım

List<Ogrenci> ogrenciKoleksiyonu = new List<Ogrenci>();
ogrenciKoleksiyonu.Add(new Ogrenci()
{

    Id = 1,
    Name = "adnan"
});

ogrenciKoleksiyonu.Add(new Ogrenci()
{

    Id = 2,
    Name = "Metin"
});


// yukarıdaki örneklerden de anlaşılabileceği gibi, generic list koleksiyonunda, çalışmak istediğiniz tipi,
// kendiniz derleme zamanında verebiliyorsunuz!!!


// List generic koleksiyonun metotları
// Ogrenci otomasyonu
// Ogrenci ekleme
// Ogrenci Silme
// Ogrenci Güncelleme
// Ogrenci Listeleme


OgrenciHelper helper = new OgrenciHelper();
Console.WriteLine("Öğrenci Otomasyon uygulamasına hoşgeldiniz.");
while (true)
{

    
    Console.WriteLine("Ögrenci listelemek için 1");
    Console.WriteLine("Öğrenci silmek için 2");
    Console.WriteLine("Öğrenci eklemek için 3");
    Console.WriteLine("Öğrenci Güncellemek için 4");

    int secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            helper.OgrenciListele();
            break;
        case 2:
            helper.OgrenciSil();
            break;
        case 3:
            helper.OgrenciEkle();
            break;
        case 4:
            helper.OgrenciGuncelle();
            break;

    }

}








