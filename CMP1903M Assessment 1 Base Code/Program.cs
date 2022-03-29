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
            AnalyseString a = new AnalyseString();
            bool valid = false;
            string choice = "";
            Input input = new Input();
            while (valid == false)//error handling for inputting 
            {
                Console.WriteLine("Text(T) or file(F)?");
                //Get either manually entered text, or text from a file
                string choose = Console.ReadLine();
                choice = choose.ToUpper();

                if (choice.Length == 1)
                {
                    valid = true;
                }

                if (choice == "T")
                {
                    string s = input.manualTextInput();
                    Analyse(s, false);

                }
                else if (choice == "F")
                {
                    
                    bool Exist = false;
                    while (Exist == false)//error handling to make sure file is valid
                    {
                        Console.WriteLine("Enter file location");
                        string location = Console.ReadLine();
                        if (File.Exists(location) == false)
                        {
                            Console.WriteLine("File location does not exist");
                        }
                        else
                        { 
                            string text = System.IO.File.ReadAllText(location);
                            string s = input.fileTextInput(text);
                            Analyse(s, true);
                            break;

                        }

                    }
                }
                else//return to input choice if they enter an error
                {
                    valid = false;
                }
            }
            
        }

        //Create an 'Analyse' object
        static void Analyse(string s, bool file )//bool parameter to call long words if called from file
        {
            AnalyseString a = new AnalyseString();
            Report r = new Report();
            List<int> values = a.analyseText(s);
            List<int> letters = a.countletters(s);
            r.Textoutput(values);
            r.Letteroutput(letters);
            //if it came from a file it analyses letter length
            if (file == true)
            {
                List<string> words = a.LongWords(s);
                r.Wordoutput(words);
            }

        }
        ///Pass the text input to the 'analyseText' method
        ///Receive a list of integers back
        ///Report the results of the analysis
        ///TO ADD: Get the frequency of individual letters?
       
       
           
        
        
        
    
    }
}
           