
namespace Proiect
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reteteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Proiect.DataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.reteteContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetetaNoua = new System.Windows.Forms.Button();
            this.btnModificaReteta = new System.Windows.Forms.Button();
            this.btnStergeReteta = new System.Windows.Forms.Button();
            this.txtIdReteta = new System.Windows.Forms.TextBox();
            this.reteteTableAdapter = new Proiect.DataSet2TableAdapters.ReteteTableAdapter();
            this.reteteContinutTableAdapter = new Proiect.DataSet2TableAdapters.ReteteContinutTableAdapter();
            this.idRetetaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRetetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmiteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRetetaDataGridViewTextBoxColumn,
            this.dataEmiteriiDataGridViewTextBoxColumn,
            this.diagnosticDataGridViewTextBoxColumn,
            this.idPacientDataGridViewTextBoxColumn,
            this.numePacientDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reteteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // reteteBindingSource
            // 
            this.reteteBindingSource.DataMember = "Retete";
            this.reteteBindingSource.DataSource = this.dataSet2;
            this.reteteBindingSource.PositionChanged += new System.EventHandler(this.reteteBindingSource_PositionChanged);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRetetaDataGridViewTextBoxColumn1,
            this.nrCrtDataGridViewTextBoxColumn,
            this.idMedicamentDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.denumireMedicamentDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reteteContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 372);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1027, 304);
            this.dataGridView2.TabIndex = 1;
            // 
            // reteteContinutBindingSource
            // 
            this.reteteContinutBindingSource.DataMember = "ReteteContinut";
            this.reteteContinutBindingSource.DataSource = this.dataSet2;
            // 
            // btnRetetaNoua
            // 
            this.btnRetetaNoua.Location = new System.Drawing.Point(924, 112);
            this.btnRetetaNoua.Name = "btnRetetaNoua";
            this.btnRetetaNoua.Size = new System.Drawing.Size(124, 34);
            this.btnRetetaNoua.TabIndex = 2;
            this.btnRetetaNoua.Text = "Reteta Noua";
            this.btnRetetaNoua.UseVisualStyleBackColor = true;
            this.btnRetetaNoua.Click += new System.EventHandler(this.btnRetetaNoua_Click);
            // 
            // btnModificaReteta
            // 
            this.btnModificaReteta.Location = new System.Drawing.Point(924, 178);
            this.btnModificaReteta.Name = "btnModificaReteta";
            this.btnModificaReteta.Size = new System.Drawing.Size(124, 35);
            this.btnModificaReteta.TabIndex = 3;
            this.btnModificaReteta.Text = "Modifica Reteta";
            this.btnModificaReteta.UseVisualStyleBackColor = true;
            this.btnModificaReteta.Click += new System.EventHandler(this.btnModificaReteta_Click);
            // 
            // btnStergeReteta
            // 
            this.btnStergeReteta.Location = new System.Drawing.Point(924, 256);
            this.btnStergeReteta.Name = "btnStergeReteta";
            this.btnStergeReteta.Size = new System.Drawing.Size(124, 35);
            this.btnStergeReteta.TabIndex = 4;
            this.btnStergeReteta.Text = "Sterge Reteta";
            this.btnStergeReteta.UseVisualStyleBackColor = true;
            this.btnStergeReteta.Click += new System.EventHandler(this.btnStergeReteta_Click);
            // 
            // txtIdReteta
            // 
            this.txtIdReteta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reteteBindingSource, "IdReteta", true));
            this.txtIdReteta.Location = new System.Drawing.Point(924, 35);
            this.txtIdReteta.Name = "txtIdReteta";
            this.txtIdReteta.Size = new System.Drawing.Size(124, 22);
            this.txtIdReteta.TabIndex = 5;
            // 
            // reteteTableAdapter
            // 
            this.reteteTableAdapter.ClearBeforeFill = true;
            // 
            // reteteContinutTableAdapter
            // 
            this.reteteContinutTableAdapter.ClearBeforeFill = true;
            // 
            // idRetetaDataGridViewTextBoxColumn1
            // 
            this.idRetetaDataGridViewTextBoxColumn1.DataPropertyName = "IdReteta";
            this.idRetetaDataGridViewTextBoxColumn1.HeaderText = "IdReteta";
            this.idRetetaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idRetetaDataGridViewTextBoxColumn1.Name = "idRetetaDataGridViewTextBoxColumn1";
            this.idRetetaDataGridViewTextBoxColumn1.Visible = false;
            this.idRetetaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "IdMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "IdMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            this.idMedicamentDataGridViewTextBoxColumn.Visible = false;
            this.idMedicamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireMedicamentDataGridViewTextBoxColumn
            // 
            this.denumireMedicamentDataGridViewTextBoxColumn.DataPropertyName = "DenumireMedicament";
            this.denumireMedicamentDataGridViewTextBoxColumn.HeaderText = "DenumireMedicament";
            this.denumireMedicamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireMedicamentDataGridViewTextBoxColumn.Name = "denumireMedicamentDataGridViewTextBoxColumn";
            this.denumireMedicamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.Width = 125;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idRetetaDataGridViewTextBoxColumn
            // 
            this.idRetetaDataGridViewTextBoxColumn.DataPropertyName = "IdReteta";
            this.idRetetaDataGridViewTextBoxColumn.HeaderText = "IdReteta";
            this.idRetetaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRetetaDataGridViewTextBoxColumn.Name = "idRetetaDataGridViewTextBoxColumn";
            this.idRetetaDataGridViewTextBoxColumn.Visible = false;
            this.idRetetaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataEmiteriiDataGridViewTextBoxColumn
            // 
            this.dataEmiteriiDataGridViewTextBoxColumn.DataPropertyName = "DataEmiterii";
            this.dataEmiteriiDataGridViewTextBoxColumn.HeaderText = "DataEmiterii";
            this.dataEmiteriiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataEmiteriiDataGridViewTextBoxColumn.Name = "dataEmiteriiDataGridViewTextBoxColumn";
            this.dataEmiteriiDataGridViewTextBoxColumn.Width = 125;
            // 
            // diagnosticDataGridViewTextBoxColumn
            // 
            this.diagnosticDataGridViewTextBoxColumn.DataPropertyName = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.HeaderText = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnosticDataGridViewTextBoxColumn.Name = "diagnosticDataGridViewTextBoxColumn";
            this.diagnosticDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPacientDataGridViewTextBoxColumn
            // 
            this.idPacientDataGridViewTextBoxColumn.DataPropertyName = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.HeaderText = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPacientDataGridViewTextBoxColumn.Name = "idPacientDataGridViewTextBoxColumn";
            this.idPacientDataGridViewTextBoxColumn.Visible = false;
            this.idPacientDataGridViewTextBoxColumn.Width = 125;
            // 
            // numePacientDataGridViewTextBoxColumn
            // 
            this.numePacientDataGridViewTextBoxColumn.DataPropertyName = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.HeaderText = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numePacientDataGridViewTextBoxColumn.Name = "numePacientDataGridViewTextBoxColumn";
            this.numePacientDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 688);
            this.Controls.Add(this.txtIdReteta);
            this.Controls.Add(this.btnStergeReteta);
            this.Controls.Add(this.btnModificaReteta);
            this.Controls.Add(this.btnRetetaNoua);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Model 3";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reteteContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRetetaNoua;
        private System.Windows.Forms.Button btnModificaReteta;
        private System.Windows.Forms.Button btnStergeReteta;
        private System.Windows.Forms.TextBox txtIdReteta;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource reteteBindingSource;
        private DataSet2TableAdapters.ReteteTableAdapter reteteTableAdapter;
        private System.Windows.Forms.BindingSource reteteContinutBindingSource;
        private DataSet2TableAdapters.ReteteContinutTableAdapter reteteContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRetetaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRetetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmiteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}