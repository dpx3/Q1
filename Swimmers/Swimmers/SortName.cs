using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SortName : SwimmerSorter, IComparer<Swimmer>
    {
        public int Compare(Swimmer x, Swimmer y)
        {
            return StringComparer.CurrentCulture.Compare(x.name, y.name);
        }

        public List<Swimmer> Sort(List<Swimmer> swimmer)
        {
            swimmer.Sort(this);
            return swimmer;
        }
    }
}
