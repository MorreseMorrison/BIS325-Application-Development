//Name: Morrese Morrison
//University: Peirce College
//Assignment: Program 3 Resturant Bill
//Date: 4/18/2023 8:00PM
//Completed Date: 4/19/2023 8:20PM
/*Program Purpose: This Program calculates the total Item Amount In Addition To Sales Tax & Shipping Charges
 * Depending On The Quantity Amount That The User Enters.
*/
using System;

namespace BIS325_Program_10_Amount_Due
{
    class Amount_Due_Program
    {
        static void Main(string[] args)
        {
            double Base_Sales_Tax = 7.75;
            double Three_Dollar_Fifty_Cent_Shipping_Charge = 3.5;
            double Five_Dollar_Shipping_Charge = 5;
            double Seven_Dollar_Shipping_Charge = 7;
            double Nine_Dollar_Shipping_Charge = 9;
            double Ten_Dollar_Shipping_Charge = 10;
            double Item_Cost = 5;
            double Item_Cost_Before_Base_Sales_Tax;
            double Base_Sales_Tax_Difference;
            double Full_Item_Cost;
            double Sales_Tax_Final_Percentage;


            Console.WriteLine("\n*WELCOME TO THE AMOUNT DUE PROGRAM");
            Console.WriteLine("\nPlease Enter How Many Products Did You Purchase? (PLEASE ENTER ONLY NUMBERS)");
            double Quantity_Of_Items_Purchased = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYou Purchased: " + Quantity_Of_Items_Purchased + " Items.");


            //PROGRAM STARTS
            Console.WriteLine("\n*ITEM REPORT*");

            //Less Than 3 Items
            if (Quantity_Of_Items_Purchased < 3)
            {
                ////Calculation Logic
                Item_Cost_Before_Base_Sales_Tax = Item_Cost * Quantity_Of_Items_Purchased;
                Base_Sales_Tax_Difference = Base_Sales_Tax / 100;
                Sales_Tax_Final_Percentage = Base_Sales_Tax_Difference * 10;
                Full_Item_Cost = Three_Dollar_Fifty_Cent_Shipping_Charge + Sales_Tax_Final_Percentage + Item_Cost_Before_Base_Sales_Tax;
                Console.WriteLine("\nYour Grand Total After Shipping And Sales Tax Is: " + "$" + "{0:0,0.00}", Full_Item_Cost);
                Console.WriteLine("\nYour Shipping Charge Is: " + "$" + "{0:0,0.00}", Three_Dollar_Fifty_Cent_Shipping_Charge);
                Console.WriteLine("\nYour Sales Tax Amount Is: " + "$" + "{0:0,0.00}", Sales_Tax_Final_Percentage);
                Console.WriteLine("\nThe Number Of Items Purchased: " + Quantity_Of_Items_Purchased);
                Console.WriteLine("\nThe Total Purchase Charge Of Your Items Before The Sales Tax & Shipping Is: " + "$" + "{0:0,0.00}", Item_Cost_Before_Base_Sales_Tax);
            }

            //Greater Than Or Equal To 3 But Less Than Or Equal To 6
            if (Quantity_Of_Items_Purchased >= 3 && Quantity_Of_Items_Purchased <= 6)
            {
                //Calculation Logic
                Item_Cost_Before_Base_Sales_Tax = Item_Cost * Quantity_Of_Items_Purchased;
                Base_Sales_Tax_Difference = Base_Sales_Tax / 100;
                Sales_Tax_Final_Percentage = Base_Sales_Tax_Difference * 10;
                Full_Item_Cost = Five_Dollar_Shipping_Charge + Sales_Tax_Final_Percentage + Item_Cost_Before_Base_Sales_Tax;
                Console.WriteLine("\nYour Grand Total After Shipping And Sales Tax Is: " + "$" + "{0:0,0.00}", Full_Item_Cost);
                Console.WriteLine("\nYour Shipping Charge Is: " + "$" + "{0:0,0.00}", Five_Dollar_Shipping_Charge);
                Console.WriteLine("\nYour Sales Tax Amount Is: " + "$" + "{0:0,0.00}", Sales_Tax_Final_Percentage);
                Console.WriteLine("\nThe Number Of Items Purchased: " + Quantity_Of_Items_Purchased);
                Console.WriteLine("\nThe Total Purchase Charge Of Your Items Before The Sales Tax & Shipping Is: " + "$" + "{0:0,0.00}", Item_Cost_Before_Base_Sales_Tax);
            }

            //Greater Than Or Equal To 7 But Less Than Or Equal To 10
            if (Quantity_Of_Items_Purchased >= 7 && Quantity_Of_Items_Purchased <= 10)
            {
                //Calculation Logic
                Item_Cost_Before_Base_Sales_Tax = Item_Cost * Quantity_Of_Items_Purchased;
                Base_Sales_Tax_Difference = Base_Sales_Tax / 100;
                Sales_Tax_Final_Percentage = Base_Sales_Tax_Difference * 10;
                Full_Item_Cost = Seven_Dollar_Shipping_Charge + Sales_Tax_Final_Percentage + Item_Cost_Before_Base_Sales_Tax;
                Console.WriteLine("\nYour Grand Total After Shipping And Sales Tax Is: " + "$" + "{0:0,0.00}", Full_Item_Cost);
                Console.WriteLine("\nYour Shipping Charge Is: " + "$" + "{0:0,0.00}", Seven_Dollar_Shipping_Charge);
                Console.WriteLine("\nYour Sales Tax Amount Is: " + "$" + "{0:0,0.00}", Sales_Tax_Final_Percentage);
                Console.WriteLine("\nThe Number Of Items Purchased: " + Quantity_Of_Items_Purchased);
                Console.WriteLine("\nThe Total Purchase Charge Of Your Items Before The Sales Tax & Shipping Is: " + "$" + "{0:0,0.00}", Item_Cost_Before_Base_Sales_Tax);
            }


            //Greater Than Or Equal To 11 But Less Than Or Equal To 15
            if (Quantity_Of_Items_Purchased >= 11 && Quantity_Of_Items_Purchased <= 15)
            {
                //Calculation Logic
                Item_Cost_Before_Base_Sales_Tax = Item_Cost * Quantity_Of_Items_Purchased;
                Base_Sales_Tax_Difference = Base_Sales_Tax / 100;
                Sales_Tax_Final_Percentage = Base_Sales_Tax_Difference * 10;
                Full_Item_Cost = Nine_Dollar_Shipping_Charge + Sales_Tax_Final_Percentage + Item_Cost_Before_Base_Sales_Tax;
                Console.WriteLine("\nYour Grand Total After Shipping And Sales Tax Is: " + "$" + "{0:0,0.00}", Full_Item_Cost);
                Console.WriteLine("\nYour Shipping Charge Is: " + "$" + "{0:0,0.00}", Nine_Dollar_Shipping_Charge);
                Console.WriteLine("\nYour Sales Tax Amount Is: " + "$" + "{0:0,0.00}", Sales_Tax_Final_Percentage);
                Console.WriteLine("\nThe Number Of Items Purchased: " + Quantity_Of_Items_Purchased);
                Console.WriteLine("\nThe Total Purchase Charge Of Your Items Before The Sales Tax & Shipping Is: " + "$" + "{0:0,0.00}", Item_Cost_Before_Base_Sales_Tax);
            }

            //Greater Than 15
            if (Quantity_Of_Items_Purchased > 15)
            {
                //Calculation Logic
                Item_Cost_Before_Base_Sales_Tax = Item_Cost * Quantity_Of_Items_Purchased;
                Base_Sales_Tax_Difference = Base_Sales_Tax / 100;
                Sales_Tax_Final_Percentage = Base_Sales_Tax_Difference * 10;
                Full_Item_Cost = Ten_Dollar_Shipping_Charge + Sales_Tax_Final_Percentage + Item_Cost_Before_Base_Sales_Tax;
                Console.WriteLine("\nYour Grand Total After Shipping And Sales Tax Is: " + "$" + "{0:0,0.00}", Full_Item_Cost);
                Console.WriteLine("\nYour Shipping Charge Is: " + "$" + "{0:0,0.00}", Ten_Dollar_Shipping_Charge);
                Console.WriteLine("\nYour Sales Tax Amount Is: " + "$" + "{0:0,0.00}", Sales_Tax_Final_Percentage);
                Console.WriteLine("\nThe Number Of Items Purchased: " + Quantity_Of_Items_Purchased);
                Console.WriteLine("\nThe Total Purchase Charge Of Your Items Before The Sales Tax & Shipping Is: " + "$" + "{0:0,0.00}", Item_Cost_Before_Base_Sales_Tax);
            }

            //PROGRAM ENDS


        }
    }
    }
