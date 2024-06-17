using mappp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace mappp
{
    public class WerteDetails
    {
        public ObservableCollection<Details> Länderliste { get; set; }
        public WerteDetails() // Eigenschaften der Objekte
        {
            Länderliste = new ObservableCollection<Details>();
            Länderliste.Add(new Details("Germany", 388000000));
            
        }
    
    }
}
