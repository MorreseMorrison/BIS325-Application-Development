//Name: Morrese Morrison
//University: Peirce College
//Assignment: Program 4 Computer Club
//Date: 4/1/2023 11:00AM
//Completed Date: 9:29PM
/*Program Purpose: This Program Has One Main Class Named Park, Where Different Attributes
 * Of This Class Is Intiliazed For Further Use In An Object. Once That Park Object
 * Is created, The Object Can Then Return These Attributes.
*/

using System;

namespace Park_Program

{
     
     //Main Class Park Template
     class Park
    {

        //Class Attributes
        private string Park_Name; //The Name Of The Park.
        private string Park_Location; //The State Locaion Of The Park.
        private string Park_Type; //The Type Of Park (National, State).
        private double Park_Fee; //Entrance Fee To Enter The Park.
        private double Park_Total_Employees; //Total Number Of Employees At The Park
        private double Park_Total_Visitors_Last_12_Months; //The Total Number Of Visitors To The Park Past 12 Months.
        private double Park_Annual_Budget; //The Annual Budget For The Park


        
        //Park Class ToString() Method Returns All Of The Data Fields And Members
        public override string ToString()
        {
            return "Park Name: " + Park_Name +
                    "\nPark Location: " + Park_Location +
                    "\nPark Type: " + Park_Type +
                    "\nPark Fee: " + "$" + Park_Fee + 
                    "\nPark Total_Employees: " + "$" + Park_Total_Employees +
                    "\nPark Total Visitors Last 12 Months: " + Park_Total_Visitors_Last_12_Months +
                    "\nPark Annual_Budget: " + "$" + Park_Annual_Budget.ToString();
        }



        //Park Class Return Method park_Name_Location_Type
        public string park_Name_Location_Type
        {
            get { return "Park Name: " + Park_Name + "\nPark Location: " + Park_Location + "\nPark Type: " + Park_Type; }

        }



        //* PROGRAM START

        static void Main(string[] args)
        {

            //New Object Constructor START
            Park YosemiteNationalPark = new Park();
            //New Object Constructor END

            YosemiteNationalPark.Park_Name = "Yosemite National Park";
            YosemiteNationalPark.Park_Location = "California";
            YosemiteNationalPark.Park_Type = "National";
            YosemiteNationalPark.Park_Fee = 35;
            YosemiteNationalPark.Park_Total_Employees = 87;
            YosemiteNationalPark.Park_Total_Visitors_Last_12_Months = 3290000;
            YosemiteNationalPark.Park_Annual_Budget = 10000000;
            //END ASSIGNING VALUES TO OBJECT


            //(Extra - In Addition To 3 & 4) ToString() Method Call
            Console.WriteLine("\n*FULL PARK SUMMARY INFORMATION*");
            Console.WriteLine(YosemiteNationalPark.ToString());


            //Business Requireent (1 & 2)
            Console.WriteLine("\n*PARK SELECTION*");

            //(1 & 2) Return Method (Getters)For Park Name, Park Type, Park Location
            Console.WriteLine(YosemiteNationalPark.park_Name_Location_Type);


            // Business Requireent (Part 3 & 4)
            Console.WriteLine("\n*FULL PARK FINANCIAL REPORT*");

            //Total_Revenue = Park Visitors Multiplied By Fee
            double Total_Revenue = YosemiteNationalPark.Park_Total_Visitors_Last_12_Months * YosemiteNationalPark.Park_Fee;

            //(3 Of 4) Compute Cost Per Visitor Based On Annual Budget And The Number Of Visitors During The Last 12 Months;
            Console.WriteLine("Total Revenue: " + "$" + "{0:0,000.00}", Total_Revenue);
            double Cost_Per_Visitor = YosemiteNationalPark.Park_Annual_Budget / YosemiteNationalPark.Park_Total_Visitors_Last_12_Months;

            //(4 Of 4) Compute Revenue From Fees For The Past Year Based On Number Of Visitors And Fee.
            Console.WriteLine("Cost Per Visitor: " + "$" + "{0:0.00}", Cost_Per_Visitor);
        }

             //*PROGRAM END

    }


        
}
