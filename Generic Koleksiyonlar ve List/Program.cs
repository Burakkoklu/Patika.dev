using System;  
using System.Collections.Generic;
  public class Burak  
   {  
     static void Main(string[] args)
        {
           List<int> sayiListesi=new List<int>();
           sayiListesi.Add(23);
           sayiListesi.Add(10);
           sayiListesi.Add(4);
           sayiListesi.Add(5);
           sayiListesi.Add(92);
           sayiListesi.Add(34);

           List<String> renkListesi=new List<string>();
           renkListesi.Add("Kırmızı");
           renkListesi.Add("Mavi");
           renkListesi.Add("Turuncu");
           renkListesi.Add("Sarı");
           renkListesi.Add("Yeşil");

           //Count
           Console.WriteLine(renkListesi.Count);
           Console.WriteLine(sayiListesi.Count);

           foreach (var sayi in sayiListesi)
              Console.WriteLine(sayi);
           foreach (var renk in renkListesi)
              Console.WriteLine(renk);

           sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
           renkListesi.ForEach(renk=>Console.WriteLine(renk));


         //Listeden eleman çıkarma
         sayiListesi.Remove(4);
         renkListesi.Remove("Yeşil");
         
         //Listeden index numarasına göre eleman çıkarma
         sayiListesi.RemoveAt(0);
         renkListesi.RemoveAt(1);
         sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
         renkListesi.ForEach(renk=>Console.WriteLine(renk));


         //Liste içerisinde arama
         if(sayiListesi.Contains(10)){
            Console.WriteLine("10 Liste içerisinde bulundu!");
         }


         //Eleman ile index'e erişme
         Console.WriteLine(renkListesi.BinarySearch("Turuncu"));


        //Diziyi List'e çevirme
        string[] hayvanlar={"Kedi","Köpek","Kuş"};

        List<string> hayvanlarListesi = new List<string>(hayvanlar);
        hayvanlarListesi.ForEach(hh=> Console.WriteLine(hh));

        //Listeyi nasıl temizleriz ?
        hayvanlarListesi.Clear();


        //List içerisinde nesne tutmak
        List<Kullanıcılar>kullanıcıListesi=new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1=new Kullanıcılar();
        kullanıcı1.Isim="Burak";
        kullanıcı1.Soyisim="Köklü";
        kullanıcı1.Yas=26;
       
        Kullanıcılar kullanıcı2=new Kullanıcılar();
        kullanıcı2.Isim="Tuba";
        kullanıcı2.Soyisim="Karaoğlu";
        kullanıcı2.Yas=25;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);

        List<Kullanıcılar>yeniListe=new List<Kullanıcılar>();

        yeniListe.Add(new Kullanıcılar(){
         Isim="Deniz",
         Soyisim="Arda",
         Yas=24
        });
        foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
        {
         Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isim);
         Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Soyisim);
         Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Yas);
        }

        yeniListe.Clear();


        }



        }
        public class Kullanıcılar{
            string isim;
            string soyisim;
            int yas;

            public string Isim { get=> isim; set=>isim = value; }
            public string Soyisim { get=> soyisim; set=>soyisim = value; }
            public int Yas { get=> yas; set=>yas = value; }

        }
   