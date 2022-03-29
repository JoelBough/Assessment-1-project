using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class AnalyseString
    {
        ///Handles the analysis of text
        ///Method: analyseText
        ///Arguments: string
        ///Returns: list of integers
        ///Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            List<int> measurement = new List<int>();

            for(int i = 0; i<6; i++)
            {
                measurement.Add(0);
            }


            //1. Number of sentences
            string[] sentence = input.Split(".");
            measurement[0] = sentence.Length - 1;

            //2. Number of vowels
            int vowelcount = 0;
            string[] vowels = {"A", "E", "I", "O", "U"};
            for (int v = 0; v < 5; v++)//loops through array of vowels and searches in text, adding frequency to vowelcount
            {
                string[] vowel = input.ToUpper().Split(vowels[v]);
                vowelcount = vowelcount + vowel.Length -1;
            }
            measurement[1] = vowelcount;
            

            //3. Number of consonants
            int conscount = 0;
            for(int c = 65; c<91; c++)// counts every character and removes the vowels
            {
                string[] cons = input.ToUpper().Split((char)c);
                conscount = conscount + cons.Length - 1;
            }
            conscount = conscount - vowelcount;
            measurement[2] = conscount;
        
            //4. Number of upper case letters
            int upper = 0;
            for (int u = 65; u < 91; u++)//loops through and counts every upper case character
            {
                string[] up = input.Split((char)u);
                upper = upper + up.Length - 1;
            }
            measurement[3] = upper;

            //5. Number of lower case letters
            int l = 0;
            int lower = 0;
            for (l = 97; l < 123; l++)//loops through and counts every lower case character
            {
                string[] low = input.Split((char)l);
                lower = lower + low.Length - 1;
            }
            measurement[4] = lower;

            //Letter breakdown
           

            return measurement;
        }

        public List<int> countletters(string s)
        {
            List<int> quantity = new List<int>();
            for (int i = 65; i < 91; i++)//loops through upper case letters and counts how many of each there are, adding to total
            {
                int freq = 0;
                string[] letters = s.ToUpper().Split((char)i);
                freq = letters.Length - 1;
                quantity.Add(freq);
            }
            return quantity;
        }

        //Method for getting words above 7 letters or above
        public List<string> LongWords(string s)
        {
            List<string> LongW = new List<string>();

            string[] words = s.Split(' ');//splitting text into substrings as individual words
            foreach (string word in words)
            {
                char end = word[word.Length - 1];
                if (end == (char)46 || end == (char)44)//commas and full stops can be attatched to words so removes them before counting letters
                {
                    if (word.Length > 8)
                    {
                        string word2 = word.Remove(word.Length - 1, 1);//if comma or full stop, creates clone, removes it and adds word to list
                        Console.WriteLine(word2);
                        Console.WriteLine(word2);
                        LongW.Add(word2);
                    }
                }
                else if (word.Length > 7)
                {
                    LongW.Add(word);
                }
            }
            return LongW;
        }


    }
}
