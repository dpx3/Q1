using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SwimmerData
    {

        public SwimmerSorter sorter = new Empty();
        public SwimmerSelector distanceSelector =  new Empty();
        public SwimmerSelector strokeSelector = new Empty();
        public SwimmerSelector ageGroupSelector = new Empty();
        public SwimmerSelector seasonSelector = new Empty();

        public List<Swimmer> swimSet;

        public SwimmerData()
        {
            SwimmerFactory swimmerFactory = new SwimmerFactory();
            swimSet = swimmerFactory.getSwimmers();

        }

        public List<Swimmer> GetSwimmers()
        {
            ResetSelection();
            List<Swimmer> swimmers = new List<Swimmer>(swimSet);
            swimmers = distanceSelector.Select(swimmers);
            swimmers = strokeSelector.Select(swimmers);
            swimmers = ageGroupSelector.Select(swimmers);
            swimmers = seasonSelector.Select(swimmers);
            swimmers = sorter.Sort(swimmers);
            return swimmers;
        }

        void ResetSelection()
        {
            foreach (Swimmer swimmer in swimSet)
            {
                foreach (Race race in swimmer.races)
                {
                    race.selected = true;
                }
            }
        }

    }
}
