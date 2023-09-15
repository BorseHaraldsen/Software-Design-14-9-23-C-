using Microsoft.VisualBasic;
using System;
namespace Exercises9_14_23_Forelesning_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new();
            BetterDate betterDate = new(1);
            
            // date.Month = 12;
            //   Console.WriteLine("This is the current month: " + date.Month);
            Console.WriteLine("This is month private setter version: " + betterDate.Month);

            Console.WriteLine("\n\nSeparating tasks\n\n");

            Person person = new("Borse", "Haraldsen");
            // person.FirstName = "Borse";
            //person.LastName = "   Haraldsen";
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}");


            Console.WriteLine($"Name with fullname property: {person.FullName}");

            Console.WriteLine($"\n\nSeparating more tasks\n\n");


   
        }
    }



    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName = "") 
        { 
            _firstName = firstName;
            _lastName = lastName;   
        }
        
            
            
             
        public string FirstName
        {
            get { return _firstName; }
            set {  _firstName = value; }
        }

        public string FirstNameOne { get; set; }

        public string LastName
        {
            get { return _lastName.Trim(); }
            set { _lastName = value; }
        }
         
     
        public string FullName 
        {
            get { return FirstName + " " + LastName; }

        }

    }


    public class BetterDate
    {
        public int Month { get; private set; }

        public BetterDate(int month) {
            Month = month;
        }
    }


    public class Date
    {
        private int _month;


        public enum AllMonths
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            Oktober,
            November,
            December
        }

        public AllMonths AllMonthsGetter { get; set; }

        public int Month
        {

            get
            {
                return _month;
            }

            set
            {
                if (value <= 12 && value >= 1)
                {
                    _month = value;
                }
                else
                {
                    _month = 1;

                }
            }
        
        }

    }

}
 