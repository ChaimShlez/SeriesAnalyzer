using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
{
    class Program
    {

        static List<int> numbers;
        static void Main(string[] args)
        {
            bool IsValid = IsValidateNums(args);
            ManegerMenu(IsValid);
        }

        static void ManegerMenu(bool isValid)
        {
            if (isValid)
            {

                Menu();
            }
            else
            {
                insertNumbersByUser();
            }

        }
        //function that receives numbers from the user
        private static void insertNumbersByUser()
        {
            Console.WriteLine("please enter numbers with spases between them");
            string input = Console.ReadLine();
            string[] inputByUser=insertToArr(input);
            IsValidateNums(inputByUser);

        }
        
        //private static string[] insertToArr(string input)
        //{
        //    List<string> str = new List<string>();
        //    string word = "";
        //    foreach(char c in word)
        //    {
        //        if (c != ' ')
        //        {

        //            word += c;
        //        }
        //        else
        //        {
        //           str.Add(word);
        //            word = "";
        //        }
        //    }
        //    return str.ToArray();
        //}

        private static void Menu();



        //function is valid and insert array of numbers
        public static bool IsValidateNums(string[] str)
        {
            bool IsValid = true;
            if (str.Length < 3)
            {
                IsValid = false;

            }

            int num;
            for (int i = 0; i < str.Length; i++)
            {
                if (!int.TryParse(str[i], out num) && str[i] != " ")
                {
                    IsValid = false;
                    break;
                }
                numbers.Add(num);

            }
            return IsValid;

        }

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
