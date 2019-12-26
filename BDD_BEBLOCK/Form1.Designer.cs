namespace BDD_BEBLOCK
{
    partial class frm_Ajouter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Ajout = new System.Windows.Forms.Button();
            this.edt_boucle = new System.Windows.Forms.TextBox();
            this.edt_naissance = new System.Windows.Forms.TextBox();
            this.edt_pipi = new System.Windows.Forms.TextBox();
            this.edt_caca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Actualiser = new System.Windows.Forms.Button();
            this.lbl_Boucle = new System.Windows.Forms.Label();
            this.lbl_naissance = new System.Windows.Forms.Label();
            this.lbl_caca = new System.Windows.Forms.Label();
            this.lbl_pipi = new System.Windows.Forms.Label();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_modifie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ajout
            // 
            this.btn_Ajout.Location = new System.Drawing.Point(473, 193);
            this.btn_Ajout.Name = "btn_Ajout";
            this.btn_Ajout.Size = new System.Drawing.Size(224, 32);
            this.btn_Ajout.TabIndex = 4;
            this.btn_Ajout.Text = "button1";
            this.btn_Ajout.UseVisualStyleBackColor = true;
            this.btn_Ajout.Click += new System.EventHandler(this.btn_Ajout_Click);
            // 
            // edt_boucle
            // 
            this.edt_boucle.Location = new System.Drawing.Point(594, 12);
            this.edt_boucle.Name = "edt_boucle";
            this.edt_boucle.Size = new System.Drawing.Size(103, 20);
            this.edt_boucle.TabIndex = 0;
            // 
            // edt_naissance
            // 
            this.edt_naissance.Location = new System.Drawing.Point(594, 54);
            this.edt_naissance.Name = "edt_naissance";
            this.edt_naissance.Size = new System.Drawing.Size(103, 20);
            this.edt_naissance.TabIndex = 1;
            this.edt_naissance.Text = "yyyy-mm-jj";
            // 
            // edt_pipi
            // 
            this.edt_pipi.Location = new System.Drawing.Point(594, 139);
            this.edt_pipi.Name = "edt_pipi";
            this.edt_pipi.Size = new System.Drawing.Size(103, 20);
            this.edt_pipi.TabIndex = 3;
            this.edt_pipi.Text = "yyyy-mm-jj";
            // 
            // edt_caca
            // 
            this.edt_caca.Location = new System.Drawing.Point(594, 97);
            this.edt_caca.Name = "edt_caca";
            this.edt_caca.Size = new System.Drawing.Size(103, 20);
            this.edt_caca.TabIndex = 2;
            this.edt_caca.Text = "yyyy-mm-jj";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 404);
            this.dataGridView1.TabIndex = 1555;
            // 
            // btn_Actualiser
            // 
            this.btn_Actualiser.Location = new System.Drawing.Point(473, 231);
            this.btn_Actualiser.Name = "btn_Actualiser";
            this.btn_Actualiser.Size = new System.Drawing.Size(224, 31);
            this.btn_Actualiser.TabIndex = 6;
            this.btn_Actualiser.UseVisualStyleBackColor = true;
            this.btn_Actualiser.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Boucle
            // 
            this.lbl_Boucle.AutoSize = true;
            this.lbl_Boucle.Location = new System.Drawing.Point(473, 15);
            this.lbl_Boucle.Name = "lbl_Boucle";
            this.lbl_Boucle.Size = new System.Drawing.Size(35, 13);
            this.lbl_Boucle.TabIndex = 7;
            this.lbl_Boucle.Text = "label1";
            // 
            // lbl_naissance
            // 
            this.lbl_naissance.AutoSize = true;
            this.lbl_naissance.Location = new System.Drawing.Point(473, 57);
            this.lbl_naissance.Name = "lbl_naissance";
            this.lbl_naissance.Size = new System.Drawing.Size(35, 13);
            this.lbl_naissance.TabIndex = 8;
            this.lbl_naissance.Text = "label2";
            // 
            // lbl_caca
            // 
            this.lbl_caca.AutoSize = true;
            this.lbl_caca.Location = new System.Drawing.Point(473, 100);
            this.lbl_caca.Name = "lbl_caca";
            this.lbl_caca.Size = new System.Drawing.Size(35, 13);
            this.lbl_caca.TabIndex = 9;
            this.lbl_caca.Text = "label3";
            // 
            // lbl_pipi
            // 
            this.lbl_pipi.AutoSize = true;
            this.lbl_pipi.Location = new System.Drawing.Point(473, 142);
            this.lbl_pipi.Name = "lbl_pipi";
            this.lbl_pipi.Size = new System.Drawing.Size(35, 13);
            this.lbl_pipi.TabIndex = 10;
            this.lbl_pipi.Text = "label4";
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(473, 368);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(224, 37);
            this.btn_Quitter.TabIndex = 1556;
            this.btn_Quitter.Text = "button1";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // btn_modifie
            // 
            this.btn_modifie.Location = new System.Drawing.Point(473, 319);
            this.btn_modifie.Name = "btn_modifie";
            this.btn_modifie.Size = new System.Drawing.Size(224, 43);
            this.btn_modifie.TabIndex = 1557;
            this.btn_modifie.Text = "button1";
            this.btn_modifie.UseVisualStyleBackColor = true;
            this.btn_modifie.Click += new System.EventHandler(this.btn_modifie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1558;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_modifie);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.lbl_pipi);
            this.Controls.Add(this.lbl_caca);
            this.Controls.Add(this.lbl_naissance);
            this.Controls.Add(this.lbl_Boucle);
            this.Controls.Add(this.btn_Actualiser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.edt_caca);
            this.Controls.Add(this.edt_pipi);
            this.Controls.Add(this.edt_naissance);
            this.Controls.Add(this.edt_boucle);
            this.Controls.Add(this.btn_Ajout);
            this.Name = "frm_Ajouter";
            this.Load += new System.EventHandler(this.frm_Ajouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ajout;
        private System.Windows.Forms.TextBox edt_boucle;
        private System.Windows.Forms.TextBox edt_naissance;
        private System.Windows.Forms.TextBox edt_pipi;
        private System.Windows.Forms.TextBox edt_caca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Actualiser;
        private System.Windows.Forms.Label lbl_Boucle;
        private System.Windows.Forms.Label lbl_naissance;
        private System.Windows.Forms.Label lbl_caca;
        private System.Windows.Forms.Label lbl_pipi;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_modifie;
        private System.Windows.Forms.Button button1;
    }
}

