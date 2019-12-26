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
    

    public partial class frm_Ajouter : Form
    {
       
        public frm_Ajouter()
        {
            InitializeComponent();
            
        }

        private void btn_Ajout_Click(object sender, EventArgs e)
        {
            int value;
            DateTime tempoo;
            DateTime tempo;
            DateTime temp;
            string x = edt_boucle.Text;
            string y = edt_naissance.Text;
            string z = edt_caca.Text;
            string lol = edt_pipi.Text;
            if (int.TryParse(x, out value))
            {
                if ((DateTime.TryParse(y, out temp)) & (DateTime.TryParse(z,out tempo)) & (DateTime.TryParse(lol,out tempoo)))
                {

                    MySqlConnection Conex = new MySqlConnection();
                    Conex.ConnectionString = "Server=192.168.1.4;Database=Ferme;user=caca;password=caca";

                    Conex.Open();
                    try
                    {
                        MySqlCommand Command = new MySqlCommand();
                        Command.Connection = Conex;
                        Command.CommandText = "INSERT INTO Vache VALUES (@Boucle,@Naissance,@Caca,@Pipi)";
                        Command.Parameters.Add(new MySqlParameter("@Naissance", edt_naissance.Text));
                        Command.Parameters.Add(new MySqlParameter("@Pipi", edt_pipi.Text));
                        Command.Parameters.Add(new MySqlParameter("@Caca", edt_caca.Text));
                        Command.Parameters.Add(new MySqlParameter("@Boucle", edt_boucle.Text));
                        Command.ExecuteNonQuery();
                        MessageBox.Show("Bétail Ajouté", "Ok");


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
                else
                {
                    MessageBox.Show("Nique toi ");

                }

            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre entier!");
            }

        }

        
        private void frm_Ajouter_Load(object sender, EventArgs e)
        {
            // Changement Couleur Fond Form_01 //
            this.BackColor = Color.FromArgb(30, 30, 30);

            //Changement Text //
            btn_Ajout.Text = "Ajouter";
            this.Text = "Ajouter Bétail";
            btn_Actualiser.Text = "Actualiser";
            lbl_Boucle.Text = "Numéro Boucle :";
            lbl_caca.Text = "Insemination :";
            lbl_pipi.Text = "Vélage :";
            lbl_naissance.Text = "Date Naissance :";
            btn_Quitter.Text = "Menu principal";
            btn_modifie.Text = "Mise à jour Data";
            button1.Text = "Filtre";
            

            // Couleur & Police Label //
            lbl_Boucle.Font = new Font("Comic sans ms",8, FontStyle.Bold);
            lbl_naissance.Font = new Font("Comic sans ms", 8,FontStyle.Bold);
            lbl_caca.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_pipi.Font = new Font("Comic sans ms", 8, FontStyle.Bold);
            lbl_pipi.ForeColor = Color.DarkSalmon;
            lbl_naissance.ForeColor = Color.DarkSalmon;
            lbl_caca.ForeColor = Color.DarkSalmon;
            lbl_Boucle.ForeColor = Color.DarkSalmon;

            //Changement couleur datagridWiew1//
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(4, 99, 128);
            // Initialisation du DataGridView//
            MySqlConnection Conex = new MySqlConnection();
            Conex.ConnectionString = "Server=192.168.1.4;Database=Ferme;user=caca;password=caca;Convert Zero Datetime=True";
            MySqlCommand CommandLoad = new MySqlCommand("select*FROM Ferme.Vache;", Conex);
            Conex.Open();

            try
            {
                MySqlDataAdapter ada = new MySqlDataAdapter();
                ada.SelectCommand = CommandLoad;
                DataTable dbdataset = new DataTable();
                ada.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                ada.Update(dbdataset);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Conex = new MySqlConnection();
            Conex.ConnectionString = "Server=192.168.1.4;Database=Ferme;user=caca;password=caca";
            MySqlCommand CommandLoad = new MySqlCommand("select*FROM Ferme.Vache.;",Conex);
            Conex.Open();
            try
            {
                MySqlDataAdapter ada = new MySqlDataAdapter();
                ada.SelectCommand = CommandLoad;
                DataTable dbdataset = new DataTable();
                ada.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                ada.Update(dbdataset);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_modifie_Click(object sender, EventArgs e)
        {
            if ((edt_naissance.Text == "") || (edt_caca.Text == "") || (edt_pipi.Text == ""))
            {
                MessageBox.Show("Champs Non rempli");
                
            }
            else
            {
                MySqlConnection Conex = new MySqlConnection();
                Conex.ConnectionString = "Server=192.168.1.4;Database=Ferme;user=caca;password=caca";

                Conex.Open();
                try
                {
                    MySqlCommand Command = new MySqlCommand();
                    Command.Connection = Conex;
                    Command.CommandText = "Insert Ferme.Vache set Boucle = '" + this.edt_boucle.Text + "',Naissance = '" + this.edt_naissance.Text + "',Insemination = '" + this.edt_caca.Text + "',Velage = '" + this.edt_pipi.Text + "' where Boucle = '" + this.edt_boucle.Text + "'; ";
                    Command.Parameters.AddWithValue("@Boucle", edt_boucle.Text);
                    Command.Parameters.AddWithValue("@Naissance", edt_naissance.Text);
                    Command.Parameters.AddWithValue("@Pipi", edt_pipi.Text);
                    Command.Parameters.AddWithValue("@Caca", edt_caca.Text);

                    Command.ExecuteNonQuery();
                    MessageBox.Show("Bétail :Mise à jour", "Ok");


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

        private void button1_Click_1(object sender, EventArgs e)
        {
            BindingSource dSource = new BindingSource();
            dSource.DataSource = this.dataGridView1.DataSource;
            dSource.Filter = "Boucle like '1%'";

        }
    }
}
