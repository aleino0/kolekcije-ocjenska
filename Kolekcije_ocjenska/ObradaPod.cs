using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_ocjenska
{
    class ObradaPod
    {
        string ime, prezime, spol, grad, kosa;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Spol { get => spol; set => spol = value; }
        public string Grad { get => grad; set => grad = value; }
        public string Kosa { get => kosa; set => kosa = value; }

        public ObradaPod(string ime, string prezime, string spol, string grad, string kosa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.spol = spol;
            this.grad = grad;
            this.kosa = kosa;
        }

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime +
                "\nPrezime: " + this.prezime +
                "\nSpol: " + this.spol +
                "\nGrad: " + this.grad +
                "\nKosa: " + this.Kosa +
                "\n\n";
                
            return ispis;
        }
    }
}
