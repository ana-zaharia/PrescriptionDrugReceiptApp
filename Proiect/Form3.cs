using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.DataSet1TableAdapters;

namespace Proiect
{
    public partial class Form3 : Form
    {
        const int NumePacientIndex = 4;
        const int IdPacientIndex = 1;
        const int IdRetetaIndex = 0;
        const int DataEmiteriiIndex = 2;
        const int DiagnosticIndex = 3;

        public Form3()
        {
            InitializeComponent();
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.Columns[DataEmiteriiIndex].ReadOnly = v;
            dataGridView1.Columns[DiagnosticIndex].ReadOnly = v;
            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;

        }

        private void refresh()
        {
            reteteTableAdapter.Fill(dataSet1.Retete);
            pacientTableAdapter.Fill(dataSet1.Pacient);
            completeazaNumePacient();
        }

        private void completeazaNumePacient()
        {
            String idPac;
            int idPacient;
            DataRow r;
            foreach (DataRowView x in reteteBindingSource)
            {
                idPac = x["IdPacient"].ToString();
                idPacient = Convert.ToInt32(idPac);
                r = dataSet1.Tables["Pacient"].Rows.Find(idPacient);
                if (r != null)
                {
                    x["NumePacient"] = r[1].ToString();
                }
                else
                {
                    MessageBox.Show("Nu exista pacientul cu id " + idPacient);
                }
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            //A1
            config(true);
            refresh();
            dataGridView1.Columns[IdRetetaIndex].ReadOnly = true;
            dataGridView1.Columns[IdPacientIndex].ReadOnly = true;

        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                reteteTableAdapter.Update(dataSet1.Retete);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView crt;
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == NumePacientIndex)
                {
                    crt = (DataRowView)pacientBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[IdPacientIndex].Value = crt["IdPacient"];
                }
            }
            catch { }

        }

        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Retete)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                if (r["Diagnostic"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Diagnostic la linia cu Id " + r["IdReteta"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }



    }
}
