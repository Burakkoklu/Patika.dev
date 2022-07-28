using System;
class Program
{
     static void Main(string[] args)
    {
        //Metin Uzunlugu
       string degisken="Dersimiz CSharp, Hoşgeldiniz!";
       string degisken2="CSharp";
       Console.WriteLine(degisken.Length);

       //ToUpper metin karakterlerinin hepsini büyük harfle yazar. TopLower metin karakterlerinin hepsini küçük harfle yazar.
       Console.WriteLine(degisken.ToUpper());
       Console.WriteLine(degisken.ToLower());

       //Concat birleştirme işlemi yapar.
       Console.WriteLine(string.Concat(degisken,"Merhaba"));

       //Compare, CompareTo
       Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
       Console.WriteLine(string.Compare(degisken,degisken2,false));
       Console.WriteLine(string.Compare(degisken,degisken2,true));

       //Contains içinde var mı yok mu ?
       Console.WriteLine(degisken.Contains(degisken2));
       Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
       Console.WriteLine(degisken.StartsWith("MErhaba!"));

       //IndexOf kelime sırası arama, aranan kelimeyi bulamazsa -1 döner, büyük küçük harf duyarlıdır
       Console.WriteLine(degisken.IndexOf("CS"));//
       
       //Insert belirtilen index numarasına göre ekleme yapar.
       Console.WriteLine(degisken.Insert(0,"Merhaba! "));

       //PadLeft, PadRight 
       Console.WriteLine(degisken+degisken2.PadLeft(30));
       Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
       Console.WriteLine(degisken.PadRight(50)+degisken2);
       Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

       //Remove belirtilen Index'den sonrasını veya belirlenen aralığı siler
       Console.WriteLine(degisken.Remove(10));
       Console.WriteLine(degisken.Remove(5,3));
       Console.WriteLine(degisken.Remove(0,1));

       //Replace
       Console.WriteLine(degisken.Replace("CSharp","C#"));
       Console.WriteLine(degisken.Replace(" ","*"));

       //Split 
       Console.WriteLine(degisken.Split(' ')[1]);

       //Substring belirtilen aralıktan sonrasını veya belirtilen aralığı getirir
       Console.WriteLine(degisken.Substring(4));
       Console.WriteLine(degisken.Substring(4,6));





            
    }
          
 }
            

    
                
        
    
        
       



       
    
       
     
 
       