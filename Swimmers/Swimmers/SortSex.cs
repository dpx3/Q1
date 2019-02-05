using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SortSex : SwimmerSorter, IComparer<Swimmer>
    {
        public int Compare(Swimmer x, Swimmer y)
        {
            return StringComparer.CurrentCulture.Compare(x.sex, y.sex);
        }

        public List<Swimmer> Sort(List<Swimmer> swimmers)
        {
            swimmers.Sort(this);
            return swimmers;
        }
    }
}
