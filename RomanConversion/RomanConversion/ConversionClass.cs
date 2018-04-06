using System;

namespace RomanConversion
{
    public class ConversionClass
    {
        public string DecimalNum { get; set; }
        public string RomanNum { get; set; }

        //constructor
        public ConversionClass(string dN, string rN)
        {
            DecimalNum = dN;
            RomanNum = rN;
        }

        /*
        public toDecimal(string key, string value)
        {
            this.Key= key;
            this.Value = value;
        }  

        public override string ToString()
        {
            return Spanish;
        }
        */

        public static string toRoman()
        {
            return RomanNum;
        }

        public static string toDecimal()
        {
            return DecimalNum;
        }
    }
}

