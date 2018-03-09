using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Maison : Batiment
    {
        int nbpieces;
        public Maison ()
        {
            this.nbpieces = 0;
        }
        public Maison(int nbpieces, string adresse) : base(adresse) 
        {
            this.nbpieces = nbpieces;
        }
        public int Nbpieces
        {
            get { return nbpieces; }
            set { nbpieces = value; }
        }
        public new string ToString()
        {
            return base.ToString() + nbpieces; 
        }
     
    }
}
