using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class Race
    {

        public int distance;
        public string stroke;
        public float time;
        public string season;

        public bool selected = true;

        public Race(int distance, string stroke, string season, float time)
        {
            this.distance = distance;
            this.stroke = stroke;
            this.time = time;
            this.season = season;
        }

    }
}
