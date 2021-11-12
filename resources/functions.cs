using System;

namespace BaseToBaseCS
{
   class Functions
   {
      public static int LowerBaseToTen(int numberToConvert, int startingBase) {
         string numberToConvertString = numberToConvert.ToString();
         int power = 0;
         double total = 0;
         for (int i = numberToConvertString.Length - 1; i >= 0; i--) {
            int intOfChar = int.Parse(numberToConvertString[i].ToString());
            total += Convert.ToDouble(intOfChar) * Math.Pow(startingBase, power);
            power += 1;
         }
         return Convert.ToInt32(total);
      }

   }
}
