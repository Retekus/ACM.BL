using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retekus.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// inserts spaces before every Capital letter in a string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string inputString)
        {
            var result = string.Empty;
            if (!string.IsNullOrWhiteSpace(inputString))
            {
                foreach(char letter in inputString)
                {
                    if (char.IsUpper(letter)) { result = result.Trim(); result += " "; }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
