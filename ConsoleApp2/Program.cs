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
        static void Main(string[] args)
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            string text = "";
            Console.WriteLine("Do you want to manually input a peace of text or use the already created text file?(write manually or textfile)");// this asks the user to choose between inputting manually or using a prewritten text file
            string choose = Console.ReadLine(); // this allows the user to choose between inputting manually or using a prewritten text file
            if (choose == "manually")// if the user input "manually" then this piece of code will run
            {
              //Console.WriteLine(input.manualTextInput());
                text = input.manualTextInput();
            }    
            else if (choose == "textfile")// if the user input "textfile" then this piece of code will run
            {
              //Console.WriteLine(input.fileTextInput());
                text = input.fileTextInput();
            }
            else// if the user input anything other than "manually" or "textfile" then this piece of code will run
            {
                Console.WriteLine("Error you did choose one of the two choices.");
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse();
            Console.WriteLine(analyse.analyseText(text));//this should count all the vowels, consonants, upper and lower case and the amount of sentences and print the result. 
            //Receive a list of integers back


            //Report the results of the analysis
         //this is done in the Analyse tab

            //TO ADD: Get the frequency of individual letters?


        }



    }
}
