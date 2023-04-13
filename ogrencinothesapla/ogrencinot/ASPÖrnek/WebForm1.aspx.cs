using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPÖrnek
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 myClass=new Class1();
        int uzunluk;
        string orenciIsmi;
        string ogreciSoyismi;
        int ogrenciNosu;
        string ders;
        string kontrol;
        double toplam = 0;
     
        private void puanControl()
        { 
        toplam=myClass.getPuan()/uzunluk;
            if (toplam >=50)
            {
                kontrol = "Geçti";
            }
            else {
                kontrol = "Kaldı";
                   
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           

          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            orenciIsmi = Microsoft.VisualBasic.Interaction.InputBox("Öğrencinin Adı :");
             ogreciSoyismi = Microsoft.VisualBasic.Interaction.InputBox("Öğrencinin Soyadı :");
            ogrenciNosu = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Öğrencinin Okul Numarası :"));
            ders = Microsoft.VisualBasic.Interaction.InputBox("Öğrencinin Girdiği Ders :");

            
             uzunluk = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Kaç Adet Not Gireceksiniz :"));
            double[] notlar = new double[uzunluk];

            for (int i = 0; i < uzunluk; i++)
            {
                notlar[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"{i + 1}. notu girin:"));
            }
            myClass.uzunluk = uzunluk;
            myClass.ogreciPuanı = notlar;
               myClass.ogreciSoyismi =this.ogreciSoyismi;
                   myClass.ogreciNosu =this.ogrenciNosu;
                   myClass.ogrenciIsmi =this.orenciIsmi;
                   myClass.ders =this.ders;
                    puanControl();
                   myClass.kontrol = kontrol;
                    Response.Write(myClass.result());
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          

           
        }
    }
}