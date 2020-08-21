using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface ISortingStrategy
    {
        void Sort<T>(List<T> data);
    }
}
