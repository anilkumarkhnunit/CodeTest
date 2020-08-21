using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class SimpleSort : ISortingStrategy
    {
        #region ISortingStrategy Members
        public void Sort<T>(List<T> data)
        {
            data.Sort();
        }
        #endregion
    }
}
