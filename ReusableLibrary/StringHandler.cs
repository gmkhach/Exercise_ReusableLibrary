using System;
using System.Collections.Generic;
using System.Text;

namespace ReusableLibrary
{
    public static class StringHandler
    {
        // Inserts a space before every upper case character in a string, except the first character
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if(!string.IsNullOrEmpty(source))
            {
                foreach (char ch in source)
                {
                    if(char.IsUpper(ch))
                    {
                        // if there is a space here already, trim it
                        result = result.Trim();
                        result += " ";
                    }
                    result += ch;
                }
                result = result.Trim();
            }
            return result;
        }
    }
}
