namespace BDD_BEBLOCK
{
    partial class frm_compta
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
            this.lbl_beneficiaire = new System.Windows.Forms.Label();
            this.grp_Entree = new System.Windows.Forms.GroupBox();
            this.lbl_domaine = new System.Windows.Forms.Label();
            this.cbox_domaine = new System.Windows.Forms.ComboBox();
            this.edt_net = new System.Windows.Forms.TextBox();
            this.edt_brut = new System.Windows.Forms.TextBox();
            this.lbl_net = new System.Windows.Forms.Label();
            this.lbl_brut = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.edt_date = new System.Windows.Forms.TextBox();
            this.edt_compte = new System.Windows.Forms.TextBox();
            this.lbl_compte = new System.Windows.Forms.Label();
            this.edt_beneficiare = new System.Windows.Forms.TextBox();
            this.dt_compte = new System.Windows.Forms.DataGridView();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.grp_Entree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_compte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_beneficiaire
            // 
            this.lbl_beneficiaire.AutoSize = true;
            this.lbl_beneficiaire.Location = new System.Drawing.Point(12, 44);
            this.lbl_beneficiaire.Name = "lbl_beneficiaire";
            this.lbl_beneficiaire.Size = new System.Drawing.Size(56, 13);
            this.lbl_beneficiaire.TabIndex = 0;
            this.lbl_beneficiaire.Text = "Nombenef";
            // 
            // grp_Entree
            // 
            this.grp_Entree.Controls.Add(this.btn_ajouter);
            this.grp_Entree.Controls.Add(this.dt_compte);
            this.grp_Entree.Controls.Add(this.lbl_domaine);
            this.grp_Entree.Controls.Add(this.cbox_domaine);
            this.grp_Entree.Controls.Add(this.edt_net);
            this.grp_Entree.Controls.Add(this.edt_brut);
            this.grp_Entree.Controls.Add(this.lbl_net);
            this.grp_Entree.Controls.Add(this.lbl_brut);
            this.grp_Entree.Controls.Add(this.lbl_date);
            this.grp_Entree.Controls.Add(this.edt_date);
            this.grp_Entree.Controls.Add(this.edt_compte);
            this.grp_Entree.Controls.Add(this.lbl_compte);
            this.grp_Entree.Controls.Add(this.edt_beneficiare);
            this.grp_Entree.Controls.Add(this.lbl_beneficiaire);
            this.grp_Entree.Location = new System.Drawing.Point(12, 12);
            this.grp_Entree.Name = "grp_Entree";
            this.grp_Entree.Size = new System.Drawing.Size(490, 444);
            this.grp_Entree.TabIndex = 1;
            this.grp_Entree.TabStop = false;
            this.grp_Entree.Text = "groupBox1";
            // 
            // lbl_domaine
            // 
            this.lbl_domaine.AutoSize = true;
            this.lbl_domaine.Location = new System.Drawing.Point(12, 219);
            this.lbl_domaine.Name = "lbl_domaine";
            this.lbl_domaine.Size = new System.Drawing.Size(35, 13);
            this.lbl_domaine.TabIndex = 11;
            this.lbl_domaine.Text = "label3";
            // 
            // cbox_domaine
            // 
            this.cbox_domaine.FormattingEnabled = true;
            this.cbox_domaine.Location = new System.Drawing.Point(160, 216);
            this.cbox_domaine.Name = "cbox_domaine";
            this.cbox_domaine.Size = new System.Drawing.Size(151, 21);
            this.cbox_domaine.TabIndex = 10;
            // 
            // edt_net
            // 
            this.edt_net.Location = new System.Drawing.Point(160, 181);
            this.edt_net.Name = "edt_net";
            this.edt_net.Size = new System.Drawing.Size(151, 20);
            this.edt_net.TabIndex = 9;
            // 
            // edt_brut
            // 
            this.edt_brut.Location = new System.Drawing.Point(160, 146);
            this.edt_brut.Name = "edt_brut";
            this.edt_brut.Size = new System.Drawing.Size(151, 20);
            this.edt_brut.TabIndex = 8;
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.Location = new System.Drawing.Point(12, 184);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(35, 13);
            this.lbl_net.TabIndex = 7;
            this.lbl_net.Text = "label2";
            // 
            // lbl_brut
            // 
            this.lbl_brut.AutoSize = true;
            this.lbl_brut.Location = new System.Drawing.Point(12, 149);
            this.lbl_brut.Name = "lbl_brut";
            this.lbl_brut.Size = new System.Drawing.Size(35, 13);
            this.lbl_brut.TabIndex = 6;
            this.lbl_brut.Text = "label1";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 114);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(35, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "label1";
            // 
            // edt_date
            // 
            this.edt_date.Location = new System.Drawing.Point(160, 111);
            this.edt_date.Name = "edt_date";
            this.edt_date.Size = new System.Drawing.Size(151, 20);
            this.edt_date.TabIndex = 4;
            // 
            // edt_compte
            // 
            this.edt_compte.Location = new System.Drawing.Point(160, 76);
            this.edt_compte.Multiline = true;
            this.edt_compte.Name = "edt_compte";
            this.edt_compte.Size = new System.Drawing.Size(151, 20);
            this.edt_compte.TabIndex = 3;
            // 
            // lbl_compte
            // 
            this.lbl_compte.AutoSize = true;
            this.lbl_compte.Location = new System.Drawing.Point(12, 79);
            this.lbl_compte.Name = "lbl_compte";
            this.lbl_compte.Size = new System.Drawing.Size(35, 13);
            this.lbl_compte.TabIndex = 2;
            this.lbl_compte.Text = "label1";
            // 
            // edt_beneficiare
            // 
            this.edt_beneficiare.Location = new System.Drawing.Point(160, 41);
            this.edt_beneficiare.Name = "edt_beneficiare";
            this.edt_beneficiare.Size = new System.Drawing.Size(151, 20);
            this.edt_beneficiare.TabIndex = 1;
            // 
            // dt_compte
            // 
            this.dt_compte.AllowUserToOrderColumns = true;
            this.dt_compte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_compte.Location = new System.Drawing.Point(0, 288);
            this.dt_compte.Name = "dt_compte";
            this.dt_compte.Size = new System.Drawing.Size(375, 150);
            this.dt_compte.TabIndex = 12;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(345, 28);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(139, 44);
            this.btn_ajouter.TabIndex = 13;
            this.btn_ajouter.Text = "button1";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // frm_compta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 468);
            this.Controls.Add(this.grp_Entree);
            this.Name = "frm_compta";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frm_compta_Load);
            this.grp_Entree.ResumeLayout(false);
            this.grp_Entree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_compte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_beneficiaire;
        private System.Windows.Forms.GroupBox grp_Entree;
        private System.Windows.Forms.Label lbl_domaine;
        private System.Windows.Forms.ComboBox cbox_domaine;
        private System.Windows.Forms.TextBox edt_net;
        private System.Windows.Forms.TextBox edt_brut;
        private System.Windows.Forms.Label lbl_net;
        private System.Windows.Forms.Label lbl_brut;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox edt_date;
        private System.Windows.Forms.TextBox edt_compte;
        private System.Windows.Forms.Label lbl_compte;
        private System.Windows.Forms.TextBox edt_beneficiare;
        private System.Windows.Forms.DataGridView dt_compte;
        private System.Windows.Forms.Button btn_ajouter;
    }
}