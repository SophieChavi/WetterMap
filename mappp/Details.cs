using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mappp
{
    public class Details
    {
        //Notwendige Felder definieren
        public string Land {  get; set; }
        public double Einwohner { get; set; }


        // Konstruktor für meine Klasse
        public Details(string land, double einwohner)
        {
            Land = land;
            Einwohner = einwohner;
        }
    }


}
