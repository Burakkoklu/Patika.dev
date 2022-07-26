using System;
class Program
{
     static void Main(string[] args)
    {
        Islemler customer=new();
        Console.WriteLine(customer.Expo(3,4));
        
       }
       public class Islemler{
        public int Expo(int sayi, int üs){
            if(üs<2)
            return sayi;
            return Expo(sayi,üs-1)*sayi;
        }
       }
     
 
 }
       