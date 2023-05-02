//Name: Morrese Morrison
//University: Peirce College
//Assignment: Program 4 Computer Club
//Date: 3/26/2023 3:00PM
//Completed Date: 6:42PM
/*Program Purpose: This Program calculates the total gross profit after taxes, and expenses
 * based off of user input. The user will input how many cases of candy they would like to sell
 * as well as the price per bar to get a revenue total. Once that total is calculated, taxes and total
 * expenses will be subtracted from that revenue total so the gross total profit is calculated.
*/
using System;

namespace BIS325_Program_4_Computer_Club
{
    class Computer_Club
    {
        static double Bar_Per_Case = 12.00; //The Vendors Bar Per Case Is 12.
        static double Vendor_Case_Price = 5.00; // The Vendor's Price Per Case Is $5.00.
        static double Vendor_Bar_Single_Price = 0.41; // Variable Not Used, But This Is The Vendor's Price Per Bar X 12 = 1 Case.
        static double Student_Government_Tax = 0.10; //Student Government Association Tax at 10%.
        double Cases_Sold; //User Input, Intended Cases Sold.
        double Price_Per_Bar; //User Input, Intended Price Per Bar.

        static void Main(string[] args)
        {
            double One_Case_Revenue; //The Generated Revenue Of One Case Sold.
            double Case_Price_Point; //Price Point Of A Case Based Off Of User Input. 12 * Input Amount For Price Per Bar
            double Revenue; // Revenue After X Amount Of Cases Has Been Sold.
            double Difference_After_Student_Government_Tax; //The 10% Difference Of The Student Government Association Tax Against "double Revenue".
            double Revenue_After_Student_Government_Tax; //The Revenue After The 10% Fee Has Been Applied Against "double Revenue".
            double Total_Profit; //Total Profit after the 10% Tax Has Been Subtracted As Well As The Total Expenses (Purchasing X Amount Of Cases From Vendor).
            double Total_Expenses; //Total Expense Of Purchasing X number of cases at $5.00 From The Vendor.


            //*START PROGRAM

            Console.WriteLine("*Welcome To The Computer Club Calculator*");



            //(1 of 4) User Input
            Console.WriteLine("\nHow Many Cases Do You Intend To Sell?(Only Numbers)");
            double Cases_Sold = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nGreat! You Intend To Sell " + Cases_Sold + " Cases!");
            Console.WriteLine("\nWhat is the intended Price Per Candy Bar? (As A Reminder, There Are 12 Bars In Each Pack, Use Only Numbers And Decimals.)");
            double Price_Per_Bar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n(Great! Your intended Price Per Candy Bar Is " + "$" + "{0:0.00}", Price_Per_Bar + " per candy bar.)");
            //*END USER INPUT



            //(2 of 4) Case Revenue Calculation
            //Formula To Calculate The Revenue Of One Case. Price Of Bar * 12.
            //      6              12             .50
            One_Case_Revenue = Bar_Per_Case * Price_Per_Bar;

            //Formula To Calculate The Revenue Against The Number Of Cases Sold. Revenue For One Case * Intended Number Of Cases sold.
            //12         6                 2
            Revenue = One_Case_Revenue * Cases_Sold;


            //Formula To Calculate The Sale Point Of Each Case
            Case_Price_Point = Bar_Per_Case * Price_Per_Bar;
            //*END CASE REVENUE CALCULATION



            // (3 of 4) Unit Summary
            Console.WriteLine("\n\n*UNIT SUMMARY*");
            Console.WriteLine("Excellent You Intend To Sell " + Cases_Sold + " Cases At " + "$" + "{0:0.00}", Price_Per_Bar + " Per Candy Bar.");
            Console.WriteLine("This means each case is To " + "$" + "{0:0.00}", Case_Price_Point);
            Console.WriteLine("This Would Bring Your Intial Revenue To " + "$" + "{0:0.00}", Revenue);
            //*END UNIT SUMMARY


            // (4 OF 4) Financial Summary
            Console.WriteLine("\n\n*FINANCIAL SUMMARY*");

            //Revenue Generated * the 10% Student Government Tax. The Difference Is Assigned To The Difference_After_Student_Government_Tax varable.
            Difference_After_Student_Government_Tax = (double)(Revenue * Student_Government_Tax);

            //The Initial Revenue Generated Is Subtracted From The 10% Student Government Tax. The Resulting Value Is Assigned To The  Revenue_After_Student_Government_Tax varable. 
            Revenue_After_Student_Government_Tax = Revenue - Difference_After_Student_Government_Tax;
            
            Console.WriteLine("Total Revenue: " + "$" + "{0:0.00}", Revenue);
            Console.WriteLine("Total Revenue After %10 Student Government Tax: " + "$" + "{0:0.00}", Revenue_After_Student_Government_Tax);
            Console.WriteLine("Student Governnment Tax Difference: " + "$" + "{0:0.00}", Difference_After_Student_Government_Tax);

            //The Total Expenses Is Calculated By Multiplying The Intended Cases Sold Against The Vnedor Case Price Which is $5.00
            Total_Expenses = Vendor_Case_Price * Cases_Sold;

            Console.WriteLine("Expenses Will Total: " + "$" + "{0:0.00}", Total_Expenses + " Due To You Needing To Purchase " + Cases_Sold + " Cases.");

            //Total Profit Is Relaized After The Total Revenue Is Calculated After The 10% Charge, As Well As Subtracting From The Total Expenses Amount.
            Total_Profit = Revenue_After_Student_Government_Tax - Total_Expenses;
            Console.WriteLine("Total Profit: " + "$" + "{0:0.00}", Total_Profit);
            //*END FINANCIAL SUMMARY



            //*END PROGRAM

        }
    }
}
