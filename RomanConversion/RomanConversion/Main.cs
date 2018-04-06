using UIKit;
using System.Collections.Generic;

namespace RomanConversion
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");

            // Create a new dictionary of strings, with string keys.
            //
            Dictionary<int, string> convert = new Dictionary<int, string>();

            // Add elements to the dictionary. 
            convert.Add(1, "I");
            convert.Add(2, "II");
            convert.Add(3, "III");
            convert.Add(4, "IV");
            convert.Add(5, "V");
            convert.Add(6, "VI");
            convert.Add(7, "VII");
            convert.Add(8, "VIII");
            convert.Add(9, "IX");
            convert.Add(10, "X");


            Button toRomanButton = FindViewById<Button>(Resource.Id.toRomanButton);

        }
    }
}
