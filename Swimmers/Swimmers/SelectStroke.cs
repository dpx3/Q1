using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SelectStroke : SwimmerSelector
    {

        string stroke;

        public SelectStroke(string stroke)
        {
            this.stroke = stroke;
        }

        public List<Swimmer> Select(List<Swimmer> swimmers)
        {

            List<Swimmer> output = new List<Swimmer>();
            foreach (Swimmer swimmer in swimmers)
            {
                bool inStroke = false;
                foreach (Race race in swimmer.races)
                {
                    if (race.stroke == stroke && race.selected)
                    {
                        inStroke = true;
                        swimmer.DisplayTime = race.time;
                    }
                    else
                    {
                        race.selected = false;
                    }
                }
                if (inStroke)
                    output.Add(swimmer);
            }
            return output;
        }

    }
}
