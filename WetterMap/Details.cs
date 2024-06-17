using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterMap
{
    public class Details
    {
        public string Land { get; set; }
        public double Einwohner { get; set; }
        public Details(string land, double einwohner) 
        { 
            Land = land;
            Einwohner = einwohner;
        }

    }
}
