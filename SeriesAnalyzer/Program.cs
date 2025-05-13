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
       static List<int> numbers = new List<int>();
        //maneger prosses
        static void Main(string[] args)
        {

           
            
            bool IsValid =IsValidateNums(args);

            //loop maneger menu
            
                ManegerMenu(IsValid);

        }


        //function that checks if the numbers are valid and if yes, it calls the menu 
        public static void ManegerMenu(bool IsValid)
        {
            while (!IsValid)
            {
                string[] strUser = insertNumbersByUser();
                IsValid = IsValidateNums(strUser);
            }

            bool exitProgram = DisplayMenu();

            if (exitProgram)
            {
                return; 
            }
        }


       

        //function that receives numbers from the user
        public static string[] insertNumbersByUser()
        {

            Console.WriteLine("please enter numbers with spases between them");
            string input = Console.ReadLine();

            string[] inputByUser = insertToArr(input);


            return inputByUser;

        }
        //function that converts the string to an array of strings
        static  string[] insertToArr(string input)
        {
            List<string> str = new List<string>();
            string word = "";
            foreach (char c in input)
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

        //function that checks if the numbers are valid and if yes ,add to the list
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
                if ((!int.TryParse(str[i], out num) && str[i] != " ") || num < 0)
                {
                    IsValid = false;
                    break;
                }
               numbers.Add(num);



            }
            return IsValid;

        }
        //function that displays the menu and call functions according to user choice with switch case
        static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose an option:\n" +
                    "if you want  input a Series ,enter 1\n" +
                    "if you want display the series in the order it was entered enter 2\n" +
                    "if you want display the series in the reversed order it was entered enter 3\n" +
                    "if you want  display the series in sorted order enter 4\n" +
                    "if you want display the Max value of the series enter 5\n" +
                    "if you want display the Min value of the series enter 6 \n" +
                    "if you want display the Average value of the series enter 7\n" +
                    "if you want display the Number of elements in the series enter 8 \n" +
                    "if you want display the Sum of the series enter 9\n" +
                    "if you want exit enter 10 ");

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        numbers.Clear();
                        string[] strUser = insertNumbersByUser();
                        bool isValid = IsValidateNums(strUser);
                       ManegerMenu(isValid);
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
                    case 10:
                        Console.WriteLine("Goodbye");
                        return true;
                        //break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 10");
                        break;
                }
            }
        }

        //function that displays the series in the order it was entered
        public static void GetByInserted(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                printNumByChoice(number);
            }
        }
        //function that displays the series in avarage
        public static void GetAverage(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            int average = sum / numbers.Count;
            printNumByChoice(average);
        }

        //function that displays the series max
        public static void GetMax(List<int> numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            printNumByChoice(max);
        }

        //function that displays the series min
        public static void GetMin(List<int> numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            printNumByChoice(min);
        }


        //function that displays the series sum
        public static void GetSum(List<int> numbers)
        {

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            printNumByChoice(sum);
        }
        // function that sorts 
        public static void GetNumbersSorted(List<int> numbers)
        {
            List<int> sortSrr = new List<int>(numbers);

            for (int i = 0; i < sortSrr.Count; i++)
            {
                for (int j = i + 1; j < sortSrr.Count; j++)
                {
                    if (sortSrr[i] > sortSrr[j])
                    {
                        int temp = sortSrr[i];
                        sortSrr[i] = sortSrr[j];
                        sortSrr[j] = temp;
                    }

                }

            }
            printArrSorted(sortSrr);
        }

        //function that displays the series after sorting
        private static void printArrSorted(List<int> sortSrr)
        {
            foreach (int number in sortSrr)
            {
                printNumByChoice(number);
            }
        }

        //function that displays the series in the reversed 
        public static void GetNumbersReversed(List<int> numbers)
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                printNumByChoice(numbers[i]);
            }
        }

        //function that displays the  count number of elements in the series
        public static void GetCountNumbers(List<int> numbers)
        {
            printNumByChoice(numbers.Count);
        }


        //function that prints
        public static void printNumByChoice(int num)
        {

            Console.Write($"{num} , ");

        }

    }
}
        

    
