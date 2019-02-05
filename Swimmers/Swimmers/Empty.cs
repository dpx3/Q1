using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class Empty : SwimmerSelector, SwimmerSorter
    {
        public List<Swimmer> Select(List<Swimmer> swimmers)
        {
            return swimmers;
        }

        public List<Swimmer> Sort(List<Swimmer> swimmers)
        {
            return swimmers;
        }
    }
}
