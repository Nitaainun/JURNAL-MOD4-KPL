using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan <long> penjumlahan = new Penjumlahan<long>();
            long a = 13;
            long b = 02; 
            long c = 20;
            penjumlahan.printAngka(jumlahTigaAngka);

        }
    }
<<<<<<< HEAD
    public class Penjumlahan<T>
    {
        private T jumlahTigaAngka;
        public Penjumlahan(T jumlahTigaAngka)
        {
            this.jumlahTigaAngka = jumlahTigaAngka;
        }
        public void printAngka(T jumlahTigaAngka)
        {
            Console.WriteLine("nim = " + jumlahTigaAngka) ;
        }

    }
=======

    public class SimpelDataBase<T>
    {
            private List<T>storeData;
            private List<DateTime>inputDates;

        public SimpleDataBase(List<T>storeData)
        {

        }
        public void AddNewData(T a)
        {
            this.storeData.Add(a);
        }
        public void PrintAllData()
        {
            Console.WriteLine();
        }

    }

>>>>>>> implementasi-generic-class
}
