using System;
class Program
{
     static void Main(string[] args)
    {
        string sayi="999";
        bool sonuc=int.TryParse(sayi, out int outsayi);
            if(sonuc){
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outsayi);
            
            }
            else{
                Console.WriteLine("Başarısız!");
            }
         Metot instance=new Metot();
         instance.Topla(4,5,out int toplamSonuc);
         Console.WriteLine(toplamSonuc);

         int ifade=999;
         instance.EkranaYazdır(Convert.ToString(ifade));
         instance.EkranaYazdır(ifade);
         instance.EkranaYazdır("Burak","köklü");


       }

       class Metot{
        public void Topla(int a, int b, out int toplam)
        {
            toplam=a+b;
        }
          public void EkranaYazdır(string veri){
        Console.WriteLine(veri);
       }
       public void EkranaYazdır(int veri){
        Console.WriteLine(veri);
       }
       public void EkranaYazdır(string veri1, string veri2){
        Console.WriteLine(veri1+veri2);
       }
       }
     
 
 }
       