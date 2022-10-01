using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar3_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            // System.Collections namespaces 

            ArrayList liste = new ArrayList();
            liste.Add("ayse");
            liste.Add(2);
            liste.Add(true);
            liste.Add('s');


            // içersindeki verilere erişim

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //AddRange   bir diziyi tek seferde koleksiyonun içerisine eklemeye yarar..

            string[] renkler = { "kırmızı","sarı","yesil"};
            List<int> sayilar = new List<int>() { 1,8,3,7,9,92,5 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            // Sort

            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // BinarySearch

            Console.WriteLine(liste.BinarySearch(9));


            // Reverse

            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Clear

            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }





            Console.ReadLine();

        }
    }
}
