using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectVanzari
{
    public partial class Form1 : Form
    {
        Form2 formHistory;
        private BindingList<Produse> produse;
        public Form1()
        {
            InitializeComponent();
            produse = new BindingList<Produse>();
            cbOptiuni.SelectedIndex = 0;
            cbCantitate.SelectedIndex = 0;

            dgvComanda.DataSource = produse;
            formHistory = new Form2();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length < 2)
            {
                errorProvider1.SetError(textBox, "Trebuie sa existe minim 2 caractere");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefon.Text.Length != 10)
            {
                errorProvider1.SetError(tbTelefon, "Numarul de telefon trebuie sa contina 10 cifre");
                e.Cancel = true;
            }
            else if (!tbTelefon.Text.StartsWith("07"))
            {
                errorProvider1.SetError(tbTelefon, "Numarul de telefon trebuie sa inceapa cu 07");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTelefon, null);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbEmail.Text;
            int count = email.Count(c => c == '@');
            if (!tbEmail.Text.EndsWith("@yahoo.com") && !tbEmail.Text.EndsWith("@gmail.com") || tbEmail.Text[0]=='@' || count!=1)
            {
                errorProvider1.SetError(tbEmail, "Adresa de e-mail este invalida");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            }
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))//poti introduce doar cifre
            {
                e.Handled = true;
            }
        }

        private void tbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))//poti introduce doar litere
            {
                e.Handled = true;
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsWhiteSpace(e.KeyChar))//nu poti introduce spatii 
            { 
                e.Handled = true;
            }
        }

        private void cbOptiuni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            var verificare = ValidateChildren();
            if (!verificare)
            {
                MessageBox.Show("Formularul nu a fost completat corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            produse.Add(new Produse(cbOptiuni.Text, int.Parse(cbCantitate.Text)));
        }

        private void btIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btStergere_Click(object sender, EventArgs e)
        {
            if (dgvComanda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o linie");
                return;
            }

            Produse produsDeSters = (Produse)dgvComanda.SelectedRows[0].DataBoundItem;
            produse.Remove(produsDeSters);
        }

        private void btFinal_Click(object sender, EventArgs e)
        {
            var verificare = ValidateChildren();
            if (!verificare)
            {
                MessageBox.Show("Formularul nu a fost completat corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (produse.Count == 0)
            {
                MessageBox.Show("Nu ati adaugat niciun produs!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tranzactii tranzactie;
            tranzactie = new Tranzactii(new Clienti(tbNume.Text, tbPrenume.Text, tbTelefon.Text, tbEmail.Text, produse));
            ListViewItem lvi = new ListViewItem(tranzactie.client.nume);
            lvi.SubItems.Add(tranzactie.client.prenume);
            lvi.SubItems.Add(tranzactie.client.telefon);
            lvi.SubItems.Add(tranzactie.client.email);

            string produse_string = "";
            foreach (Produse produs in tranzactie.Client.Produse)
            {
                produse_string += produs.ToString();
            }
            lvi.SubItems.Add(produse_string);

            lvi.SubItems.Add(tranzactie.Data_Tranzactie.ToString());
            lvi.SubItems.Add(tranzactie.Suma_Total.ToString());
            formHistory.lv1.Items.Add(lvi);

            tbNume.Text = "";
            tbPrenume.Text = "";
            tbTelefon.Text = "";
            tbEmail.Text = "";
            cbOptiuni.SelectedIndex = 0;
            cbCantitate.SelectedIndex = 0;
            produse = new BindingList<Produse>();
            dgvComanda.DataSource = produse;


        }

        private void btViewHistory_Click(object sender, EventArgs e)
        {
            formHistory.ShowDialog();
        }
    }
}
