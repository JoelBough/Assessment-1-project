using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class AnalyseString
    {
        //Handles the analysis of text

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
            int v = 0;
            int vowelcount = 0;
            string[] vowels = {"A", "E", "I", "O", "U"};
            for (v = 0; v < 5; v++)
            {
                string[] vowel = input.ToUpper().Split(vowels[v]);
                vowelcount = vowelcount + vowel.Length -1;
            }
            measurement[1] = vowelcount;
            

            //3. Number of consonants
            int c = 0;
            int conscount = 0;
            //65-90
            for(c = 65; c<90; c++)
            {
                string[] cons = input.ToUpper().Split((char)c);
                conscount = conscount + cons.Length - 1;
            }
            conscount = conscount - vowelcount;
            measurement[2] = conscount;
        
            //4. Number of upper case letters
            int u = 0;
            int upper = 0;
            for (u = 65; u < 90; u++)
            {
                string[] up = input.Split((char)u);
                upper = upper + up.Length - 1;
            }
            measurement[3] = upper;

            //5. Number of lower case letters
            int l = 0;
            int lower = 0;
            for (l = 97; l < 122; l++)
            {
                string[] low = input.Split((char)l);
                lower = lower + low.Length - 1;
            }
            measurement[4] = lower;


            return measurement;
        }
    }
}
