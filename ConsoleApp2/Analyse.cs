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
        public int analyseText(string text)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
           
            
            string myStr;
            int i, len, sent_count, vowel_count, cons_count, upperCase_count, lowerCase_count;
            myStr = text;
            sent_count = 0;//these set the values to 0
            vowel_count = 0;
            cons_count = 0;
            upperCase_count = 0;
            lowerCase_count = 0;
            // find length
            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == '.')
                {//this counts the sentences
                    sent_count++;
                }

                else if(myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {//this counts the vowels
                    vowel_count++;
                }
                else if(myStr[i] == 'b' || myStr[i] == 'c' || myStr[i] == 'd' || myStr[i] == 'f' || myStr[i] == 'g' || myStr[i] == 'h' || myStr[i] == 'j' || myStr[i] == 'k' || myStr[i] == 'l' || myStr[i] == 'm' || myStr[i] == 'n' || myStr[i] == 'p' || myStr[i] == 'q' || myStr[i] == 'r' || myStr[i] == 's' || myStr[i] == 't' || myStr[i] == 'v' || myStr[i] == 'w' || myStr[i] == 'x' || myStr[i] == 'y' || myStr[i] == 'z' ||
                    myStr[i] == 'B' || myStr[i] == 'C' || myStr[i] == 'D' || myStr[i] == 'F' || myStr[i] == 'G' || myStr[i] == 'H' || myStr[i] == 'J' || myStr[i] == 'K' || myStr[i] == 'L' || myStr[i] == 'M' || myStr[i] == 'N' || myStr[i] == 'P' || myStr[i] == 'Q' || myStr[i] == 'R' || myStr[i] == 'S' || myStr[i] == 'T' || myStr[i] == 'V' || myStr[i] == 'W' || myStr[i] == 'X' || myStr[i] == 'Y' || myStr[i] == 'Z')
                {//this counts the consonants
                    cons_count++;
                }

                else if(myStr[i] == 'b' || myStr[i] == 'c' || myStr[i] == 'd' || myStr[i] == 'f' || myStr[i] == 'g' || myStr[i] == 'h' || myStr[i] == 'j' || myStr[i] == 'k' || myStr[i] == 'l' || myStr[i] == 'm' || myStr[i] == 'n' || myStr[i] == 'p' || myStr[i] == 'q' || myStr[i] == 'r' || myStr[i] == 's' || myStr[i] == 't' || myStr[i] == 'v' || myStr[i] == 'w' || myStr[i] == 'x' || myStr[i] == 'y' || myStr[i] == 'z' || myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u')
                {//this counts the lower case letters
                    lowerCase_count++;
                }

                else if(myStr[i] == 'B' || myStr[i] == 'C' || myStr[i] == 'D' || myStr[i] == 'F' || myStr[i] == 'G' || myStr[i] == 'H' || myStr[i] == 'J' || myStr[i] == 'K' || myStr[i] == 'L' || myStr[i] == 'M' || myStr[i] == 'N' || myStr[i] == 'P' || myStr[i] == 'Q' || myStr[i] == 'R' || myStr[i] == 'S' || myStr[i] == 'T' || myStr[i] == 'V' || myStr[i] == 'W' || myStr[i] == 'X' || myStr[i] == 'Y' || myStr[i] == 'Z' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {//this counts the upper case letters 
                    upperCase_count++;
                }

            }//these display the results
            Console.Write("\nSentences in the string: {0}\n", sent_count);
            Console.Write("\nVowels in the string: {0}\n", vowel_count);
            Console.Write("\nConsonants in the string: {0}\n", cons_count);
            Console.Write("\nUpper case letters in the string: {0}\n", upperCase_count);
            Console.Write("\nLower case letters in the string: {0}\n", lowerCase_count);
            return 1;
        }
    }
}
