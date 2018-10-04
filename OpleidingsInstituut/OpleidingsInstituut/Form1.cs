using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpleidingsInstituut
{
    public partial class Form1 : Form
    {
        //
        //Vars
        //
        double betaal;
        byte AantalVakken;
        byte AantalSV;
        byte AantalMV;
        byte AantalPV;
        byte Opgeslagenvakken;
        int leeftijd;
        DateTime Nu = DateTime.Now;
        bool Arbeidsbureau;


        public Form1()
        {
            InitializeComponent();
        }
        //
        //Methodes
        //
        private void SlaPersInfoOp()
        {
            AantalVakken = byte.Parse(txbIn01.Text);
            leeftijd = dateTimePicker1.Value.Year - Nu.Year;
            if (rdbJa.Checked) { Arbeidsbureau = true; }
            else if (rdbNee.Checked) { Arbeidsbureau = false; }
            pnlIn01.Enabled = false;
            pnlIn02.Visible = true;

        }
        
        private void Klaar()
        {
            betaal = (100 * AantalSV) + (200 * AantalMV) + (275 * AantalPV);
            if (Arbeidsbureau)
            {
                betaal = betaal - ((AantalSV * 50) + (AantalMV * 50) + (AantalPV * 125));
            }
            if (AantalVakken >= 5) { betaal = betaal - ((((AantalSV * 50) + (AantalMV * 150) + (AantalPV * 150)) / 100) * 5); }
            if (leeftijd < 19) { betaal = (betaal / 100) * 98; }
            pnlIn02.Enabled = false;
            pnlOut.Visible = true;
            lblAantalVakkenUit.Text = "Aantal vakken: " + AantalVakken.ToString();
            lblAatnalSV.Text = "Aantal schriftelijke vakken: " + AantalSV.ToString();
            lblAatnalMV.Text = "Aantal mondelijke vakken: " + AantalMV.ToString();
            lblAatnalPV.Text = "Aantal practische vakken: " + AantalPV.ToString();
            lblBetaaltotaal.Text = "Totaal: " + betaal.ToString();
        }

        private void SlaOp()
        {
            if (rdbSV.Checked) { AantalSV += 1; rdbSV.Checked = false; }
            else if (rdbMV.Checked) { AantalMV += 1; rdbMV.Checked = false; }
            else if (rdbPV.Checked) { AantalPV += 1; rdbPV.Checked = false; }
            Opgeslagenvakken++;
            lblID.Text = "Vak " + (Opgeslagenvakken + 1).ToString();
            if(Opgeslagenvakken >= AantalVakken)
            {
                Klaar();
            }
        }


        //
        //Events
        //
        private void btnVerder_Click(object sender, EventArgs e)
        {
            SlaPersInfoOp();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SlaOp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
