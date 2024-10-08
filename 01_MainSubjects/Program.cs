using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırmakomutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine(" Selam");

            //Console.WriteLine("***** YEMEK KATEGORILERI *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORILERI *****");
            #endregion

            #region Değişkenler
            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Metin";
            //Console.Write(name);
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+905321648200";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "istanbul";

            //int alignmentWidth = 20;
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: ".PadRight(alignmentWidth) + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: ".PadRight(alignmentWidth) + customerPhone);
            //Console.WriteLine("Email: " .PadRight(alignmentWidth)+ customerEmail);
            //Console.WriteLine("Adres: " .PadRight(alignmentWidth)+ district + " / " + city);
            //Console.WriteLine("-----------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+905306621040";
            //customerEmail= "aysegulkaya@gmail.com";
            //district = "Bostancı";
            //city = "İstanbul";

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: ".PadRight(alignmentWidth) + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: ".PadRight(alignmentWidth) + customerPhone);
            //Console.WriteLine("Email: ".PadRight(alignmentWidth) + customerEmail);
            //Console.WriteLine("Adres: ".PadRight(alignmentWidth) + district + " / " + city);
            //Console.WriteLine("-----------------------------------------");


            #endregion

            #region Int Değişkenler
            //int
            //int number=24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int fricePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Menü Fiyatı ***");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza Fiyatı: " + pizzaPrice+ " TL");
            Console.WriteLine("----Kola Fiyatı: " + cokePrice + " TL");
            Console.WriteLine("----limonata Fiyatı: " + lemonadePrice+ " TL");
            Console.WriteLine("----Kızartma Fiyatı: " + fricePrice + " TL");
            Console.WriteLine("----Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("*** Restoran Menü Fiyatı ***");
            
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friceCount;
            int pizzaCount;
            int lemonadeCount;


            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFricePrice;
            int totalPizzaPrice;
            int totalLemonadaPrice;

            
            int totalPrice = 0;
            hamburgerCount=3;
            cokeCount = 3;
            waterCount = 3;
            friceCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokeCount; 
            totalWaterPrice = waterCount * waterPrice;  
            totalFricePrice = friceCount *  friceCount;
            totalPizzaPrice = pizzaCount * pizzaCount;
            totalLemonadaPrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("----Hamburger Tutarı: " + totalHamburgerPrice+ " TL");
            Console.WriteLine("----Pizza Tutarı: " + totalPizzaPrice+ " TL");
            Console.WriteLine("----Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("----limonata Tutarı: " + totalLemonadaPrice+ " TL");
            Console.WriteLine("----Kızartma Tutarı: " + totalFricePrice + " TL");
            Console.WriteLine("----Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine();

              totalPrice = totalWaterPrice + totalPizzaPrice + totalHamburgerPrice + totalFricePrice + totalCokePrice + totalLemonadaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice +" TL");

            #endregion




            Console.Read();
        }
    }
}


//Yazdırma Komutları