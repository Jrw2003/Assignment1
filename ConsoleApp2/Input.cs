using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("what would you like to input?");
            text = Console.ReadLine();// this allows the user to input any piece of text they like
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput()
        {

            text = File.ReadAllText(@"C:\Users\40006088\OneDrive - DN Colleges Group\Uni Work\OOP file.txt");//this reads all of the text file
            return text;
        }
    }
}
