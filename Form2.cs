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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblVrijeme.Text = DateTime.Now.ToString("HH:mm:ss  - dd/MM/yyyy");
            foreach(Button dugme in tableLayoutPanel1.Controls)
            {
                if(Form1.Sjediste.CompareTo(dugme.Text)==0)
                {
                    dugme.BackColor = Color.Red;
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            foreach(Button dugme in tableLayoutPanel1.Controls)
            {
                dugme.BackColor = Color.LimeGreen;
            }
            btn.BackColor = Color.Red;
            DialogResult d1=MessageBox.Show("Da li zelite da nastavite dalje?","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d1 == DialogResult.Yes)
            {
                Form1.Sjediste = btn.Text;
                Form1 forma1 = new Form1(Form1.Putnik, Form1.Linija, Form1.Sjediste, Form1.Datum, Form1.Kategorija);
                this.Hide();
                forma1.Show();
            }

        }
        private void tmr2_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("HH:mm:ss  - dd/MM/yyyy");
        } 
    }
}
