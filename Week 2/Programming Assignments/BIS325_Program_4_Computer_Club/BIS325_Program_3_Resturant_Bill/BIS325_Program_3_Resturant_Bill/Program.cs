//Name: Morrese Morrison
//University: Peirce College
//Assignment: Program 3 Resturant Bill
//Date: 3/28/2023 3:00PM
//Completed Date: 5:32PM
/*Program Purpose: This Program calculates the total resturant bill after a user enters value in the prompt.
 * That value will go against a 9% tax, in addition
 * to 15% tip or a 20% tip seperately.
*/
using System;

namespace BIS325_Program_3_Resturant_Bill
{
    class Restaurant_Bill

    {
        static double Standard_Nine_Percent_Tax = 0.09; //Standard 9% Tax Rate.
        static double Standard_Fifteen_Percent_Tip = 0.15; //Standard 15% Tip Rate.
        static double Standard_Twenty_Percent_Tip = 0.20; //Standard 20% Tip Rate.
        

        static void Main(string[] args)

        {

            double Restaurant_Charge_After_Nine_Percent_Tax_Added; //The Total Restaurant Charge After The 9% Tax Is Added.
            double Restaurant_Charge_Nine_Percent_Tax_Difference; //The 9% Tax Difference That Is Assigned By * The 9% Charge Against The User Input Value (Restaurant_Initial_Charge).
            double Restaurant_Full_Charge_After_Tax_And_Fifteen_Percent_Tip; //The Full Charge After The 9% Tax and 15% Tip Is Added To The Input Value (Restaurant_Initial_Charge).
            double Restaurant_Full_Charge_After_Tax_And_Twenty_Percent_Tip; //The Full Charge After The 9% Tax and 20% Tip Is Added To The Input Value (Restaurant_Initial_Charge).
            double Restaurant__Fifteen_Percent_Tip_Difference; //The 15% Tip Difference That Is Assigned By * 15% Tip Against Restaurant_Charge_After_Nine_Percent_Tax_Added.
            double Restaurant__Twenty_Percent_Tip_Difference; //The 20% Tip Difference That Is Assigned By * 20% Tip Against Restaurant_Charge_After_Nine_Percent_Tax_Added.
            double Restaurant_Initial_Charge; //User Input Of The Resturant Bill Before Tax & Tip.


            // * PROGRAM START

            Console.WriteLine("*WELCOME TO THE RESTAURANT TAX & TIP CHARGE CALCULATOR*");


            //(1 of 4) Intial User Input Prompt & Display.
            Console.WriteLine("\nHow Much Was Your Bill? (Please Only Enter Numbers & Decimals. No $ Symbols).");
            Restaurant_Initial_Charge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nExcellent Your Bill With No Tip Or Tax Is: " + "$" + "{0:0.00}", Restaurant_Initial_Charge);
            //END

            //(2 of 4) Charge & Tax Summary Calculation.
            Console.WriteLine("\n\n*CHARGE & TAX SUMMARY*");
            Restaurant_Charge_Nine_Percent_Tax_Difference = Restaurant_Initial_Charge * Standard_Nine_Percent_Tax;
            Restaurant_Charge_After_Nine_Percent_Tax_Added = Restaurant_Charge_Nine_Percent_Tax_Difference + Restaurant_Initial_Charge;
            Console.WriteLine("Total Bill Before Tax & Tip: " + "$" + "{0:0.00}", Restaurant_Initial_Charge);
            Console.WriteLine("Nine Percent Tax Difference: " + "$" + "{0:0.00}", Restaurant_Charge_Nine_Percent_Tax_Difference);
            Console.WriteLine("Total After Nine Percent Tax: " + "$" + "{0:0.00}", Restaurant_Charge_After_Nine_Percent_Tax_Added);
            //END

            //(3 of 4) Charge, Tax & Tip Summary Calculation 15 Percent.
            Console.WriteLine("\n\n*CHARGE, TAX & TIP SUMMARY (15 Percent Tax)*");
            Restaurant__Fifteen_Percent_Tip_Difference = Standard_Fifteen_Percent_Tip * Restaurant_Charge_After_Nine_Percent_Tax_Added;
            Restaurant_Full_Charge_After_Tax_And_Fifteen_Percent_Tip = Restaurant__Fifteen_Percent_Tip_Difference + Restaurant_Charge_After_Nine_Percent_Tax_Added;
            Console.WriteLine("Total After Nine Percent Tax: " + "$" + "{0:0.00}", Restaurant_Charge_After_Nine_Percent_Tax_Added);
            Console.WriteLine("Your Fifteen Percent Tip Difference Is: " + "$" + "{0:0.00}", Restaurant__Fifteen_Percent_Tip_Difference);
            Console.WriteLine("After Fifteen Percent Tip & After Nine Percent Tax Your Total Is: " + "$" + "{0:0.00}", Restaurant_Full_Charge_After_Tax_And_Fifteen_Percent_Tip);
            //END

            //(4 of 4) Charge, Tax & Tip Summary Calculation 15 Percent.
            Console.WriteLine("\n\n*CHARGE, TAX & TIP SUMMARY (20 Percent Tax)*");
            Restaurant__Twenty_Percent_Tip_Difference = Standard_Twenty_Percent_Tip * Restaurant_Charge_After_Nine_Percent_Tax_Added;
            Restaurant_Full_Charge_After_Tax_And_Twenty_Percent_Tip = Restaurant__Twenty_Percent_Tip_Difference + Restaurant_Charge_After_Nine_Percent_Tax_Added;
            Console.WriteLine("Total After Nine Percent Tax: " + "$" + "{0:0.00}", Restaurant_Charge_After_Nine_Percent_Tax_Added);
            Console.WriteLine("Your Twenty Percent Tip Difference Is: " + "$" + "{0:0.00}", Restaurant__Twenty_Percent_Tip_Difference);
            Console.WriteLine("After Twenty Percent Tip & After Nine Percent Tax Your Total Is: " + "$" + "{0:0.00}", Restaurant_Full_Charge_After_Tax_And_Twenty_Percent_Tip);
            //END

            //*PROGRAM END*



        }
    }
}
