using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
{
    internal class Validations
    {
       


       

         
        
        //function is valid and insert array of numbers
        public  bool IsValidateNums(string[] str)
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
                //numbers.Add(num);
                
            
            }
            return IsValid;

        }
    }
}
