using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SwimEvents
    {

        public static SwimEvents swimEvents;

        public int[] distances = { 100, 300, 500 };
        public string[] strokes = { "FreeStyle", "Backstroke", "Butterfly", "Breaststroke" };
        public string[] ageGroups = { "10 - 12", "13 - 15", "16 - 18", "19 - 20" };
        public string[] sortType = { "Name", "Sex", "Age", "Best Time" };
        public string[] seasons = { "Fall 2018", "Winter 2019" };

        public static SwimEvents GetInstance()
        {
            if (swimEvents == null)
            {
                swimEvents = new SwimEvents();
            }

            return swimEvents;
        }

    }
}
