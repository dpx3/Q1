using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SortAge : SwimmerSorter, IComparer<Swimmer>
    {
        public int Compare(Swimmer x, Swimmer y)
        {
            return Comparer<int>.Default.Compare(x.age, y.age);
        }

        public List<Swimmer> Sort(List<Swimmer> swimmer)
        {
            swimmer.Sort(this);
            return swimmer;
        }
    }
}
