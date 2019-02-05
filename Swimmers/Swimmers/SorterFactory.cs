using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SorterFactory
    {

        public SwimmerSorter GetSorter(string sortType)
        {
            switch (sortType)
            {
                case "Name":
                    return new SortName();
                case "Sex":
                    return new SortSex();
                case "Age":
                    return new SortAge();
                case "Best Time":
                    return new SortBestTime();
                default:
                    return new Empty();
            }
        }

    }
}
