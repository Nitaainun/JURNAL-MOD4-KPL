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
            Penjumlahan <long> penjumlahan = new Penjumlahan<long>(T);
            long nim = 13 + 02 + 20;
            nim.printAngka(nim);

        }
    }
    public class Penjumlahan<T>
    {
        private T jumlahTigaAngka;
        public Penjumlahan(T jumlahTigaAngka)
        {
            this.jumlahTigaAngka = jumlahTigaAngka;
        }
        public void printAngka(T nim)
        {
            Console.WriteLine(nim);
        }

    }
}
