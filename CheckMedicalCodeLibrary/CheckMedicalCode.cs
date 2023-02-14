using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMedicalCodeLibrary
{
    public class CheckMedicalCodeClass
    {
        public bool CheckMedicalCode(string textString)
        {
            if (string.IsNullOrEmpty(textString) || textString.Length != 10) return false;
            int sum = 0;
            int result = 0;
            textString = textString.Replace("-", "");
            textString = textString.Replace(" ", "");
            for (int i = 0; i < textString.Length - 2; i++)
            {
                int a = textString[i];

                for (int j = 9; j > 0; j--)
                {
                    sum += a * j;
                }
            }
            if (sum < 100)
            {
                result = sum;
            }
            else if (sum == 100 || sum == 101)
            {
                result = 00;
            }
            else if (sum > 101)
            {
                result = sum % 101;
            }

            if (result == Convert.ToInt32(textString[9] + textString[10]))
            {
                return true;
            }
            return false;
        }
    }
}
