using System;

namespace Retekus.Main
{
    public class StringHandler
    {
        public string InsertSpaces(string inputString)
        {
            var result = string.Empty;

            if (!String.IsNullOrWhiteSpace(inputString))
            {
                foreach(char letter in inputString)
                {
                    if (char.IsUpper(letter)) result += " ";
                    result += letter;
                }
            }
            return result;
        }
    }
}
