using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
{
    class Program
    {

        static List<int> numbers=new List<int>();
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
                displayPrintByChoiceUser(choice);
            }
            else
            {
                insertNumbersByUser();
            }

        }
        //function that displays the menu 
        private static int Menu()
        {
            bool Exit = true;
            int choice = 0;
            do
            {

                Console.WriteLine("Please choose an option:\n" +
                    "if you want  input a Series ,enter 1 \n" +
                    "if you want display the series in the order it was entered enter 2 \n" +
                    "if you want display the series in the reversed order it was entered enter 3 \n" +
                    "if you want  display the series in sorted order enter 4 \n" +
                    "if you want display the Max value of the series enter 5\n" +
                    "if you want display the Min value of the series enter 6 \n" +
                    "if you want display the Average value of the series enter 7 \n" +
                    " if you want display the Number of elements in the series enter 8 \n" +
                    " if you want display the Sum of the series enter 9 \n" +
                    "if you want exit enter 10 ");
                choice = int.Parse(Console.ReadLine());

            } while (Exit);
            if (choice == 10) {
                Exit = false;
                Console.WriteLine("Goodbye");
            }
            return choice;
        }
        //fonction that displays the result according to the choice of the user
        private static void displayPrintByChoiceUser(int choice)
        {
            switch (choice)
            {
                case 1:
                    insertNumbersByUser();
                    break;
                case 2:
                    GetByInserted(numbers);
                    break;
                case 3:
                     GetNumbersReversed(numbers);
                    break;
                case 4:
                    GetNumbersSorted(numbers);
                    break;
                case 5:
                    GetMax(numbers);
                    break;
                case 6:
                    GetMin(numbers);
                    break;
                case 7:
                    GetAverage(numbers);
                    break;
                case 8:
                    GetCountNumbers(numbers);
                    break;
                case 9:
                    GetSum(numbers);
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;


            }
        }


        //function that receives numbers from the user
        private static void insertNumbersByUser()
        {
            Console.WriteLine("please enter numbers with spases between them");
            string input = Console.ReadLine();

            string[] inputByUser = insertToArr(input);
            IsValidateNums(inputByUser);

        }
         //function that converts the string to an array of strings
        private static string[] insertToArr(string input)
        {
            List<string> str = new List<string>();
            string word = "";
            foreach(char c in input)
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

        public static void GetByInserted(List<int> numbers) { }

        public static void GetAverage(List<int> numbers) { }
        public static void GetMax(List<int> numbers) { }


        public static void GetMin(List<int> numbers) { }
        public static void GetSum(List<int> numbers) { }

        public static void GetNumbersSorted(List<int> numbers) { }
        
        public static void GetNumbersReversed(List<int> numbers) { }
        public static void GetCountNumbers(List<int> numbers) { }

    }
}
