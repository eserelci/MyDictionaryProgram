using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProgram
{
    public class Dictionary<Key,Value>
    { 
        Key[] monthNumberArray;
        Value[] monthNameArray;
        public Dictionary()
        {           
            monthNumberArray = new Key[0];
            monthNameArray = new Value[0];
        }
        public void Add(Key number, Value month)
        {
            Key[] tempMonthNumberArray = monthNumberArray;
            monthNumberArray = new Key[monthNumberArray.Length + 1];
            for (int i = 0; i < tempMonthNumberArray.Length; i++)
            {
                monthNumberArray[i] = tempMonthNumberArray[i];
            }
            monthNumberArray[monthNumberArray.Length - 1] = number;
            Value[] tempMonthNameArray = monthNameArray;
            monthNameArray = new Value[monthNameArray.Length + 1];
            for (int i = 0; i < tempMonthNameArray.Length; i++)
            {
                monthNameArray[i] = tempMonthNameArray[i];
            }
            monthNameArray[monthNameArray.Length - 1] = month;
        }
        public void Listele()
        {
            for (int i = 0; i < monthNumberArray.Length; i++)
            {
                Console.WriteLine("Month Name: "+monthNameArray[i]+" Month Number: "+monthNumberArray[i]);
            }
        }
    }
}
