using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Ext
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

    }

    public static class MyExtensions
    {
        public static string FirstLetterUpper(this string str)
        {
            string[] sentance = str.Split(' ');
            string final = "";
            foreach (var word in sentance)
            {
                final += word[0].ToString().ToUpperInvariant() + word.Substring(1) + " ";
            }
            return final;
        }
    }
}
