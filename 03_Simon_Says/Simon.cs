using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string v)
        {
            return v;
        }

        internal string Shout(string v)
        {
            return  v.ToUpper();
        }

        internal string Repeat(string v)
        {
            return v + " " + v;
        }
        internal object Repeat(string v1, int v2)
        {
            string returnstring = "";
            for (int i = 0; i < v2; i++)
            {
                if (i == v2 - 1) returnstring = returnstring + v1;
                else returnstring = returnstring + v1 + " ";
            }
            return returnstring;
        }

        internal string StartOfWord(string v1, int v2)
        {
            return v1.Substring(0,v2);
        }

        internal string FirstWord(string v)
        {
            string[] Array = v.Split(' ');
            return Array[0];
        }

        internal string Titleize(string v)
        {
            string[] Array = v.Split(' ');
            string returnString = "";
            foreach (string i in Array)
            {
                if (i == "the" || i == "over" || i == "and")
                {
                    returnString = returnString + i + " ";
                }
                else returnString = returnString + i[0].ToString().ToUpper() + i.Substring(1, i.Length - 1) + " ";
            }
            return returnString.Substring(0,returnString.Length-1);
        }
    }
}