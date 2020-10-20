using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_FajlIrasa_Ciklussal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generáljunk le 100 db háromjegyű véletlenszámot, majd azokat vesszővel elválasztva
            //írjuk ki egy "velszam.txt" nevű állományba vesszőkkel elválasztva, úgy
            //hogy egy sorba 10 db szám kerüljön.

            int[] szamok = new int[100];
            Random rnd = new Random();

            string file = "velszam.txt";
            StreamWriter sw = new StreamWriter(file);

            string sor = "";
            for(int i = 1;i<=100;i++)
                {
                szamok[i-1] = rnd.Next(100, 1000);


                #region sor létrehozása 1. változat
                /*
                 //Ha 9 elemet már a sorba tettünk, akkor a tizediket
                 //már vessző nélkül rakjuk a végére, majd kiírjuk a 
                 //képernyőre és a fájlba. Végül "lenullázuk" a sorunkat!
                if (i % 10 == 0)
                {                    
                    sor = sor + szamok[i - 1];
                    Console.WriteLine(sor);
                    sor = "";
                }
                else
                //Ha még nem generáltunk le 10 elemet, akkor hozzáadjuk a sorhoz
                //vesszővel
                {
                    sor = sor + szamok[i - 1] + ",";
                }
                */
                #endregion


                #region sor létrehozása 2. változat

                //Felépítjük a sor, mindig hozzáadjuk a következő elemet 
                //ÉS egy vesszőt is. Azért i-1 az index, mert a ciklusunk
                //1-től indult, hogy egyszerűbben tudjuk figyelni, ha 
                //10 számot már legeneráltunk!
                sor = sor + szamok[i - 1] + ",";

                if (i % 10 == 0)
                {
                    //Ha 10 elemet már a sorba tettünk, akkor levágjuk
                    //a végéről a vesszőt, majd kiírjuk a képernyőre és a 
                    //fájlba. Végül "lenullázuk" a sorunkat!
                    sor = sor.TrimEnd(',');
                    Console.WriteLine(sor);
                    sw.WriteLine(sor);
                    sor = "";
                }
                #endregion


            }

            sw.Close();

            Console.ReadLine();

        }
    }
}
