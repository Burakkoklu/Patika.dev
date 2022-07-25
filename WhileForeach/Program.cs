using System;
class Program
{
     static void Main(string[] args)
    {

        //1 den başlayarak girilen değere kadar olan sayıları toplayıp ortalamasını yazdıran program 
      Console.WriteLine("Bir Sayı Giriniz:");
      int sayi=int.Parse(Console.ReadLine());
      int sayac=1;
      int toplam=0;
      while (sayac<=sayi)
      {
        toplam+=sayac;
        sayac++;
      }
      Console.WriteLine(toplam/sayi);

       //'a' dan 'z'ye kadar tüm harfleri yazdıran program

       char alfabe='a';
       while (alfabe<='z')
       {
        Console.Write(alfabe);
        alfabe++;
       }

       //foreach kullanımı
       String[] arabalar={"BMW","Ford","Toyota","Nissan"};
       foreach (var araba in arabalar)
       {
        Console.WriteLine(araba);
        
       }

        }
    }
