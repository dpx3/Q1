using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SelectAgeGroup : SwimmerSelector
    {

        int lowerLimit;
        int upperLimit;

        public SelectAgeGroup(int lowerLimit, int upperLimit)
        {
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;
        }

        public List<Swimmer> Select(List<Swimmer> swimmers)
        {
            List<Swimmer> output = new List<Swimmer>();
            foreach (Swimmer swimmer in swimmers)
            {
                if (swimmer.age >= lowerLimit && swimmer.age < upperLimit)
                    output.Add(swimmer);
            }
            return output;
        }

    }
}
