using System;
using System.IO;  // For streamreader
using System.Collections.Generic;   // For lists
using Newtonsoft.Json;  // For json

namespace BaseToBaseCS
{
   class Functions
   {

      public static void test()  {
         using (StreamReader reader = new StreamReader("test.json"))   {
            string json = reader.ReadToEnd();
            List<string> thing = new List<string>();
            thing.AddRange(JsonConvert.DeserializeObject<List<string>>(json));
            Console.WriteLine(thing);
         }
      }


      // Converts from a base lower than ten to base ten
      public static int FromLowerBaseToTen(int numberToConvert, int startingBase) {
         string numberToConvertString = numberToConvert.ToString();
         int power = 0;
         double total = 0;

         // Loop through each digit
         for (int i = numberToConvertString.Length - 1; i >= 0; i--) {
            int intOfChar = int.Parse(numberToConvertString[i].ToString());
            total += Convert.ToDouble(intOfChar) * Math.Pow(startingBase, power);
            power += 1;
         }

         return Convert.ToInt32(total);
      }

      // Converts from base ten to a base lower than ten
      public static int FromTenToLowerBase(int numberToConvert, int targetBase)   {
         string finalNumber = string.Empty;
         int power = 0;
         int baseRaised = 0;

         while (baseRaised < numberToConvert) {
            power++;
            baseRaised = (int)Math.Pow(targetBase, power);
         }

         int multiplier = 1;

         while (baseRaised * multiplier <= numberToConvert) {
            multiplier++;
         }

         multiplier -= 1;
         baseRaised *= multiplier;
         finalNumber += multiplier.ToString();
         numberToConvert -= baseRaised;

         while (power > 0) {
            power -= 1;
            baseRaised = (int)Math.Pow(targetBase, power);
            multiplier = 0;

            while (baseRaised * multiplier <= numberToConvert) {
               multiplier++;
            }

            multiplier--;
            finalNumber += multiplier.ToString();
            numberToConvert -= baseRaised * multiplier;
         }

         return Int32.Parse(finalNumber);
      }

      // Converts from base ten to a base higher than ten
      public static int FromTenToHigherBase(int numberToConvert, int targetBase)   {
         int quotient = numberToConvert / targetBase;
         List<string> remainders = new List<string>();

         if (numberToConvert % targetBase < 10) {
            remainders.Add((numberToConvert % targetBase).ToString());
         } else {

            // BIG NUMBER (I need to add support for digits larger than 9)
         }

         return 1;
      }

   }
}
