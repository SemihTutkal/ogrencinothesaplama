using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPÖrnek
{
    public class Class1
    {
      public  string ogrenciIsmi;
        public string ogreciSoyismi;
         public int ogreciNosu;
    
      public   double[] ogreciPuanı ;
         public string ders;
       public  string kontrol;
        double toplam = 0;
      public  int uzunluk = 0;
        public double getPuan(){
      
            foreach (double item in ogreciPuanı)
            {
               
                toplam += item;
            }
            return toplam;
        }




        public string result() {
            string data = ogrenciIsmi +" "+ "Numaralı " + "  " + ogreciNosu + "  " + ogreciSoyismi + "  " + ders +" "+"Dersinden"+"  "+toplam /uzunluk+"  "+"Ortalama İle "+" "+kontrol;
            return data;
        }

    }
}