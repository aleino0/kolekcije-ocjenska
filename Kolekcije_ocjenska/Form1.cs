using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcije_ocjenska
{
    public partial class Form1 : Form
    {
        List<ObradaPod> listObradapod = new List<ObradaPod>();


        public Form1()
        {
            InitializeComponent();
        }

        
        private void unos_Click(object sender, EventArgs e)
        {
            
            try
            {
                ObradaPod osoba = new ObradaPod(ime.Text, prezime.Text, spol.Text, grad.Text);

                ime.Clear();
                prezime.Clear();
                grad.Clear();

                listObradapod.Add(osoba);
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void ispis_Click(object sender, EventArgs e)
        {
            foreach (ObradaPod osob in listObradapod)
            {
                richIspis.AppendText(osob.ToString());
            }
        }
        private void obrada_Click(object sender, EventArgs e)
        {
            foreach (ObradaPod osob in listObradapod)
            {
                if(osob.Spol=="Muško")
                {
                    osob.Kosa = "kratka";
                }
                if(osob.Spol=="Žensko")
                {
                    osob.Kosa = "duga";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
