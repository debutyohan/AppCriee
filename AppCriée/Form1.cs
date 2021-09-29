using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCriée
{
    public partial class AppCriee : Form
    {
        string chaineConnexion;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        public AppCriee()
        {
            ChaineConnexion = "server=localhost;user id=root;database=bddcrie2";
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            SqlConnection con = new SqlConnection("server=localhost;user id=root;database=bddcrie2");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From utilisateur where login'" + textBox1.Text + "' and pwd = '" + textBox2.Text +"'", con);
            DataTable dt = new DataTable();
            
          if (dt.Rows[0][0].ToString() == "1")
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                label4.Visible = true;
            }
         */
            String passwdhash = new HashData(textBox2.Text).HashCalculate();
            CURS cs = new CURS(chaineConnexion);
            string requete = "SELECT count(id) as nbUser FROM utilisateur WHERE login='" + textBox1.Text + "' AND pwd='" + passwdhash + "'";
            cs.ReqSelect(requete);
            string nbUser = cs.champ("nbUser").ToString();

            if (nbUser == "1")
            {
                /*Form2 f = new Form2();
                f.Show();
                this.Hide();
                label4.Visible = true;*/
            }
            else
            {
                label4.Visible = true;
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
