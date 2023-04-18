//Name: Morrese Morrison
//University: Peirce College
//Assignment: Program 3 Resturant Bill
//Date: 4/16/2023 7:00PM
//Completed Date: 4/8/2023 6:56PM
/*Program Purpose: This Program Calculates The Total Mark Up Retail Price Of An Item Based User Input.
 * Once The User Enters A Number Value For The Whole Sale Item Price, That Input Is Calculated Against
 * 5%, 6%,7%, 8%,9% and 10%. From There, The New Price Is Then Displayed.
 * 
*/
using System;

namespace BIS325_Program_9_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Percentage List
            double Five_Percent_Mark_Up = .05;// Five Percent Mark Up Variable
            double Six_Percent_Mark_Up = .06;// Six Percent Mark Up Variable
            double Seven_Percent_Mark_Up = .07;// Seven Percent Mark Up Variable
            double Eight_Percent_Mark_Up = .08;// Eight Percent Mark Up Variable
            double Nine_Percent_Mark_Up = .09;// Nine Percent Mark Up Variable
            double Ten_Percent_Mark_Up = .10; // Ten Percent Mark Up Variable



            // PROGRAM START

            //(1 Of 2 Main)
            Console.WriteLine("*WELCOME TO THE EARNINGS MARK UP CALCULATOR*");
            Console.WriteLine("\nPlease Enter The Whole Sale Item Price Below (ONLY NUMBERS NO SYMBOLS)");
            double User_Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe Whole Sale Item Price That You Entered Is: " + "$" + "{0:0,0.00}", User_Input);


            //(2 Of 2 Main)
            Console.WriteLine("\n *MARK UP REPORT*");

            //(1 of 6 Logic) 5 Percent Mark Up Price Logic
            double Five_Percent_Mark_Up_Difference = Five_Percent_Mark_Up * User_Input;
            double Retail_Price_After_Five_Percent_Mark_Up= User_Input + Five_Percent_Mark_Up_Difference;

            //(2 of 6 Logic) 6 Percent Mark Up Price Logic
            double Six_Percent_Mark_Up_Difference = Six_Percent_Mark_Up * User_Input;
            double Retail_Price_After_Six_Percent_Mark_Up = User_Input + Six_Percent_Mark_Up_Difference;

            //(3 of 6 Logic) 7 Percent Mark Up Price Logic
            double Seven_Percent_Mark_Up_Difference = Seven_Percent_Mark_Up * User_Input;
            double Retail_Price_After_Seven_Percent_Mark_Up = User_Input + Seven_Percent_Mark_Up_Difference;

            //(4 of 6 Logic) 8 Percent Mark Up Price Logic
            double Eight_Percent_Mark_Up_Difference = Eight_Percent_Mark_Up * User_Input;
            double Retail_Price_After_Eight_Percent_Mark_Up = User_Input + Eight_Percent_Mark_Up_Difference;

            //(5 of 6 Logic) 9 Percent Mark Up Price Logic
            double Nine_Percent_Mark_Up_Difference = Nine_Percent_Mark_Up * User_Input;
            double Retail_Price_After_Nine_Percent_Mark_Up = User_Input + Nine_Percent_Mark_Up_Difference;

            //(5 of 6 Logic) 10 Percent Mark Up Price Logic
            double Ten_Percent_Mark_Up_Difference = Ten_Percent_Mark_Up * User_Input;
            double Retail_Price_After_Ten_Percent_Mark_Up = User_Input + Ten_Percent_Mark_Up_Difference;

            //New Retail Price After Mark Up Value Console Print
            Console.WriteLine("|Percentage|  |Retail Price|");
            Console.WriteLine("|    5%    |  " + "|" + "$" + "{0:0,0.00}", Retail_Price_After_Five_Percent_Mark_Up + "|");
            Console.WriteLine("|    6%    |  " + "|" + "$" + "{0:0,0.00}", Retail_Price_After_Six_Percent_Mark_Up + "|");
            Console.WriteLine("|    7%    |  " + "|" + "$" + "{0:0,0.00}", Retail_Price_After_Seven_Percent_Mark_Up + "|");
            Console.WriteLine("|    8%    |  " + "|" + "$" + "{0:0,0.00}", Retail_Price_After_Eight_Percent_Mark_Up + "|");
            Console.WriteLine("|    9%    |  " + "|" + "$" + "{0:0,0.00}", Retail_Price_After_Nine_Percent_Mark_Up + "|");
            Console.WriteLine("|    10%   |  " + "|" + "$" + "{0:0,0.00}", Retail_Price_After_Ten_Percent_Mark_Up + "|");
            // PROGRAM END

        }
    }
}
