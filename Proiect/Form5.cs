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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            refreshGrid();

            try
            {
                reteteContinutBindingSource.Filter = "IdReteta=" + txtIdReteta.Text;
            }
            catch { }


        }
        private void refreshGrid()
        {
            reteteTableAdapter.Fill(dataSet2.Retete);
            reteteContinutTableAdapter.Fill(dataSet2.ReteteContinut);
        }

        private void reteteBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                reteteContinutBindingSource.Filter = "IdReteta=" + txtIdReteta.Text;
            }
            catch { }

        }

        private void btnRetetaNoua_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            refreshGrid();
        }

        private void btnStergeReteta_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = reteteTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut reteta
            cmd.CommandText = "Delete From ReteteContinut Where IdReteta = " + txtIdReteta.Text;

           // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg reteta
            cmd.CommandText = "Delete From Retete Where IdReteta = " + txtIdReteta.Text;
           // MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();

            try
            {
                reteteContinutBindingSource.Filter = "IdReteta=" + txtIdReteta.Text;
            }
            catch { }
        }

        private void btnModificaReteta_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.completeazaTitlu("MODIFICARE RETETA");
            f.bs1 = reteteBindingSource;
            f.bs2 = reteteContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }

    }
}

