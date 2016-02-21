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
            file.Close();
        }
    }
}
