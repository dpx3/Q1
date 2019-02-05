using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{

    class SelectDistance : SwimmerSelector
    {

        int distance;

        public SelectDistance(int distance)
        {
            this.distance = distance;
        }

        public List<Swimmer> Select(List<Swimmer> swimmers)
        {

            List<Swimmer> output = new List<Swimmer>();
            foreach (Swimmer swimmer in swimmers)
            {
                bool inDistance = false;
                foreach (Race race in swimmer.races)
                {
                    if (race.distance == distance && race.selected)
                    {
                        inDistance = true;
                        swimmer.DisplayTime = race.time;
                    } else
                    {
                        race.selected = false;
                    }
                }
                if (inDistance)
                    output.Add(swimmer);
            }
            return output;
        }
    }
}
