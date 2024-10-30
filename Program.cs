
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
ogrenciKoleksiyonu.Add(new Ogrenci(){

     Id=1,
      Name=""
});








