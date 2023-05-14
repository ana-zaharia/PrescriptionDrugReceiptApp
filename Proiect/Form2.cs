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
    public partial class Form2 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idRta;
        public BindingSource bs1;
        public BindingSource bs2;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            A1();

        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void completeazaReteta()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idRta = (int)current["IdReteta"];
            txtNrReteta.Text = Convert.ToString(current["IdReteta"]);

            cmbPacient.Text = current["NumePacient"].ToString();
            txtTotal.Text = current["Total"].ToString();
            txtDiagnostic.Text = current["Diagnostic"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(current["DataEmiterii"]);

            bs2.MoveFirst();

            dataSet2.ReteteContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataSet2.ReteteContinutManevraRow r = dataSet2.ReteteContinutManevra.NewReteteContinutManevraRow();
                r.NrCrt = Convert.ToInt16(current["IdReteta"]);
                r.DenumireMedicament = Convert.ToString(current["DenumireMedicament"]);
                r.UM = Convert.ToString(current["UM"]);
                r.Pret = Convert.ToDecimal(current["Pret"]);
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                r.IdMedicament= Convert.ToInt32(current["IdMedicament"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);

                dataSet2.ReteteContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }



        private void A1()
        {
            //Incarcare DataTable Medicamente
            medicamenteTableAdapter.Fill(dataSet2.Medicamente);

            //Incarcare DataTable Pacient
            pacientTableAdapter.Fill(dataSet2.Pacient);


            // Protectie la modificare
            txtNrReteta.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretDataGridViewTextBoxColumn.ReadOnly = true;
            idMedicamentDataGridViewTextBoxColumn.ReadOnly = true;

            if (lblOp.Text == "MODIFICARE RETETA") completeazaReteta();
            else if (lblOp.Text == "RETETA NOUA") cmbPacient.SelectedIndex = -1;
        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE RETETA")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariReteteContinut();
                this.Close();
            }
            else if (lblOp.Text == "RETETA NOUA")
            {
                generez_nr_rta();
                adaugaInregistrareRetete();
                cautaInregistrare();
                adaugaInregistrariReteteContinut();
                golireCampuri();
            }
        }
        private void adaugaInregistrareRetete()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;
          
            listaCampuri = "IdPacient, DataEmiterii, Diagnostic";
            listaValori = cmbPacient.SelectedValue +
                          ",#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                           + "'"+txtDiagnostic.Text+"'";

            cmd.CommandText = "Insert into Retete(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT IdReteta From Retete Where IdReteta = " +
                                txtNrReteta.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idRta = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }
        private void adaugaInregistrariReteteContinut()
        {
            string listaCampuri = "IdReteta, NrCrt, IdMedicament, Pret, Cantitate";
            string listaValori;

            con.Open();
            foreach (DataRow r in dataSet2.ReteteContinutManevra)
            {
                listaValori = idRta + "," + r["NrCrt"] + "," + r["IdMedicament"] + "," +
                                r["Pret"] + "," + r["Cantitate"];

                cmd.CommandText = "Insert into ReteteContinut(" + listaCampuri + ") " +
                                "Select " + listaValori;

               // MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrReteta.Text = "";
            cmbPacient.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet2.ReteteContinutManevra.Clear();
            txtDiagnostic.Text = "";
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;

            con.ConnectionString = medicamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdReteta = " + idRta;

            string clauzaSet = "Set IdPacient = " + cmbPacient.SelectedValue+","+
                               " DataEmiterii = #" + d1.Month + "/"
                               +d1.Day + "/"
                               +d1.Year + "#,"
                               +"Diagnostic="+ "'"+txtDiagnostic.Text+"'";

            cmd.CommandText = "Update Retete " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void stergeContinut()
        {
            cmd.CommandText = "Delete from ReteteContinut Where IdReteta = " + idRta;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }




        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)reteteContinutManevraBindingSource.Current;
            
            try{
                if (current["NrCrt"] == null) return;
                current["NrCrt"] = reteteContinutManevraBindingSource.Position + 1; }
                catch { }
            }
        private void A4()
        {
            try
            {
               if (dataGridView1.CurrentCell == null) return;
               if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)medicamenteBindingSource.Current;

                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdMedicament"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    reteteContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void reteteContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet2.ReteteContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }

            txtTotal.Text = Convert.ToString(t);
        }
        private void generez_nr_rta()
        {
            con.ConnectionString = medicamenteTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Retete.IdReteta) AS NrMax FROM Retete";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            txtNrReteta.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Pacient
            if (cmbPacient.Text == "")
            {
                MessageBox.Show("Completati Pacient !");
                cmbPacient.Focus();
                return false;
            }
            if (txtDiagnostic.Text == "")
            {
                MessageBox.Show("Completati Diagnostic !");
                txtDiagnostic.Focus();
                return false;
            }

            // Validare completare continut
            if (reteteContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut reteta !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

    }
}

