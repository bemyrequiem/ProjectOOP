//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            var input = new Input();

            //Get either manually entered text, or text from a file
            string text = "";
            string option = "";
            while (true)
            {
                Console.WriteLine("Do you want to enter some text or read from a file?\n" +
                    "1. Manual Enter\n2. File Read\n");
                option = Console.ReadLine();
                Console.WriteLine("");

                if (option == "1")
                {
                    text = input.manualTextInput();
                    break;
                }
                else if (option == "2")
                {
                    Console.WriteLine("What is the path of the file?\n");
                    string filename = Console.ReadLine();
                    try
                    {
                        text = input.fileTextInput(filename);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\nThat path is invalid.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.\n");
                }
            }

            //Create an 'Analyse' object
            var analyse = new Analyse();

            //Pass the text input to the 'analyseText' method
            var analysedText = analyse.analyseText(text);
            //Receive a list of integers back

            //Create a 'Report' object
            var report = new Report();

            //Report the results of the analysis
            while (true)
            {
                Console.WriteLine("\nWhich format would you like the analysis to be displayed in?" +
                    "\n1. List\n2. Table\n3. Sentence\n4. File\n");
                option = Console.ReadLine();
                Console.WriteLine("");

                if (option == "1")
                {
                    report.listOutput(analysedText);
                    break;
                }
                else if (option == "2")
                {
                    report.tableOutput(analysedText);
                    break;
                }
                else if (option == "3")
                {
                    report.sentenceOutput(analysedText);
                    break;
                }
                else if (option == "4")
                {
                    report.fileOutput(analysedText);
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }

            //TO ADD: Get the frequency of individual letters?
            Console.WriteLine("\nWould you like to view the letter frequency? (y/n)\n");
            option = Console.ReadLine();

            if (option == "y")
            {
                Console.WriteLine(report.reportLetterFreq(analysedText));
                Console.ReadLine();
            }
        }
    }
}
