using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static string Putnik = "", Linija = "", Sjediste = "", Datum="",Kategorija="";
        int Izracunaj() { int z = 0, x = 1 / z; return x; }
        public Form1(string Putnik, string Linija, string Sjediste, string Datum, string Kategorija)
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString("HH:mm:ss  - dd/MM/yyyy");
            txtPutnik.Text = Putnik;
            cmbLinija.Text = Linija;
            txtSjediste.Text = Sjediste;
            txtDatum.Text = Datum;
            vmbKategorija.Text = Kategorija;


        }
        public Form1()
        {
            InitializeComponent();
            dtp1.MinDate = DateTime.Now;
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("HH:mm:ss  - dd/MM/yyyy");
        }
        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            txtDatum.Text = dtp1.Value.Date.ToShortDateString();
        }
        private void btnNextForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString();
            txtPutnik.Text = Putnik;
            cmbLinija.Text = Linija;
            txtSjediste.Text = Sjediste;
            txtDatum.Text = Datum;
            vmbKategorija.Text = Kategorija;
        }
        private void btnNextForm_Click(object sender, EventArgs e)
        {

            Putnik = txtPutnik.Text;
            Linija = cmbLinija.Text;
            Datum = txtDatum.Text;
            Kategorija = vmbKategorija.Text;
            Sjediste = txtSjediste.Text;
            Form2 forma= new Form2();
            forma.Show();
            forma.Text = "Putnik: "+ txtPutnik.Text;
            this.Hide();
            
        }
        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            try
            {
                Izracunaj();
            }
            catch (Exception ect)
            {
                MessageBox.Show(ect.Message);
            }
            finally
            {
                if (txtSjediste.Text == "" || txtPutnik.Text == "" || vmbKategorija.Text == "" || txtDatum.Text == "" || cmbLinija.Text == "")
                {
                    MessageBox.Show("Niste unijeli sve trazene podatke, pokusajte ponovo!!", "Greska!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int broj;

                    if (!int.TryParse(txtSjediste.Text, out broj))
                    {
                        MessageBox.Show("Unijeto sjediste je neispravno!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSjediste.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtSjediste.Text) > 21 || Convert.ToInt32(txtSjediste.Text) < 0)
                        {
                            MessageBox.Show("Unijeto sjediste ne postoji !!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Rezervacija uspjesna!!\nPutnik: " + txtPutnik.Text + "\nLinija: " + cmbLinija.Text + "\nDatum: " + txtDatum.Text + "\nSjediste: " + txtSjediste.Text + "\nKategorija: " + vmbKategorija.Text, "Rezervisano!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtDatum.Text = "";
                            vmbKategorija.Text = "";
                            txtSjediste.Text = "";
                            cmbLinija.Text = "";
                            txtPutnik.Text = "";
                        }
                    }
                }
            }
            
        }
    }
}
