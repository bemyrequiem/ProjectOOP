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

        //Outputs the analysis in a list
        public void listOutput(List<int> list)
        {
            Console.WriteLine($"The text had:" +
                $"\n{list[0]} sentences," +
                $"\n{list[1]} vowels," +
                $"\n{list[2]} consonants," +
                $"\n{list[3]} uppercase letters," +
                $"\n{list[4]} lowercase letters.");
        }

        //Outputs the analysis in a table
        public void tableOutput(List<int> list)
        {
            Console.WriteLine($"Sentences  Vowels  Consonants  Uppercase  Lowercase\n" +
                $"    {list[0]}        {list[1]}         {list[2]}          {list[3]}        {list[4]}");
        }

        //Outputs the analysis in a readable sentence
        public void sentenceOutput(List<int> list)
        {
            Console.WriteLine($"The text had {list[1]} vowels and {list[2]} consonants," +
                $"it also had {list[3]} uppercase and {list[4]} lowercase letters and was made" +
                $"up of {list[0]} sentences in total.");
        }

        //Outputs the analysis to a file
        public void fileOutput(List<int> list)
        {
            string text = $"Sentences: {list[0]}\nVowels: {list[1]}\nConsonants: {list[2]}\nUppercase: {list[3]}\nLowercase: {list[4]}\n\n{reportLetterFreq(list)}";

            while (true)
            {
                Console.WriteLine("Where would you like the report to be saved to?\n");
                string file_path = Console.ReadLine();

                //Check to see if the user inputted a path with or without a backslash on the end
                if (file_path[file_path.Length - 1] == '\\')
                {
                    file_path += "report.txt";
                }
                else
                {
                    file_path += "\\report.txt";
                }

                //Tries to use the path to see if it exists
                try
                {
                    System.IO.File.WriteAllText(file_path, text);
                    break;
                }
                catch
                {
                    Console.WriteLine("That path does not exist.\n");
                }
            }
        }

        //Outputs the letter frequency
        public string reportLetterFreq(List<int> list)
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

            return letter_freq;
        }
    }
}
