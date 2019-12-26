using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_BEBLOCK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_betail_Click(object sender, EventArgs e)
        {
            frm_Ajouter frm = new frm_Ajouter();
            frm.Show();

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btn_compta.Text = " Comptabilité";
            btn_betail.Text = "Ajoutez Bétails";
            btn_quitter.Text = "Quitter";
            this.BackgroundImage = Properties.Resources.wood_forest;
            this.FormBorderStyle = FormBorderStyle.FixedSingle ;
            
           
 
    
        }

        private void btn_compta_Click(object sender, EventArgs e)
        {
            frm_compta frm = new frm_compta();
            frm.Show();
        }
    }
}
