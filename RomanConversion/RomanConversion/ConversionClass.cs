using System;

namespace RomanConversion
{
    public class ConversionClass
    {
        public string decimalNum { get; set; }
        public string romanNum { get; set; }

        //constructor
        public ConversionClass(string dN, string rN)
        {
            decimalNum = dN;
            romanNum = rN;
        }

        //public override string ToString()
        //{
        //    return Spanish;
        //}


            /*
            public toDecimal(string key, string value)
            {
                this.Key= key;
                this.Value = value;
            }  
            */
            public override string toRoman(int key)
            {
                if (convert.ContainsKey(key))
                {
                    string value = convert[key];

                }
                return value;
            }
        }
    }
}
