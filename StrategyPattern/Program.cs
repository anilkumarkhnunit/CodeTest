using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISortingStrategy sortingStrategy = null;

            //Sorting the scholar numbers of students in the university,
            List<int> studentNumbers = new List<int> { 200, 400, 100, 50 };
            sortingStrategy = GetSortingOption(ObjectToSort.StudentScholar);

            Console.WriteLine("scholar numbers of students before sorting");
            foreach (int num in studentNumbers)
            {
                Console.WriteLine(num + " ");
            }            
            sortingStrategy.Sort(studentNumbers);            
            Console.WriteLine("scholar numbers of students after sorting");
            foreach (int num in studentNumbers)
            {
                Console.WriteLine(num + " ");
            }

            //Sorting ticket numbers of railway passengers      
            List<string> railwayPassengers = new List<string> { "T123", "A345", "T432", "X567" };
            sortingStrategy = GetSortingOption(ObjectToSort.RailwayPassengers);
         
            Console.WriteLine("numbers of railway passengers before sorting");
            foreach (string pass in railwayPassengers)
            {
                Console.WriteLine(pass + " ");
            }

            sortingStrategy.Sort(railwayPassengers);
            
            Console.WriteLine("numbers of railway passengers after sorting");
         
            foreach (string pass in railwayPassengers)
            {
                Console.WriteLine(pass + " ");
            }

            //Sorting Names of all people residing in a county.
            List<string> PeopleINCountry = new List<string> { "Ram", "Krishna", "Imran", "Joseph" };
            sortingStrategy = GetSortingOption(ObjectToSort.PeopleINCountry);

            Console.WriteLine("Names of all people residing in a county before sorting");
            foreach (string ppl in PeopleINCountry)
            {
                Console.WriteLine(ppl + " ");
            }
            sortingStrategy.Sort(PeopleINCountry);
            Console.WriteLine("Names of all people residing in a county after sorting");
            foreach (string ppl in PeopleINCountry)
            {
                Console.WriteLine(ppl + " ");
            }
        }

        private static ISortingStrategy GetSortingOption(ObjectToSort objectToSort)
        {
            ISortingStrategy sortingStrategy = null;

            switch (objectToSort)
            {
                case ObjectToSort.StudentScholar:
                    sortingStrategy = new SimpleSort();                    
                    break;
                case ObjectToSort.RailwayPassengers:
                    sortingStrategy = new SimpleSort();
                    break;
                case ObjectToSort.PeopleINCountry:
                    sortingStrategy = new ComplexSort();
                    break;
                default:
                    break;
            }
            return sortingStrategy;
        }
    }
}
