using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void ManegerMenu(bool isValid);
        

        private static void insertNumbersByUser();
       

        private static void Menu();
        


        //function is valid
        public static bool ValidateNums(string[] args);

        public void GetByInserted(int[] nums);

        public void GetAverage(int[] nums);
        public void GetMax(int[] nums);

        public void GetMin(int[] nums);
        public void GetSum(int[] nums);

        public void GetNumbersSorted(int[] nums);
        public void GetNumbersSorted(int[] nums);
        public void GetNumbersReversed(int[] nums);
        public void GetCountNumbers(int[] nums);

    }
}
