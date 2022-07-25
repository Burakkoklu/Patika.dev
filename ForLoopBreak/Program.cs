using System;
class Program
{
     static void Main(string[] args)
    {
        // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
        Console.WriteLine("Sayı Giriniz:");
        int sayac=int.Parse(Console.ReadLine());
        for (int i = 0; i <= sayac; i++)
        {
            if(i%2==1)
            Console.WriteLine(i);
        }
        // 1 ile 1000 arasında ki tek ve çift sayıların kendi aralarında toplamlarını ekrana yazdır
        int tektoplam=0;
        int cifttoplam=0;

     for (int i = 1; i <= 1000; i++)
     {
        if(i%2==1)
        tektoplam+=i;

        else
        cifttoplam +=i;
     }
     Console.WriteLine("Tek Toplam:"+tektoplam);
     Console.WriteLine("Çift Toplam:"+cifttoplam);
      
      // Break, Continue

      for (int i = 1; i < 10; i++)
      {
        if(i==4)
        break;
        Console.WriteLine(i);

        if(i==4)
        continue;
        Console.WriteLine(i);
      }
     
    }
}