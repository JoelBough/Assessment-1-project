using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        ///Handles the reporting of the analysis
        ///Maybe have different methods for different formats of output?
        ///eg.   public void outputConsole(List<int>)
        public void Textoutput(List<int> values)
        {
            Console.WriteLine($"There are {values[0]} sentences");
            Console.WriteLine($"There are {values[1]} Vowels");
            Console.WriteLine($"There are {values[2]} Consonants");
            Console.WriteLine($"There are {values[3]} Upper case letters");
            Console.WriteLine($"There are {values[4]} Lower case letters");
            Console.WriteLine($"There are {values[3] + values[4]} Total letters");
        }

        public void Letteroutput(List<int> letter)
        {
            int a = 0;
            for (int i = 65; i < 91; i++)
            {
                Console.WriteLine($"Frequency of {(char)i} : {letter[a]}");//loops through each letter and outputs frequency
                a++;
            }
        }

        public void Wordoutput(List<string> words)
        {
            Console.WriteLine("The large words in this test are :");//outputs large words detected in text file
            for (int i = 0; i < words.Count - 1; i++)
            {
                Console.WriteLine(words[i]);   
            }
        }
    }
}
