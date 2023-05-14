using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form6 : Form
    {
        const int IdMedicamentIndex = 0;
        const int DenumireMedicamentIndex = 1;
        const int UMIndex = 2;
        const int PretIndex = 3;
        const int SpPozaIndex = 4;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //A1
            config(true);
            refresh();
            dataGridView1.Columns[IdMedicamentIndex].ReadOnly = true;


        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView1.Columns[DenumireMedicamentIndex].ReadOnly = v;
            dataGridView1.Columns[UMIndex].ReadOnly = v;
            dataGridView1.Columns[PretIndex].ReadOnly = v;
            dataGridView1.Columns[SpPozaIndex].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            medicamenteTableAdapter.Fill(dataSet1.Medicamente);
            //pictureBox1.ImageLocation = txtSpPoza.Text;
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Medicamente)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireMedicament"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DenumireMedicament la linia cu Id " + r["IdMedicament"]);
                    raspuns = false;
                }
                if (r["UM"] == DBNull.Value)
                {
                    MessageBox.Show("Completati UM la linia cu Id " + r["IdMedicament"]);
                    raspuns = false;
                }
                if (r["Pret"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Pret la linia cu Id " + r["IdMedicament"]);
                    raspuns = false;
                }
                if (r["SpImagine"] == DBNull.Value)
                {
                    MessageBox.Show("Completati SpImagine la linia cu Id " + r["IdMedicament"]);
                    raspuns = false;
                }
            }
            return raspuns;
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
                medicamenteTableAdapter.Update(dataSet1.Medicamente);
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnActualizare.Enabled) return;

            if (dataGridView1.CurrentCell.ColumnIndex == SpPozaIndex)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = openFileDialog1.FileName; ;
                    dataGridView1.CurrentRow.Cells[SpPozaIndex].Value = s;
                    pictureBox1.ImageLocation = s;
                    dataGridView1.EndEdit();

                }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {   

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void medicamenteBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           // pictureBox1.ImageLocation = txtSpPoza.Text;
        }
    }
}

