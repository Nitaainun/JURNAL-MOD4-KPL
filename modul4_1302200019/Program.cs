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
        }
    }

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

}
