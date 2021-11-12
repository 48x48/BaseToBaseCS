using System;

namespace BaseToBaseCS
{
   class Functions
   {

      // Converts from a base lower than ten to base ten
      public static int LowerBaseToTen(int numberToConvert, int startingBase) {
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
      public static int FromTenToLower(int numberToConvert, int targetBase)   {
         return 1;
      }

      // Converts from base ten to a base higher than ten
      public static int FromTenToHigher(int numberToConvert, int targetBase)   {
         return 2;
      }

   }
}
