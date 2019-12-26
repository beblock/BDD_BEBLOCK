using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BDD_BEBLOCK
{
    public partial class frm_compta : Form
    {
        public frm_compta()
        {
            InitializeComponent();
        }

        private void frm_compta_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            lbl_beneficiaire.Text = "Nom du bénéficiaire :";
            lbl_brut.Text = "Montant Brut :";
            lbl_compte.Text = "Compte :";
            lbl_date.Text = "Date de facturation :";
            lbl_domaine.Text = "Utilité :";
            lbl_net.Text = "Montant Net :";
            grp_Entree.Text = "Nouvelle entrée";

            lbl_net.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_domaine.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_date.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_compte.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_brut.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_beneficiaire.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_beneficiaire.ForeColor = Color.DarkSalmon;
            lbl_brut.ForeColor = Color.DarkSalmon;
            lbl_compte.ForeColor = Color.DarkSalmon;
            lbl_net.ForeColor = Color.DarkSalmon;
            lbl_domaine.ForeColor = Color.DarkSalmon;
            lbl_date.ForeColor = Color.DarkSalmon;
            grp_Entree.ForeColor = Color.DarkSalmon;

            MySqlConnection Conex = new MySqlConnection();
            Conex.ConnectionString = "Server=192.168.1.6;Database=Comptabilite;user=caca;password=caca;Convert Zero Datetime=True";
            MySqlCommand CommandLoad = new MySqlCommand("select*From Comptabilite.Compte;", Conex);
            Conex.Open();
            try
            {
                MySqlDataAdapter ada = new MySqlDataAdapter();
                ada.SelectCommand = CommandLoad;
                DataTable dbdataset = new DataTable();
                ada.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dt_compte.DataSource = bSource;
                ada.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            if ((edt_beneficiare.Text == "") || (edt_brut.Text == "") || (edt_compte.Text == "")|| (edt_date.Text == "") ||(edt_net.Text == "" ))
            {
                MessageBox.Show("Champs Non rempli");

            }
            else
            {


                MySqlConnection Conex = new MySqlConnection();
                Conex.ConnectionString = "Server=192.168.1.6;Database=Comptabilite;user=caca;password=caca;Convert Zero Datetime=True";

                Conex.Open();
                try
                {
                    MySqlCommand Command = new MySqlCommand();
                    Command.Connection = Conex;
                    Command.CommandText = "INSERT INTO Compte VALUES (@Nom,@Net,@Brut,@Compte,@date)";
                    Command.Parameters.Add(new MySqlParameter("@Nom", edt_beneficiare.Text));
                    Command.Parameters.Add(new MySqlParameter("@Net", edt_net.Text));
                    Command.Parameters.Add(new MySqlParameter("@Brut", edt_brut.Text));
                    Command.Parameters.Add(new MySqlParameter("@Compte", edt_compte.Text));
                    Command.Parameters.Add(new MySqlParameter("@date", edt_date.Text));

                    Command.ExecuteNonQuery();
                    MessageBox.Show("Facture Ajouté", "Ok");


                }
                catch (MySqlException exp)
                {
                    MessageBox.Show(exp.Message);

                }
                finally
                {
                    Conex.Close();
                }
            }
        }
    }
}
