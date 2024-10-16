using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü

            ///Foreach(1;2;3;4)
            ///1:Değişken türü
            ///2:Değişken adı
            ///3:In
            ///4:Liste,Koleksiyon,Dizi
            ///

            //string[] cities ={"milano","istanbul","roma","budapeşte","ankara","varşova"};

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}
            //*****************************************
            //int[] numbers = { 10, 21, 312, 445, 55, 66, 27, 2018, };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //*****************************************
            //int[] numbers = { 10, 21, 312, 445, 55, 66, 27, 2018, };
            //foreach (int number in numbers) 
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //*****************************************
            //int[] numbers = { 10, 21, 312, 445, 55, 66, 27, 2018, };
            //int total = 0;
            //foreach (int i in numbers) 
            //{   
            //    total += i;
            //}
            //Console.WriteLine(total);
            //*****************************************
            //List<int> numbers = new List<int>()
            //{ 1, 2, 3,5,6,7,8};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //*****************************************
            //string word = "Merhaba";
            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek sınav sistemi uygulaması

            //*****************************************
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan alma işlemi
            Console.WriteLine("-------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            
            int studentCount= int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames =new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                
                //Her öğrenci için 3 sınav notu girişi
                for(int j=0;j<3;j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult+= value;// notları topluyoruz...
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult/3;
            }
            //öğrencinin ortalaması
            for (int i=0;i<studentCount;i++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]:F2}");
                //:F2 ondalık haneyi 2 basamak ile sınırlar

                //öğrencilerin gecip kalma durumları

                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("-------------------------") ;
            }
            //*****************************************

            //*****************************************

            //*****************************************

            //*****************************************

            //*****************************************
            #endregion
            Console.Read();
        }
    }
}
