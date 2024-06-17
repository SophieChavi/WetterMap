using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterMap
{
    public class WerteDetails
    {
        public ObservableCollection<Details> Länderliste {  get; set; }
        public WerteDetails() 
        {
            Länderliste = new ObservableCollection<Details>();
            Länderliste.Add(new Details("Germany", 388000000));
        }
    }
}
