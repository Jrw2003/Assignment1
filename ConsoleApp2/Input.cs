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
            String[] lines = File.ReadAllLines(@"C:\Users\Josh-\Downloads\OOP file.txt");//i dont understand where to put the file so the file address doesnt have to change from person to person
            String[] parts = new String[] { };
            foreach (string line in lines)
            {
                parts = line.Split('*');//this makes it so as soon as it sees an "*" it will stop reading the rest of the text file
                if (parts.Length > 1)
                {
                    break;
                }
              //Console.WriteLine(line);
            }
            foreach (string part in parts)
            {
                Console.WriteLine(part);
                text = part;
            }

            return text;
        }
    }
}
//C:\Users\40006088\OneDrive - DN Colleges Group\Uni Work\OOP file.txt //this if my loaction of the text file while at uni