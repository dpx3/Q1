using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimmers
{
    class SwimmerFactory
    {
        string[] names = { "Brunilda Mcgarrah", "Jennifer Kunz", "Loma Dynes", "Anja Hodak", "Ellsworth Wixom", "Phung Coburn", "Paulina Hull", "Meagan Underdown", "Joycelyn Mach", "Consuela Weisenberger", "Shanta Fronk", "Viva Angevine", "Timika Oconner", "Roger Meneely", "Trudy Reedy", "Reda Sellers", "Yadira Liakos", "Sung Winkel", "Tania Whitton", "Verla Mccartney", "Bernardine Lynde", "Melissia Cuffee", "Stefan Meese", "Zora Glasper", "Kimber Swearingen", "Adalberto Strauser", "Marquitta Woolston", "Edwardo Quinonez", "Johanne Torian", "Shanice Waltrip", "Matt Ebright", "Joel Shuey", "Blake Ells", "Claretta Wollman", "Concepcion Byram", "My Creed", "Willis Dodd", "Emory Bodie", "Rosalie Chubb", "Jacquetta Gokey", "Sonia Kale", "Halley Buckles", "Candance Feely", "Rickie Myron", "Wilson Amen", "Allison Laprade", "Jana Burress", "Jeremy Cazarez", "Isadora Quigley", "Lady Frum", "Mike Parkins", "Noemi Bak", "Sheree Heckert", "Rufina Morey", "Robyn Schley", "Alonso Sheats", "Camelia Delisa", "Kerstin Zamarripa", "Barton Baugher", "Clifton Follette", "Jeane Rosenblatt", "Kanesha Sax", "Rosalia Koren", "Rachell Medford", "Johnna Thorpe", "Nguyet Blair", "Stacee Wine", "Odette Wilcox", "Millicent Grable", "Lessie Edmiston", "Delena Maiden", "Maren Grindle", "Otis Fausto", "Catharine Waldschmidt", "Thomas Mccutcheon", "Nisha Ramsey", "Rafael Diggins", "Jamika Arellano", "Leda Larrabee", "Anjelica Whisenant", "Sherley Stinger", "Maryanne Roldan", "Azalee Ling", "Lamar Serrata", "Zulema Mccall", "Erasmo Turbeville", "Cinthia Ambler", "Otelia Mcsherry", "Arnetta Folger", "Yvette Mcmichael", "Cristie Broadhead", "Narcisa Vines", "Claudie Driggs", "Marcelino Holzworth", "Loise Perino", "Cecile Caffrey", "Roxie Askey", "Bradley Shipe", "Awilda Thomason", "Aletha Schroder", "Ashleigh Jarrett", "Delana Holdman", "Annamarie Modesto", "Macy Woolston", "Rubie Updike", "Renita Hollifield", "Isaac Sigala", "Sabina Simoneaux", "Christie Mcginness", "Kerri Lafountain", "Nigel Wenger", "Wesley Heffington", "Warner Bloodsaw", "Georgette Delucia", "Arthur Kies", "Lashell Hilts", "Tamekia Crumley", "Timika Kube", "Britni Mena", "Kareem Mersch", "Alissa Hsu", "Regan Bennington", "Adriana Peavy", "Chia Price", "Edwina Vernon", "Ricki Porterfield", "Mark Pontius", "Carole Nickels", "Cecilia Veal", "Moshe Loranger", "Keith Woodfin", "Edwardo Wessels", "Melania Conway", "Jenee Meinecke", "Suzy Columbus", "Orval Kyzer", "Karen Newsome", "Shanel Scoggins", "Odelia Hollars", "Marcia Leggett", "Tomas Alongi", "Alise Panos", "Fredrick Banaszak", "Ethelene Whitsett", "Magdalen Macpherson", "Lenora Tingle", "Cindi Zaragosa", "Chara Campanelli", "Beula Shaner", "Gil Seawright", "Isidra Grisby", "Veda Parrino", "Natasha Sanderlin", "Arminda Avera", "Toby Ahumada", "Siobhan Moylan", "Celestina Dorgan", "Chet Smits", "Keesha Milton", "Elden Oleary", "Daysi Kohlmeier", "Russell Horner", "Paulita Hakala", "Leandra Mcneilly", "Neal Guillet", "Nedra Costanzo", "Kaylene Mcnab", "Hsiu Fairbanks", "Abram Ro", "Joanna Renken", "Frida Ament", "Collette Studstill", "Tawanda Deshong", "Loni Alderson", "Caitlyn Reichard", "Earnestine Betterton", "Darcy Danek", "Chae Lyons", "Rickey Toon", "Kurtis Schroder", "Sabine Dingee", "Caridad Buskirk", "Elda Lacaze", "Cordelia Mcevoy", "Genna Balis", "Dominic Helfrich", "Tatum Bernal", "Isela Searle", "Charleen Maury", "Stevie Sorrentino", "Chase Wilgus", "Miquel Korando", "Vashti Galloway", "Jacques Bilbrey", "Bernarda Farnan", "Ilana Younan", "Nobuko Durbin", "Concepcion Hasan", "Lashaunda Kilburn", "Bertie Vetter" };

        public List<Swimmer> getSwimmers() {
            List<Swimmer> swimmers = new List<Swimmer>();
            Random random = new Random();
            int[] distances = SwimEvents.GetInstance().distances;
            string[] strokes = SwimEvents.GetInstance().strokes;
            string[] seasons = SwimEvents.GetInstance().seasons;
            for (int i = 0; i < 100; i++)
            {
                string name = names[i];
                int age = 10 + random.Next(10);
                Swimmer newSwimmer = new Swimmer(name, (random.Next(2) == 0 ? "Male" : "Female"), age);
                List<Race> races = new List<Race>();
                swimmers.Add(newSwimmer);
            }
            foreach (int distance in distances)
            {
                foreach (string stroke in strokes)
                {
                    foreach (string season in seasons)
                    {
                        List<Swimmer> selectedSwimmers = new List<Swimmer>();
                        for (int i = 0; i < 40; i++)
                        {
                            Swimmer selectedSwimmer = swimmers[random.Next(swimmers.Count)];
                            while (selectedSwimmers.Contains(selectedSwimmer))
                            {
                                selectedSwimmer = swimmers[random.Next(swimmers.Count)];
                            }
                            Race race = new Race(distance, stroke, season, distance / 10 + (float)random.NextDouble() * 5);
                            selectedSwimmer.DisplayTime = race.time;
                            selectedSwimmer.races.Add(race);
                        }
                        selectedSwimmers.Clear();
                    }
                }
            }
            return swimmers;
        }

    }
}
