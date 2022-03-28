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
            InputChoice();
        }

        //Create 'Input' object
        static void InputChoice()
        {
            bool valid = false;
            string choice = "";
            Input t = new Input();
            Input f = new Input();
            while (valid == false)
            {
                Console.WriteLine("Text(T) or file(F)?");
                //Get either manually entered text, or text from a file
                string input = Console.ReadLine();
                choice = input.ToUpper();

                if (choice.Length == 1)
                {
                    valid = true;
                }
            }
            if (choice == "T")
            {
                string s = t.manualTextInput();
                Analyse(s);
             
            }
            else if (choice == "F")
            {
                //go to file function
                string s = f.fileTextInput(@"C:\Users\joelb\OneDrive\Documents\Computer science\OOP\CMP1903M Assessment 1 Base Code" );
                Analyse(s);

            }
            else
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Please enter F or T");
                InputChoice();
            }
        }

        //Create an 'Analyse' object
        static void Analyse(string s)
        {
            AnalyseString a = new AnalyseString();
            List<int> values = a.analyseText(s);
            Console.WriteLine($"There are {values[0]} sentences");
            Console.WriteLine($"There are {values[1]} Vowels");
            Console.WriteLine($"There are {values[2]} Consonants");
            Console.WriteLine($"There are {values[3]} Upper case letters");
            Console.WriteLine($"There are {values[4]} Lower case letters");
            Console.WriteLine($"There are {values[3] + values[4]} Total letters");
        }
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        
        
        
    
    }
}
           