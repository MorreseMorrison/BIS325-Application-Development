//Name: Morrese Morrison
//University: Peirce College
//Assignment: Program 3 Resturant Bill
//Date: 4/15/2023 5:00PM
//Completed Date: 8:36PM
/*Program Purpose: This Program Calculates The Total Profit Based On Sales And Provides A Percentage Threshold.
 * For This Calculation The User Will Input The Total Number Of Products Sold * The Product Price.
 * This Will Calculate The Total Profit As Well As The Percentage Threshold.
 * 
*/
using System;

namespace BIS325_Program_8_Profit_Based_On_Sales
{
    class Profit_Based_On_Sales_Program
    {

        static void Main(string[] args)
        {
            //Product Variables
            int Number_Of_Products_Sold; //The Total Number Of Products Sold, This Variable Is Assigned By User Input.
            int Product_Price = 5; //Product Price is $5.

            //Revenue Variable
            int Total_Profit; // The Total Profit Value Variable, Calculated With Number_Of_Products_Sold * Product_Price.

            //Percentage Variables
            double Zero_Percent = 0; //Zero Percent Value.
            double Three_Percent = 3; //Three Percent Value.
            double Three_Point_Five_Percent = 3.5; //Three Point 5 Percent Value.
            double Four_Percent = 4; //Four Percent Value.


            //*PROGRAM START

            //(1 Of 3) Program Start & User Input
            Console.WriteLine("*WELCOME TO THE PROFIT BASED ON SALES REPORT*");
            Console.WriteLine("\nHow Many Products Did You Sell? (PLEASE ENTER ONLY NUMBERS");
            Number_Of_Products_Sold = Convert.ToInt32(Console.ReadLine());

            //Total Profit Calculated By Multiplying The User's Input Against The Product Price Which Is $5
            Total_Profit = Number_Of_Products_Sold * Product_Price;


            //(2 Of 3) Program Report Summary
            Console.WriteLine("\n*REPORT SUMMARY*");
            Console.WriteLine("Your Total Profit Is: " + "$" + "{0:0,0.00}", Total_Profit);
            Console.WriteLine("You Sold A Number Of: " + "{0:0,00}", Number_Of_Products_Sold);
            Console.WriteLine("These Products Were Sold At: " + "$" + "{0:0.00}", Product_Price);



            //(3 Of 3) If Statments Calculates Percentages Based On Condition

            //Total Profit Less Than $1000
            if (Total_Profit < 1000)
            {
                Console.WriteLine("Your Profit Ratio Is: " + Zero_Percent + "%");
            }


            //Total Profit Greater Than $1,000.01 But Less Than $5,000
            if (Total_Profit >= 1000.01 && Total_Profit <= 5000)
            {
                Console.WriteLine("Your Profit Ratio Is: " + Three_Percent + "%");
            }


            //Total Profit Greater Than $5,000.01 But Less Than $10,000
            if (Total_Profit >= 5000.01 && Total_Profit < 10000)
            {
                Console.WriteLine("Your Profit Ratio Is: " + Three_Point_Five_Percent + "%");
            }


            //Total Profit Greater Than $10,000
            if (Total_Profit > 10000)
            {
                Console.WriteLine("Your Profit Ratio Is: " + Four_Percent + "%");
            }


            //*PROGRAM END

        }
    }
}
