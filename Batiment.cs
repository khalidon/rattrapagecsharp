using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Batiment
    {
        string adresse;
        public Batiment()
        {
            this.adresse = "";
        }
        public Batiment(string adresse)
        {
            this.adresse = adresse;
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public new string ToString()
        {
            return "Batiment :" + adresse; 
        }
     
    }
}
