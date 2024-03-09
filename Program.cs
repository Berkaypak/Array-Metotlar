using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sınıfına_Ait_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 10, 20, 30, 40, 50 };
            int[] diziy = new int[10];
            dizi.CopyTo(diziy, 3);
            foreach (int i in diziy)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine("---------------");
            int[] dizi2 = { 10, 20, 30, 40, 50 };
            Console.WriteLine(Array.BinarySearch(dizi2, 20));  //4
            Console.WriteLine(Array.BinarySearch(dizi2, 50));   //4
            Console.WriteLine(Array.BinarySearch(dizi2, 35));  //-4
            Console.WriteLine(Array.BinarySearch(dizi2, 11)); //-2
            Console.WriteLine(Array.IndexOf(dizi2, 20));   //1
            Console.WriteLine(Array.IndexOf(dizi2, 40)); //3
            Console.WriteLine(Array.IndexOf(dizi2, 25)); //-1
            Console.WriteLine("----------------------");
            int[] dizi3 = { 40, 20, 50, 10, 30 };
            Array.Sort(dizi3);
            foreach (int j in dizi3)
            {
                Console.Write(j + "\t");
            }
            Console.WriteLine("-----------------");
            //  10 20 30 40 50
            int[] diziy3 = new int[10];
            Array.Copy(dizi3, diziy3, 4);
            foreach (int i in diziy3)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("---------------");
            int[] dizi4 = { 1, 2, 3, 4, 5 };
            int[] diziy4 = new int[10];
            Array.Copy(dizi4, 2, diziy4, 5, 1);
            foreach (int i in diziy4)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("-----------------");
            int[] dizi5 = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Array.Reverse(dizi5);
            foreach (int i in dizi5)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("----------------");
            int[] dizi6 = { 2, 4, 6, 8, 10 };
            Array.Clear(dizi6, 3, 2);
            foreach (int i in dizi6)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
