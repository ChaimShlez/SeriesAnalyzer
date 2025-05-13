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

         //maneger prosses
        static void Main(string[] args)
        {

            //create class insertByUser

            InsertByUser insertByUser = new InsertByUser();
            //create class validations
            Validations validations = new Validations();

            //create class menu and pass the insertByUser to it
            Menu menu = new Menu(insertByUser);
            //Analize analize = new Analize(menu);
            //
            bool IsValid =validations.IsValidateNums(args);

            //loop maneger menu
            while (!IsValid)
            {
                
                
                 string[] arrStrByUser = insertByUser.insertNumbersByUser();

                 IsValid = validations.IsValidateNums(arrStrByUser);

                if (IsValid)
                {

                   menu.ConvertToInt(arrStrByUser);
                    break;
                   
                }
            }
        }
        

    }
}