namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtSjediste = new System.Windows.Forms.TextBox();
            this.txtPutnik = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSjediste = new System.Windows.Forms.Label();
            this.lblLinija = new System.Windows.Forms.Label();
            this.lblPutnik = new System.Windows.Forms.Label();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.vmbKategorija = new System.Windows.Forms.ComboBox();
            this.cmbLinija = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatum.Location = new System.Drawing.Point(153, 169);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(123, 20);
            this.txtDatum.TabIndex = 5;
            // 
            // txtSjediste
            // 
            this.txtSjediste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSjediste.Location = new System.Drawing.Point(153, 134);
            this.txtSjediste.Name = "txtSjediste";
            this.txtSjediste.Size = new System.Drawing.Size(123, 20);
            this.txtSjediste.TabIndex = 3;
            // 
            // txtPutnik
            // 
            this.txtPutnik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPutnik.Location = new System.Drawing.Point(152, 62);
            this.txtPutnik.Name = "txtPutnik";
            this.txtPutnik.Size = new System.Drawing.Size(157, 20);
            this.txtPutnik.TabIndex = 0;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.Location = new System.Drawing.Point(53, 208);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(79, 18);
            this.lblKategorija.TabIndex = 14;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(54, 171);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(56, 18);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Datum:";
            // 
            // lblSjediste
            // 
            this.lblSjediste.AutoSize = true;
            this.lblSjediste.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSjediste.Location = new System.Drawing.Point(54, 136);
            this.lblSjediste.Name = "lblSjediste";
            this.lblSjediste.Size = new System.Drawing.Size(61, 18);
            this.lblSjediste.TabIndex = 12;
            this.lblSjediste.Text = "Sjediste:";
            // 
            // lblLinija
            // 
            this.lblLinija.AutoSize = true;
            this.lblLinija.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinija.Location = new System.Drawing.Point(54, 100);
            this.lblLinija.Name = "lblLinija";
            this.lblLinija.Size = new System.Drawing.Size(54, 18);
            this.lblLinija.TabIndex = 11;
            this.lblLinija.Text = "Linija:";
            // 
            // lblPutnik
            // 
            this.lblPutnik.AutoSize = true;
            this.lblPutnik.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPutnik.Location = new System.Drawing.Point(54, 64);
            this.lblPutnik.Name = "lblPutnik";
            this.lblPutnik.Size = new System.Drawing.Size(57, 18);
            this.lblPutnik.TabIndex = 10;
            this.lblPutnik.Text = "Putnik:";
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(153, 245);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(156, 29);
            this.btnRezervisi.TabIndex = 8;
            this.btnRezervisi.Text = "Rezerviši";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // btnNextForm
            // 
            this.btnNextForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextForm.Location = new System.Drawing.Point(280, 134);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(29, 23);
            this.btnNextForm.TabIndex = 4;
            this.btnNextForm.Text = "...";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            this.btnNextForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNextForm_KeyPress);
            // 
            // dtp1
            // 
            this.dtp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp1.Location = new System.Drawing.Point(292, 169);
            this.dtp1.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(2018, 3, 13, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(17, 20);
            this.dtp1.TabIndex = 6;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // vmbKategorija
            // 
            this.vmbKategorija.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.vmbKategorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vmbKategorija.FormattingEnabled = true;
            this.vmbKategorija.Items.AddRange(new object[] {
            "Ekonomska",
            "Biznis"});
            this.vmbKategorija.Location = new System.Drawing.Point(153, 205);
            this.vmbKategorija.Name = "vmbKategorija";
            this.vmbKategorija.Size = new System.Drawing.Size(156, 21);
            this.vmbKategorija.TabIndex = 7;
            // 
            // cmbLinija
            // 
            this.cmbLinija.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbLinija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLinija.FormattingEnabled = true;
            this.cmbLinija.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbLinija.Items.AddRange(new object[] {
            "Sarajevo - Banjaluka",
            "Banjaluka - Sarajevo",
            "Sarajevo - Doboj",
            "Lukavica - Pale"});
            this.cmbLinija.Location = new System.Drawing.Point(153, 97);
            this.cmbLinija.Name = "cmbLinija";
            this.cmbLinija.Size = new System.Drawing.Size(156, 21);
            this.cmbLinija.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(0, 17);
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 335);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmbLinija);
            this.Controls.Add(this.vmbKategorija);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtSjediste);
            this.Controls.Add(this.txtPutnik);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblSjediste);
            this.Controls.Add(this.lblLinija);
            this.Controls.Add(this.lblPutnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(743, 564);
            this.MinimumSize = new System.Drawing.Size(446, 374);
            this.Name = "Form1";
            this.Text = "Bus++ - Marko Mandic, 1672";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtSjediste;
        private System.Windows.Forms.TextBox txtPutnik;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSjediste;
        private System.Windows.Forms.Label lblLinija;
        private System.Windows.Forms.Label lblPutnik;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox vmbKategorija;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVrijeme;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.ComboBox cmbLinija;
    }
}

