using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeriesAnalyzer
{
    internal class InsertByUser
    {
       
        //function that receives numbers from the user
        public string[] insertNumbersByUser()
        {
            
            Console.WriteLine("please enter numbers with spases between them");
            string input = Console.ReadLine();

            string[] inputByUser = insertToArr(input);


            return inputByUser;

        }
        //function that converts the string to an array of strings
        static string[] insertToArr(string input)
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

    }
}
