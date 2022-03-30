using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 31; i++)
            {
                values.Add(0);
            }

            foreach (char ch in input)
            {
                if (ch == '.')
                {
                    values[0] += 1;
                }

                if (vowels.Contains(ch))
                {
                    values[1] += 1;
                } 
                else
                {
                    values[2] += 1;
                }

                if (Char.IsUpper(ch))
                {
                    values[3] += 1;
                } 
                else
                {
                    values[4] += 1;
                }
            }

            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int count = 5;
            input = input.ToUpper();

            foreach (char letter in alpha)
            {
                values[count] = input.Length - input.Replace(letter.ToString(), "").Length;
                input = input.Replace(letter.ToString(), "");
                count++;
            }

            return values;
        }
    }
}
