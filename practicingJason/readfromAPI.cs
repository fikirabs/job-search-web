using System;
using System.Text;
using System.Net;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace practicingjason
{
    public class Class1
    {
        public static void Main(string[] args) 
            {

                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://data.usajobs.gov/api/jobs?Title=Psychologist");
                myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();
               // System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Fikrte2\Desktop\readfile.txt");
                //file.WriteLine(result);
            file.Close();


                /*
                         char[] delimiterChars = {':'};
                          string myResponse;
                         System.Console.WriteLine(myResponse);

                          string[] words = myResponse.Split(delimiterChars);
                         // System.Console.WriteLine("{0} words in text:", words.Length);

                          foreach (string myResponse in words)
                          {
                              System.Console.WriteLine(myResponse);
                          }*/

                // Keep the console window open in debug mode.
                //System.Console.WriteLine("Press any key to exit.");
                //  System.Console.ReadKey();

                // Example #1: Write an array of strings to a file.
                // Create a string array that consists of three lines.
                //  string[] lines = { "First line", "Second line", "Third line" };
                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.  You do NOT need to call Flush() or Close().
            }
        }
    }

