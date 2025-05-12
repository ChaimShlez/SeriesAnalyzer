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
        //manegre menu
        static void ManegerMenu(bool isValid)
        {
            if (isValid)
            {

               int choice= Menu();
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
         //function that converts the string to an array of strings
        private static string[] insertToArr(string input)
        {
            List<string> str = new List<string>();
            string word = "";
            foreach(char c in word)
            {
                if (c != ' ')
                {

                    word += c;
                }
                else
                {
                   str.Add(word);
                    word = "";
                }
            }
            return str.ToArray();
        }
        //menu
        private static int Menu()
        {
            bool Exit = true;
            do
            {
                int choice=0;
                Console.WriteLine("Please choose an option:\n" +
                    "if you want  input a Series ,enter 1 \n" +
                    "if you want display the series in the order it was entered enter 2\n" +
                    "if you want display the series in the reversed order it was entered enter 3 \n" +
                    "if you want  display the series in sorted order enter 4 \n" +
                    "if you want display the Max value of the series enter 5\n" +
                    "if you want display the Min value of the series enter 6 \n" +
                    "if you want display the Average value of the series enter 7 \n" +
                    " if you want display the Number of elements in the series enter 8 \n" +
                    " if you want display the Sum of the series enter 9 \n" +
                    "if you want exit enter 10 ");
                choice = int.Parse(Console.ReadLine());

            } while(Exit);
            return choice;
        }



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
                if ((!int.TryParse(str[i], out num) && str[i] != " ")||num< 0)
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
