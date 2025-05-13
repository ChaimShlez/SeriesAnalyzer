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

        //static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            InsertByUser insertByUser = new InsertByUser();
            Validations validations = new Validations();
            Menu menu = new Menu(insertByUser);

            bool IsValid =validations.IsValidateNums(args);

           
            while (!IsValid)
            {
                
                
                   string[] arrStrByUser = insertByUser.insertNumbersByUser();
                 IsValid = validations.IsValidateNums(arrStrByUser);

                if (IsValid)
                {

                   menu.ConvertToInt(arrStrByUser);
                    break;
                    //displayPrintByChoiceUser(choice);
                }
            }
        }
        //manegre menu
        // void ManegerMenu(bool isValid)
        //{
        //    if (isValid)
        //    {

        //        Menu();
        //        //displayPrintByChoiceUser(choice);
        //    }
        //    else
        //    {
        //        string[] strByUser= insertNumbersByUser();
        //        bool IsValid = validations.IsValidateNums(strByUser);
        //    }

        //}
        //function that displays the menu 
        //static void Menu()
        //{
        //    bool Exit = true;
        //    int choice = 0;
        //    do
        //    {

        //        Console.WriteLine("Please choose an option:\n" +
        //            "if you want  input a Series ,enter 1 \n" +
        //            "if you want display the series in the order it was entered enter 2 \n" +
        //            "if you want display the series in the reversed order it was entered enter 3 \n" +
        //            "if you want  display the series in sorted order enter 4 \n" +
        //            "if you want display the Max value of the series enter 5\n" +
        //            "if you want display the Min value of the series enter 6 \n" +
        //            "if you want display the Average value of the series enter 7 \n" +
        //            " if you want display the Number of elements in the series enter 8 \n" +
        //            " if you want display the Sum of the series enter 9 \n" +
        //            "if you want exit enter 10 ");
        //        choice = int.Parse(Console.ReadLine());

        //        if (choice == 10)
        //        {
        //            Exit = false;
        //            Console.WriteLine("Goodbye");
        //        }
        //        displayPrintByChoiceUser(choice);
        //    } while (Exit);


        //}
        ////fonction that displays the result according to the choice of the user
        //static void displayPrintByChoiceUser(int choice)
        //{
        //    switch (choice)
        //    {
        //        case 1:
        //            insertNumbersByUser();
        //            break;
        //        case 2:
        //            GetByInserted(numbers);
        //            break;
        //        case 3:
        //            GetNumbersReversed(numbers);
        //            break;
        //        case 4:
        //            GetNumbersSorted(numbers);
        //            break;
        //        case 5:
        //            GetMax(numbers);
        //            break;
        //        case 6:
        //            GetMin(numbers);
        //            break;
        //        case 7:
        //            GetAverage(numbers);
        //            break;
        //        case 8:
        //            GetCountNumbers(numbers);
        //            break;
        //        case 9:
        //            GetSum(numbers);
        //            break;

        //        default:
        //            Console.WriteLine("Goodbye");
        //            break;


        //    }
        //}


        //function that receives numbers from the user
        //static void insertNumbersByUser()
        //{
        //    numbers.Clear();
        //    Console.WriteLine("please enter numbers with spases between them");
        //    string input = Console.ReadLine();

        //    string[] inputByUser = insertToArr(input);
        //    Console.WriteLine(inputByUser);
        //    bool IsValid = IsValidateNums(inputByUser);
        //    ManegerMenu(IsValid);
        //}
        //function that converts the string to an array of strings
        //static string[] insertToArr(string input)
        //{
        //    List<string> str = new List<string>();
        //    string word = "";
        //    foreach (char c in input)
        //    {
        //        if (c != ' ')
        //        {

        //            word += c;
        //        }
        //        else
        //        {
        //            str.Add(word);
        //            word = "";
        //        }
        //    }
        //    return str.ToArray();
        //}





        //function is valid and insert array of numbers
        //public static bool IsValidateNums(string[] str)
        //{
        //    bool IsValid = true;
        //    if (str.Length < 3)
        //    {
        //        IsValid = false;

        //    }

        //    int num;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if ((!int.TryParse(str[i], out num) && str[i] != " ") || num < 0)
        //        {
        //            IsValid = false;
        //            break;
        //        }
        //        numbers.Add(num);

        //    }
        //    return IsValid;

        //}

        //public static void GetByInserted(List<int> numbers)
        //{
        //    foreach (int number in numbers)
        //    {
        //        printNumByChoice(number);
        //    }
        //}

        //public static void GetAverage(List<int> numbers)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        sum += number;
        //    }

        //    int average = sum / numbers.Count;
        //    printNumByChoice(average);
        //}
        //public static void GetMax(List<int> numbers)
        //{
        //    int max = numbers[0];
        //    for (int i = 1; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] > max)
        //        {
        //            max = numbers[i];
        //        }
        //    }
        //    printNumByChoice(max);
        //}


        //public static void GetMin(List<int> numbers)
        //{
        //    int min = numbers[0];
        //    for (int i = 1; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] < min)
        //        {
        //            min = numbers[i];
        //        }
        //    }
        //    printNumByChoice(min);
        //}
        //public static void GetSum(List<int> numbers)
        //{

        //    int sum = 0;

        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    printNumByChoice(sum);
        //}

        //public static void GetNumbersSorted(List<int> numbers)
        //{
        //    List<int> sortSrr = new List<int>(numbers);

        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        for (int j = i + 1; j < numbers.Count; j++)
        //        {
        //            if (numbers[i] > numbers[j])
        //            {
        //                int temp = numbers[i];
        //                numbers[i] = numbers[j];
        //                numbers[j] = temp;
        //            }

        //        }

        //    }
        //    printArrSorted(sortSrr);
        //}

        //private static void printArrSorted(List<int> sortSrr)
        //{
        //    foreach (int number in sortSrr)
        //    {
        //        printNumByChoice(number);
        //    }
        //}

        //public static void GetNumbersReversed(List<int> numbers)
        //{
        //    for (int i = numbers.Count - 1; i >= 0; i--)
        //    {
        //        printNumByChoice(numbers[i]);
        //    }
        //}
        //public static void GetCountNumbers(List<int> numbers)
        //{
        //    printNumByChoice(numbers.Count);
        //}



        //public static void printNumByChoice(int num)
        //{

        //    Console.WriteLine(num);
        //}

    }
}