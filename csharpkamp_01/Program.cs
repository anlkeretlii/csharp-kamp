﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpkamp_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdirma komutlari
            //Console.WriteLine("Hello World!");
            //Console.Write("Hello");

            //Console.WriteLine("Food Categories");
            //Console.WriteLine();
            //Console.WriteLine("1-Soup");
            //Console.WriteLine("2-Main Dishes");
            //Console.WriteLine("3-Snacks");
            //Console.WriteLine("4-Salad");
            //Console.WriteLine("5-Desserts");
            //Console.WriteLine("6-Drinks");
            //Console.WriteLine();
            //Console.WriteLine("Food Categories");
            #endregion

            #region string variables
            // Değişken_Türü Değişken_Adı;

            //string name;
            //name = "Anıl";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Anıl Engin";
            //customerSurname = "Keretli";
            //customerPhone = "numaram";
            //customerEmail = "emailim";
            //district = "Maltepe";
            //city = "İstanbul";

            //Console.WriteLine("Rezervasyon Kartı");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
         

            
            #endregion

            #region int variables

            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("Menü Fiyatı");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            //Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            //Console.WriteLine("Kızartma: " + friesPrice + " TL");
            //Console.WriteLine("Cola: " + cokePrice + " TL");
            //Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            //Console.WriteLine("Su: " + waterPrice + " TL");
            //Console.WriteLine("---------------------------------");

            //Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("---------------------------------");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

           Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
            #endregion

            Console.Read();
        }
    }
}

