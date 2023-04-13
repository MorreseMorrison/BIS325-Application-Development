//Name: Morrese Morrison
//University: Peirce College
//Assignment: Program 4 Computer Club
//Date: 4/2/2023 4:45PM
//Completed Date: 4/2/2023 5:23PM
/*Program Purpose: This Program Has One Main Class Named Moterway, Where Different Attributes
 * Of This Class Is Intiliazed For Further Use In An Object. Once That Moterway Object
 * Is created, The Object Can Then Return These Attributes with either a ToString() Method
 * Or Utilizing Getters.
*/

using System;

namespace Moterway_Program

{

    //Main Class Moterway Template
    class Moterway
    {

        //Class Attributes
        private string Moterway_Name; //The Name Of The Moterway.
        private string Moterway_Type; //The Moterway Type (Road, Street, Avenue, Etc).
        private string Moterway_Direction; //The Moterway Direction (East, West, North, South)
        private string Moterway_Surface; //The Moterway Surface (Asphalt, Concrete)
        private int Moterway_Number_Of_Lanes; //The Moterway Number Of Lanes
        private Boolean Moterway_Toll; //Whether The Moterway Has Tolls Or Not (True Or False)
        private string Party_Who_Maintains_Moterway; //Who Maintains The Moterway



        //Moterway Class ToString() Method Returns All Of The Data Fields And Members
        public override string ToString()
        {
            return "Moterway Name: " + Moterway_Name +
                    "\nMoterway Type: " + Moterway_Type +
                    "\nMoterway Direction: " + Moterway_Direction +
                    "\nMoterway Surface: " + Moterway_Surface +
                    "\nMoterway Number Of Lanes: " + Moterway_Number_Of_Lanes +
                    "\nMoterway Toll: " + Moterway_Toll +
                    "\nParty Who Maintains Moterway: " + Party_Who_Maintains_Moterway.ToString();
        }



        //Park Class Return Method park_Name_Location_Type
        public string moterway_Name_Location_Type
        {
            get { return "Moterway Name:  " + Moterway_Name + "\nMoterway Toll: " + Moterway_Toll + "\nMoterway Number Of Lanes: " + Moterway_Number_Of_Lanes; }

        }



        //* PROGRAM START
        static void Main(string[] args)
        {

            //New Object Constructor START
            Moterway SunSetDrive = new Moterway();
            //New Object Constructor END


            //START ASSIGNING VALUES TO OBJECT
            SunSetDrive.Moterway_Name = "Sun Set Drive";
            SunSetDrive.Moterway_Type = "Blvd";
            SunSetDrive.Moterway_Direction = "West Bound";
            SunSetDrive.Moterway_Surface = "Asphalt";
            SunSetDrive.Moterway_Number_Of_Lanes = 3;
            SunSetDrive.Moterway_Toll = true;
            SunSetDrive.Party_Who_Maintains_Moterway = "Sun Set County";
            //END ASSIGNING VALUES TO OBJECT

            //Business Requireent (1 Of 2)
            Console.WriteLine("\n*FULL MOTERWAY SUMMARY INFORMATION*");
            Console.WriteLine(SunSetDrive.ToString());


            //Business Requireent (2 Of 2)
            Console.WriteLine("\n*MOTERWAY SELECTION*");
            //Return Method (Getters) For Moterway Name, Moterway Type And Moterway Directions
            Console.WriteLine(SunSetDrive.moterway_Name_Location_Type);

            
        }

        //*PROGRAM END

    }



}
