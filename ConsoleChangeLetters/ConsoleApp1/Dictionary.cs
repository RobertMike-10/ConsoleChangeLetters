using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ConsoleApp1
{
    class Dictionary
    {       

        static string[] letters = {"A","B","C","D","E","F","G","H","I","J","K",
                  "L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        static Dictionary<int, string> dicLetters = new Dictionary<int, string>();
        static Dictionary<string,int> dicLetter = new Dictionary<string, int>();
        public static void initializeDictionary()
        {
            if (dicLetters.Count ==0 )
            {
                int position = 1;
                foreach (string letter in letters)
                {
                    dicLetters.Add(position, letter);
                    position++;
                }
            }
            if (dicLetter.Count == 0)
            {
                int position = 1;
                foreach (string letter in letters)
                {
                    dicLetter.Add( letter,position);
                    position++;
                }
            }
        }

        public static string letterConvertion(char letter)
        {

            if (Char.IsLetter(letter))
            {
                return dicLetters.FirstOrDefault(x => x.Value == letter.ToString().ToUpper()).Key.ToString();
            }
            else
                return letter.ToString();
        }

        public static string letterConvertToNumber(char letter)
        {

            if (Char.IsLetter(letter))
            {
                return dicLetter[letter.ToString().ToUpper()].ToString();
            }
            else
                return letter.ToString();
        }
        public static string StringChallenge(string str)
        {
            initializeDictionary();          
            string res="";
            
            foreach (char letter in str)
            {                
                res += letterConvertion(letter);
            }
            return res;

        }

        public static string StringToNumber(string str)
        {
            initializeDictionary();
            string res = "";

            foreach (char letter in str)
            {
                res += letterConvertToNumber(letter);
            }
            return res;

        }

        static void Main()
        {
            // keep this function call here

            //Console.WriteLine(StringChallenge(Console.ReadLine()));
            Console.WriteLine(StringToNumber(Console.ReadLine()));
        }

    }
}

