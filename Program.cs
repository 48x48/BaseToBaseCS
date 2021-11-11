using System;

namespace BaseToBaseCS
{
   class Program
   {
      // Function to ask a question and take input
      static string AskForInput(string question)   {
         Console.WriteLine(question);
         return Console.ReadLine();
      }

      // Main
      static void Main(string[] args)  {

         // Loop
         while (true)   {

            // INPUTS
            int numberToConvert = Int16.Parse(AskForInput("Enter Number to convert:"));
            int startingBase = Int16.Parse(AskForInput("What base is this number in?:"));
            int endingBase = Int16.Parse(AskForInput("What base would you like to convert it to?:"));

            // Check range
            if (startingBase < 2 || startingBase > 10)   {
               Console.WriteLine("ERROR: this program cannot handle base " + startingBase.ToString() + " as the starting base");
               continue;
            }
            if (endingBase < 2 || endingBase > 10) {  ////// change endingBase range when bases larger than 10 are supported
               Console.WriteLine("ERROR: this program cannot handle base " + endingBase.ToString());
               continue;
            }

            // Check if any numbers in the number to convert are larger than the base
            

         }
      }
   }
}
