using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SelectSeason : SwimmerSelector
    {
        string season;

        public SelectSeason(string season)
        {
            this.season = season;
        }

        public List<Swimmer> Select(List<Swimmer> swimmers)
        {
            List<Swimmer> output = new List<Swimmer>();
            foreach (Swimmer swimmer in swimmers)
            {
                bool inSeason = false;
                foreach (Race race in swimmer.races)
                {
                    if (race.season == season && race.selected)
                    {
                        inSeason = true;
                        swimmer.DisplayTime = race.time;
                    }
                    else
                    {
                        race.selected = false;
                    }
                }
                if (inSeason)
                    output.Add(swimmer);
            }
            return output;
        }
    }
}
