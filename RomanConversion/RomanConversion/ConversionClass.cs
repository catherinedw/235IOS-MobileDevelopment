using System;
using System.Collections.Generic;

namespace RomanConversion
{
    public class ConversionClass
    {
        Dictionary<int, string> convert;
        public string DecimalNum { get; set; }
        public string RomanNum { get; set; }

        //constructor
        public ConversionClass()
        {
            // Create a new dictionary of strings, with string keys.
            convert = new Dictionary<int, string>();

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
        }


        /*
        public toDecimal(string key, string value)
        {
            this.Key= key;
            this.Value = value;
        }*/  

        //This function takes the int decimal number (the key) and returns the string roman numeral (the value) 
        public string ToRoman(int dNum)
        {
            //validate that a number is entered and that it is greater than 0 
            string result;
            if (dNum<=0)
            {
                result = "-1";
            } 
            else 
            {
                result = convert[toUpper(dNum)];
            }
            return result;
        }

        //This function turns the string roman numeral and returns an int decimal number
        public int ToDecimal(string rNum)
        {
            foreach (KeyValuePair<int, string> pair in convert)
            {
                if (pair.Value == rNum)
                {
                    return pair.Key;
                }
            }
            return -1;
        }
    }
}

