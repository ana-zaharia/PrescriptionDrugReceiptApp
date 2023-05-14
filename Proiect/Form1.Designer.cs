
namespace Proiect
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
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.model1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.model2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.model3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(232, 190);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(63, 17);
            this.lblUtilizator.TabIndex = 0;
            this.lblUtilizator.Text = "Utilizator";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(232, 239);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(49, 17);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(301, 236);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(137, 22);
            this.txtParola.TabIndex = 2;
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(301, 190);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(137, 22);
            this.txtUtilizator.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(355, 324);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Log In";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.model1ToolStripMenuItem,
            this.model2ToolStripMenuItem,
            this.model3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // model1ToolStripMenuItem
            // 
            this.model1ToolStripMenuItem.Name = "model1ToolStripMenuItem";
            this.model1ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.model1ToolStripMenuItem.Text = "Model 1 - Medicamente";
            this.model1ToolStripMenuItem.Click += new System.EventHandler(this.model1ToolStripMenuItem_Click);
            // 
            // model2ToolStripMenuItem
            // 
            this.model2ToolStripMenuItem.Name = "model2ToolStripMenuItem";
            this.model2ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.model2ToolStripMenuItem.Text = "Model 2 - Pacienti";
            this.model2ToolStripMenuItem.Click += new System.EventHandler(this.model2ToolStripMenuItem_Click);
            // 
            // model3ToolStripMenuItem
            // 
            this.model3ToolStripMenuItem.Name = "model3ToolStripMenuItem";
            this.model3ToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.model3ToolStripMenuItem.Text = "Model 3 - Retete";
            this.model3ToolStripMenuItem.Click += new System.EventHandler(this.model3ToolStripMenuItem_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(34, 64);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(544, 25);
            this.lblTitlu.TabIndex = 6;
            this.lblTitlu.Text = "Aplicatie pt. retetele pacientilor dintr-un cabinet medical";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(438, 109);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(140, 20);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "Zaharia Anamaria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Proiect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.ToolStripMenuItem model1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem model2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem model3ToolStripMenuItem;
    }
}

