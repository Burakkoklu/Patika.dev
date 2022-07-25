using System;
class Program
{
     static void Main(string[] args)
    {
     //Klavyeden girilen n kadar sayı dizisinin ortalamasını bulan program

     Console.Write("Lütfen Sayı Dizisini Giriniz:");
     int diziUzunlugu=int.Parse(Console.ReadLine());
     int [] sayiDizisi=new int[diziUzunlugu];
     for (int i = 0; i < diziUzunlugu; i++)
     {
        Console.WriteLine("Lütfen{0}. Sayıyı Giriniz:",i+1);
        sayiDizisi[i]=int.Parse(Console.ReadLine());
        
     }
     int toplam=0;
     foreach (var sayi in sayiDizisi)
     toplam+=sayi;
     Console.WriteLine("Girilen Sayıların Ortalaması:"+toplam/diziUzunlugu);


       }
        
       }

        
    