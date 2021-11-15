using System;

namespace BaseToBaseCS
{
   class Functions
   {

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

         while (baseRaised <= numberToConvert) {
            power++;
            baseRaised = (int)Math.Pow(targetBase, power);
         }

         power--;
         baseRaised = (int)Math.Pow(targetBase, power);

         int multiplier = 1;

         while (baseRaised * multiplier <= numberToConvert) {
            multiplier++;
         }

         Console.WriteLine("final = " + finalNumber.ToString() + "\nbaseRaised = " + baseRaised.ToString() + "\nMultiplier = " + multiplier.ToString());

         multiplier -= 1;
         baseRaised *= multiplier;
         finalNumber += multiplier.ToString();
         numberToConvert -= baseRaised;

         Console.WriteLine("final = " + finalNumber.ToString() + "\nbaseRaised = " + baseRaised.ToString() + "\nMultiplier = " + multiplier.ToString());

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
         return 2;
      }

   }
}
