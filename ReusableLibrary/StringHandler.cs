using System;
using System.Collections.Generic;
using System.Text;

namespace ReusableLibrary
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
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
