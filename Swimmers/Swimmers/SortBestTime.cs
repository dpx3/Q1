using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SortBestTime : SwimmerSorter, IComparer<Swimmer>
    {
        public int Compare(Swimmer x, Swimmer y)
        {
            return Comparer<float>.Default.Compare(x.DisplayTime, y.DisplayTime);
        }

        public List<Swimmer> Sort(List<Swimmer> swimmer)
        {
            swimmer.Sort(this);
            return swimmer;
        }
    }
}
