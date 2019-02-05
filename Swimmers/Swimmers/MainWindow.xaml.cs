using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Swimmers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SwimmerData swimmerData = new SwimmerData();
        
        public MainWindow()
        {
            InitializeComponent();
            BuildBoxes();
            UpdateTable();
        }

        void BuildBoxes()
        {
            foreach (string strokeVal in SwimEvents.GetInstance().strokes)
            {
                stroke.Items.Add(strokeVal);
            }
            foreach (int distanceVal in SwimEvents.GetInstance().distances)
            {
                distance.Items.Add(distanceVal);
            }
            foreach (string ageGroupVal in SwimEvents.GetInstance().ageGroups)
            {
                ageGroup.Items.Add(ageGroupVal);
            }
            foreach (string sortType in SwimEvents.GetInstance().sortType)
            {
                sortBy.Items.Add(sortType);
            }
            foreach (string season in SwimEvents.GetInstance().seasons)
            {
                seasons.Items.Add(season);
            }
        }

        private void strokeChanged(object sender, SelectionChangedEventArgs e)
        {
            swimmerData.strokeSelector = new SelectStroke((string)e.AddedItems[0]);
            UpdateTable();
        }

        private void ageGroupChanged(object sender, SelectionChangedEventArgs e)
        {
            int lowerLimit = int.Parse(((string)e.AddedItems[0]).Split('-')[0].Trim());
            int upperLimit = int.Parse(((string)e.AddedItems[0]).Split('-')[1].Trim());
            swimmerData.ageGroupSelector = new SelectAgeGroup(lowerLimit, upperLimit);
            UpdateTable();
        }

        private void distanceChanged(object sender, SelectionChangedEventArgs e)
        {
            swimmerData.distanceSelector = new SelectDistance((int)e.AddedItems[0]);
            UpdateTable();
        }

        private void sortByChanged(object sender, SelectionChangedEventArgs e)
        {
            swimmerData.sorter = (new SorterFactory()).GetSorter((string)e.AddedItems[0]);
            UpdateTable();
        }

        void UpdateTable()
        {
            listView.Items.Clear();
            foreach (Swimmer swimmer in swimmerData.GetSwimmers())
            {
                listView.Items.Add(swimmer);
            }
            listBox.Items.Clear();
            foreach (Swimmer swimmer in swimmerData.swimSet)
            {
                listBox.Items.Add(swimmer.name);
            }
        }

        private void seasonChanged(object sender, SelectionChangedEventArgs e)
        {
            swimmerData.seasonSelector = new SelectSeason((string)e.AddedItems[0]);
            UpdateTable();
        }
    }
}
