using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.Read();


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;           
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //const int alignmentWidth = 10; 
            //// Burada alignmentWidth sağa 10 karakter hizalamk icin kullandıgım degıskn mevcut
            //// $ işaret dize içine değişken eklerkn kullnyrum 
            //// F2 ise ornek yukarıdakı 45 i 45.00 yapmak ıcın yanı ondalıklı hale cevırmek ıcın kullndım

            //Console.WriteLine($"---- Elma Birim Fiyatı:    {applePrice,alignmentWidth:F2} ₺");
            //Console.WriteLine($"---- Portakal Birim Fiyatı:{orangePrice,alignmentWidth:F2} ₺");
            //Console.WriteLine($"---- Çilek Birim Fiyatı:   {strawberryPrice ,alignmentWidth:F2} ₺");
            //Console.WriteLine($"---- Patates Birim Fiyatı: {potatoPrice,alignmentWidth:F2} ₺");
            //Console.WriteLine($"---- Domates Birim Fiyatı: {tomatoPrice,alignmentWidth:F2} ₺");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram* orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine();
            //Console.WriteLine("********* SATIŞ TUTARLARI *********");
            //Console.WriteLine();
            ////Console.WriteLine($"-----Alınan Ürün: #Elma -Brim Fiyat:#{applePrice:F2}₺ Gramaj:#{appleGram:F2} Toplam Tutar:#{appleTotalPrice:F2}₺");
            ////Console.WriteLine($"-----Alınan Ürün: #Portakal - Brim Fiyat:#{orangePrice:F2}₺ Gramaj:#{orangeGram:F2} Toplam Tutar:#{orangeTotalPrice:F2}₺");
            ////Console.WriteLine($"-----Alınan Ürün: #Çilek - Brim Fiyat:#{strawberryPrice:F2}₺ Gramaj:#{strawberryGram:F2} Toplam Tutar:#{strawberryTotalPrice:F2}₺");
            ////Console.WriteLine($"-----Alınan Ürün: #Pates - Brim Fiyat:#{potatoPrice:F2}₺ Gramaj:#{potatoGram:F2} Toplam Tutar:#{potatoTotalPrice:F2}₺");
            ////Console.WriteLine($"-----Alınan Ürün: #Domates - Brim Fiyat:#{tomatoPrice:F2}₺ Gramaj:#{tomatoGram:F2} Toplam Tutar:#{tomatoTotalPrice:F2}₺");

            //Console.WriteLine($"{"Alınan Ürün",-15} {"Birim Fiyat",-15} {"Gramaj",-7} {"Toplam Tutar"}");
            //Console.WriteLine(new string('-', 60));
            //Console.WriteLine($" # {"Elma",-alignmentWidth} {applePrice,alignmentWidth:F2}₺ {appleGram,alignmentWidth:F2} {appleTotalPrice,alignmentWidth:F2}₺");
            //Console.WriteLine($" # {"Portakal",-alignmentWidth} {orangePrice,alignmentWidth:F2}₺ {orangeGram,alignmentWidth:F2} {orangeTotalPrice,alignmentWidth:F2}₺");
            //Console.WriteLine($" # {"Çilek",-alignmentWidth} {strawberryPrice,alignmentWidth:F2}₺ {strawberryGram,alignmentWidth:F2} {strawberryTotalPrice,alignmentWidth:F2}₺");
            //Console.WriteLine($" # {"Patates",-alignmentWidth} {potatoPrice,alignmentWidth:F2}₺ {potatoGram,alignmentWidth:F2} {potatoTotalPrice,alignmentWidth:F2}₺");
            //Console.WriteLine($" # {"Domates",-alignmentWidth} {tomatoPrice,alignmentWidth:F2}₺ {tomatoGram,alignmentWidth:F2} {tomatoTotalPrice,alignmentWidth:F2}₺");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine($"-----Alışveriş Toplam Tutarı:{shoppingTotalPrice:F2} ₺"); ;



            #endregion

            #region Char Değişkenler
            ////ABCDEFGH
            ////DEF....
            ////TOPLANTI SAAT 20.00'DE
            ////"Strıngler cıft tırnak ıle tanımlanırken  char değişkenler ' ile tanımlanır.

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden veri girişleri, string değişkenler
            //Console.WriteLine("**** CSarp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();


            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict= Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu T.C Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();
            //Console.WriteLine(new string('-', 60));
            //Console.WriteLine("Yolcu TC Kimlik No:"+passengerIdentityNumber +" - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname+" Yolcu Adres: "+passengerDistrict+ "/" + passengerCity+" Yolcu Yaş:  "+passengerAge);




            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            ////ABC12D
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice +
            //chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine($"Toplam Ödemeniz Gereken Tutar: {totalPrice} ₺");

            #endregion

            #region Klavyeden girilen ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+result);
            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz(E/K): ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion
             
            Console.Read();
        }
    }
}
