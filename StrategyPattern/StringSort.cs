using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{

    class ComplexSort : ISortingStrategy 
    {
       
        #region ISortingStrategy Members       

        public void Sort<T>(List<T> data)
        {
            data.Sort();
        }


        #endregion
    }

    public class SortByString : IComparer<Citizen> 
    {
        public int Compare(Citizen x, Citizen y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class Citizen
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

       
    }


}
