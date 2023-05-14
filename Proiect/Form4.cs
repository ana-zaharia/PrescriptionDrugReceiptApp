using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            A1();

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            A5(txtCNP);
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void A1()
        {
 
            pacientTableAdapter.Fill(dataSet1.Pacient);
 
            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            txtIdPacient.ReadOnly = true;

            A3();
        }

        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();

            // Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtNume.Focus();
                refresh_grid(pacientBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(pacientBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            if (txtB == txtCNP)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                con.ConnectionString = pacientTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select NumePacient From Pacient where CNP='" + txtCNP.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select NumePacient From Pacient where CNP='" + txtCNP.Text +
                                      "' and IdPacient  <> " + txtIdPacient.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }
            }

        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();
        }



        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = pacientTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdReteta From Retete where IdPacient=" + txtIdPacient.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Pacient referit in tabela Retete! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();

            con.ConnectionString = pacientTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Delete From Pacient Where IdPacient = " + txtIdPacient.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(pacientBindingSource.Position);



        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtNume.DataBindings.Add("Text", pacientBindingSource, "NumePacient");
                txtCNP.DataBindings.Add("Text", pacientBindingSource, "CNP");
                txtTelefon.DataBindings.Add("Text", pacientBindingSource, "NrTelefon");
                txtAdresa.DataBindings.Add("Text", pacientBindingSource, "Adresa");
                txtIdPacient.DataBindings.Add("Text", pacientBindingSource, "IdPacient");
            }
            else
            {
                txtNume.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtTelefon.DataBindings.Clear();
                txtAdresa.DataBindings.Clear();
                txtIdPacient.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtTelefon.ReadOnly = v;
            txtAdresa.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtCNP.Text = "";
            txtTelefon.Text = "";
            txtAdresa.Text = "";
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Telefon, Adresa
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati Nume !");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Completati CNP !");
                txtCNP.Focus();
                return false;
            }
            if (txtTelefon.Text == "")
            {
                MessageBox.Show("Completati Nr Telefon !");
                txtTelefon.Focus();
                return false;
            }
            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Completati Adresa !");
                txtAdresa.Focus();
                return false;
            }

            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = pacientTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "NumePacient, CNP, NrTelefon, Adresa";
            listaValori = "'" + txtNume.Text + "'" +
                          ",'" + txtCNP.Text + "'" +
                          "," + txtTelefon.Text +
                          ",'" + txtAdresa.Text + "'";

            cmd.CommandText = "Insert into Pacient(" + listaCampuri + ") " +
                              "Select " + listaValori;

           // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refresh_grid(int p)
        {
            pacientTableAdapter.Fill(dataSet1.Pacient);
            pacientBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = pacientTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet = "NumePacient = '" + txtNume.Text + "'," +
                       "CNP = '" + txtCNP.Text + "'," +
                       "NrTelefon = " + txtTelefon.Text + "," + 
                       "Adresa = '" + txtAdresa.Text + "'";

            cmd.CommandText = "Update Pacient Set " + listaSet + " Where IdPacient=" +
                                txtIdPacient.Text;

           // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnConfirmare.Focused)
            { dataGridView1.CancelEdit(); }
            MessageBox.Show("Format eronat");
        }
    }
}
