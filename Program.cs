using System;
//using Newtonsoft.Json;      // JSON: https://www.newtonsoft.com/json


namespace BaseToBaseCS
{
   class Program
   {
      // Function to ask a question and take input
      static string AskForInput(string question)   {
         Console.WriteLine(question);
         return Console.ReadLine();
      }

      // Function to check if digits are larger than base
      static bool digitsLarger(string numString, int baseInt)  {
         for (int i = 0; i < numString.Length; i++)  {

            // Check if digit is higher than base allows
            int intOfStringIndex = int.Parse(numString[i].ToString());
            if (intOfStringIndex >= baseInt) {
               return true;
            }
         }
         return false;
      }

      // Check range
      static string CheckRangeOfInputs(int startingBase, int endingBase)   {

         string msg = "";

         if (startingBase < 2 || startingBase > 10)   {
            msg = "ERROR: This program cannot handle base " + startingBase.ToString() + " as the starting base!";
         }

         if (endingBase < 2 || endingBase > 10) {  ////// change endingBase range when bases larger than 10 are supported
            msg = "ERROR: This program cannot handle base " + endingBase.ToString() + "!";
         }

         return msg;
      }

      //////////////////////////////////////////////////////////////////////
      //////////////////////////////// Main ////////////////////////////////
      //////////////////////////////////////////////////////////////////////
      static void Main(string[] args)  {

         Functions.test();

         int test = Functions.FromTenToLowerBase(5512, 3); // 30, 5 should be 110, THERE IS AN ERROR
         Console.WriteLine(5 / 2);
         Console.WriteLine(test);

         // Loop
         while (true)   {

            // INPUTS
            int numberToConvert = Int32.Parse(AskForInput("Enter Number to convert:"));
            int startingBase = Int32.Parse(AskForInput("What base is this number in?:"));
            int endingBase = Int32.Parse(AskForInput("What base would you like to convert it to?:"));

            // Check range
            string rangeCheckResults = CheckRangeOfInputs(startingBase, endingBase);
            if (rangeCheckResults != "") {
               Console.WriteLine(rangeCheckResults);
               continue;
            }

            // Check if any digits in the number to convert are larger than the base
            bool tooHighDigit = digitsLarger(numberToConvert.ToString(), startingBase);
            if (tooHighDigit == true) {
               Console.WriteLine("ERROR: Given number is in a higher base than the specified starting base!");
               continue;
            }

            // CONVERSTION TO OTHER BASES
            int newNumber;

            newNumber = 1; // (delete this when conversion is a thing)

            // Write result to console
            Console.WriteLine("The base " + startingBase.ToString() + " number " +
               numberToConvert.ToString() + " in base " + endingBase.ToString() + " is " + newNumber.ToString());

         }
      }
   }
}
