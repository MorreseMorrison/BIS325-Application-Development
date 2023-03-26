//Name: Morrese Morrison
//University: Peirce College
//Professor: Michael Chu
//Assignment: Program 2 Mark Down
//Date: 3/25/2023 4:00PM
//Completed Date: 7:00PM
/*Program Purpose: This Program calculates the mark down difference of two shirts
 * with the value of $36 and $41. These T shirts will be marked down by %10, %15 
 * and 20%. An output of the difference and new price will be showed to the user.
*/


using System;

namespace BIS325_Week2_Program3_MarkDown
{
    class Program2_MarkDown
    {
        
        //Mark Down Percentages Variables

        //10 Percent Mark Down Variable
        static double Ten_Percent_Markdown = 0.10;

        //15 Percent Mark Down Variable
        static double Fifteen_Percent_Markdown = 0.15;

        //20 Percent Mark Down Variable
        static double Twenty_Percent_Markdown = 0.20;



        //T Shirt Variables

        //Open Collar Running T Shirt with a value of $41.00
        static double Open_Collar_Running_T_Shirt_Price = 41.00;

        //Razor Back T Shirt with a value of $36.00
        static double Razor_Back_T_Shirt_Price = 36.00;



        static void Main(string[] args)

        {
            // (1 of 3) Ten Percent Variable Intilization
            double Ten_Percent_Difference_Amount;
            double After_Ten_Percent_Difference_Total;

            // (2 of 3) Fifteen Percent Variable Intilization
            double Fifteen_Percent_Difference_Amount;
            double After_Fifteen_Percent_Difference_Total;

            // (3 of 3) Twenty Percent Variable Intilization
            double Twenty_Percent_Difference_Amount;
            double After_Twenty_Percent_Difference_Total;


            /*PROGRAM START*/

            Console.WriteLine("*OPEN COLLAR RUNNING T SHIRT*");
            Console.WriteLine("Full Price: " + "$" + "{0:0.00}", Open_Collar_Running_T_Shirt_Price);


              /* START OPEN COLLAR RUNNING T SHIRT CALCULATION & CONSOLE PRINT*/

                    // Ten Percent Calculation (1 of 2)
                    Ten_Percent_Difference_Amount = (double)(Ten_Percent_Markdown * Open_Collar_Running_T_Shirt_Price);
                    After_Ten_Percent_Difference_Total = Open_Collar_Running_T_Shirt_Price - Ten_Percent_Difference_Amount;

                    // Ten Percent Format Console Print (2 of 2)
                    Console.WriteLine("\n10 Percent Mark Down Price: " + "$" + "{0:0.00}", After_Ten_Percent_Difference_Total);
                    Console.WriteLine("10 Percent Mark Down Difference: " + "$" + "{0:0.00}", Ten_Percent_Difference_Amount);
                    // END - Ten Percent & Calculation & Print


                    // Fifteen Percent Calculation (1 OF 2)
                    Fifteen_Percent_Difference_Amount = (double)(Fifteen_Percent_Markdown * Open_Collar_Running_T_Shirt_Price);
                    After_Fifteen_Percent_Difference_Total = Open_Collar_Running_T_Shirt_Price - Fifteen_Percent_Difference_Amount;


                    // Fifteen Percent Format Console Print (2 of 2)
                    Console.WriteLine("\n15 Percent Mark Down Price: " + "$" + "{0:0.00}", After_Fifteen_Percent_Difference_Total);
                    Console.WriteLine("15 Percent Mark Down Difference: " + "$" + "{0:0.00}", Fifteen_Percent_Difference_Amount);
                    // END - Fifteen Percent & Calculation & Print


                    // Twenty Percent Calculation (1 OF 2)
                    Twenty_Percent_Difference_Amount = (double)(Twenty_Percent_Markdown * Open_Collar_Running_T_Shirt_Price);
                    After_Twenty_Percent_Difference_Total = Open_Collar_Running_T_Shirt_Price - Twenty_Percent_Difference_Amount;


                    // Twenty Percent Format Console Print (2 of 2)
                    Console.WriteLine("\n20 Percent Mark Down Price: " + "$" + "{0:0.00}", After_Twenty_Percent_Difference_Total);
                    Console.WriteLine("20 Percent Mark Down Difference: " + "$" + "{0:0.00}", Twenty_Percent_Difference_Amount);
                    // END - Twenty Percent & Calculation & Print

              /* END OPEN COLLAR RUNNING T SHIRT CALCULATION & CONSOLE PRINT*/





            Console.WriteLine("\n*RAZOR BACK T SHIRT*");
            Console.WriteLine("Full Price: " + "$" + "{0:0.00}", Razor_Back_T_Shirt_Price);


              /* START RAZOR BACK T SHIRT CALCULATION & CONSOLE PRINT*/

                    // Ten Percent Calculation (1 of 2)
                    Ten_Percent_Difference_Amount = (double)(Ten_Percent_Markdown * Razor_Back_T_Shirt_Price);
                    After_Ten_Percent_Difference_Total = Razor_Back_T_Shirt_Price - Ten_Percent_Difference_Amount;

                    // Ten Percent Format Console Print (2 of 2)
                    Console.WriteLine("\n10 Percent Mark Down Price: " + "$" + "{0:0.00}", After_Ten_Percent_Difference_Total);
                    Console.WriteLine("10 Percent Mark Down Difference: " + "$" + "{0:0.00}", Ten_Percent_Difference_Amount);
                    // END - Ten Percent & Calculation & Print


                    // Fifteen Percent Calculation (1 OF 2)
                    Fifteen_Percent_Difference_Amount = (double)(Fifteen_Percent_Markdown * Razor_Back_T_Shirt_Price);
                    After_Fifteen_Percent_Difference_Total = Razor_Back_T_Shirt_Price - Fifteen_Percent_Difference_Amount;


                    // Fifteen Percent Format Console Print (3 of 3)
                    Console.WriteLine("\n15 Percent Mark Down Price: " + "$" + "{0:0.00}", After_Fifteen_Percent_Difference_Total);
                    Console.WriteLine("15 Percent Mark Down Difference: " + "$" + "{0:0.00}", Fifteen_Percent_Difference_Amount);
                    // END - Fifteen Percent & Calculation & Print


                    // Twenty Percent Calculation (1 OF 2)
                    Twenty_Percent_Difference_Amount = (double)(Twenty_Percent_Markdown * Razor_Back_T_Shirt_Price);
                    After_Twenty_Percent_Difference_Total = Razor_Back_T_Shirt_Price - Twenty_Percent_Difference_Amount;


                    // Twenty Percent Format Console Print (2 of 2)
                    Console.WriteLine("\n20 Percent Mark Down Price: " + "$" + "{0:0.00}", After_Twenty_Percent_Difference_Total);
                    Console.WriteLine("20 Percent Mark Down Difference: " + "$" + "{0:0.00}", Twenty_Percent_Difference_Amount);
                    // END - Twenty Percent & Calculation & Print

              /* END RAZOR T SHIRT CALCULATION & CONSOLE PRINT*/



        }
    }
}
