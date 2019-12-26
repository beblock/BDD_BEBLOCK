namespace BDD_BEBLOCK
{
    partial class Form2
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
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_betail = new System.Windows.Forms.Button();
            this.btn_compta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(308, 399);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(125, 29);
            this.btn_quitter.TabIndex = 0;
            this.btn_quitter.Text = "button1";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_betail
            // 
            this.btn_betail.Location = new System.Drawing.Point(308, 346);
            this.btn_betail.Name = "btn_betail";
            this.btn_betail.Size = new System.Drawing.Size(125, 34);
            this.btn_betail.TabIndex = 1;
            this.btn_betail.Text = "button1";
            this.btn_betail.UseVisualStyleBackColor = true;
            this.btn_betail.Click += new System.EventHandler(this.btn_betail_Click);
            // 
            // btn_compta
            // 
            this.btn_compta.Location = new System.Drawing.Point(308, 301);
            this.btn_compta.Name = "btn_compta";
            this.btn_compta.Size = new System.Drawing.Size(125, 33);
            this.btn_compta.TabIndex = 2;
            this.btn_compta.Text = "button1";
            this.btn_compta.UseVisualStyleBackColor = true;
            this.btn_compta.Click += new System.EventHandler(this.btn_compta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 457);
            this.Controls.Add(this.btn_compta);
            this.Controls.Add(this.btn_betail);
            this.Controls.Add(this.btn_quitter);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_betail;
        private System.Windows.Forms.Button btn_compta;
    }
}