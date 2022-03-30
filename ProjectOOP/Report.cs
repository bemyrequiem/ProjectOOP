using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void listOutput(List<int> list)
        {
            Console.WriteLine($"The text had:" +
                $"\n{list[0]} sentences," +
                $"\n{list[1]} vowels," +
                $"\n{list[2]} consonants," +
                $"\n{list[3]} uppercase letters," +
                $"\n{list[4]} lowercase letters.");
        }

        public void tableOutput(List<int> list)
        {
            Console.WriteLine($"Sentences  Vowels  Consonants  Uppercase  Lowercase\n" +
                $"    {list[0]}        {list[1]}         {list[2]}           {list[3]}          {list[4]}");
        }

        public void sentenceOutput(List<int> list)
        {
            Console.WriteLine($"The text had {list[1]} vowels and {list[2]} consonants," +
                $"it also had {list[3]} uppercase and {list[4]} lowercase letters and was made" +
                $"up of {list[0]} sentences in total.");
        }

        public void reportLetterFreq(List<int> list)
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letter_freq = "";
            int count = 0;

            foreach (char letter in alpha)
            {
                if (count % 10 == 0)
                {
                    letter_freq += "\n";
                }

                letter_freq += $"{letter.ToString()}: {list[count + 5]}    ";
                count++;
            }

            Console.WriteLine(letter_freq);
        }
    }
}
