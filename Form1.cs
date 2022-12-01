using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktinis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Praktinis;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            String prisijungimo_vardas, slaptazodis;

            prisijungimo_vardas = txt_prisijungimas.Text;
            slaptazodis = txt_slaptazodis.Text;

            try
            {
                string querry = "SELECT * FROM Prisijungimas_nauja WHERE Prisijungimo_vardas = '" +txt_prisijungimas.Text+ "' AND Slaptazodis = '"+txt_slaptazodis.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    prisijungimo_vardas = txt_prisijungimas.Text;
                    slaptazodis = txt_slaptazodis.Text;

                   
                        Adminas form3 = new Adminas();
                        form3.Show();
                        this.Hide();
                
                }

                else
                {
                    MessageBox.Show("Neteisingi prisijungimo duomenys", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_prisijungimas.Clear();
                    txt_slaptazodis.Clear();

                    txt_prisijungimas.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Klaida");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Uždaryti_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Ar tikrai norite išeiti?", "Uždaryti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void chkMatytiSlepti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatytiSlepti.Checked)
            {
                txt_slaptazodis.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Rodyti slaptažodį";
            }
            else
            {
                txt_slaptazodis.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Paslėpti slaptažodį";
            }
        }

        private void PrisijungtiDest_Click(object sender, EventArgs e)
        {
            String VardasD, PavardėD;

            VardasD = txt_prisijungimasDest.Text;
            PavardėD = txt_slaptazodisDest.Text;

            try
            {
                string querry = "SELECT * FROM DestytTBL WHERE VardasD = '" + txt_prisijungimasDest.Text + "' AND PavardėD = '" + txt_slaptazodisDest.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    VardasD = txt_prisijungimasDest.Text;
                    PavardėD = txt_slaptazodisDest.Text;


                    Destytojas form4 = new Destytojas();
                    form4.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Neteisingi prisijungimo duomenys", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_prisijungimasDest.Clear();
                    txt_slaptazodisDest.Clear();

                    txt_prisijungimasDest.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Klaida");
            }
            finally
            {
                conn.Close();
            }
        }

        private void PrisijungtiStud_Click(object sender, EventArgs e)
        {
            String StVardas, StPavardė;

            StVardas = txt_prisijungimasStud.Text;
            StPavardė = txt_slaptazodisStud.Text;

            

            try
            {
                string querry = "SELECT * FROM StudentTbl WHERE StVardas = '" + txt_prisijungimasStud.Text + "' AND StPavardė = '" + txt_slaptazodisStud.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    StVardas = txt_prisijungimasStud.Text;
                    StPavardė = txt_slaptazodisStud.Text;


                    Studentas form5 = new Studentas();
                    form5.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Neteisingi prisijungimo duomenys", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_prisijungimasStud.Clear();
                    txt_slaptazodisStud.Clear();

                    txt_prisijungimasStud.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Klaida");
            }
            finally
            {
                conn.Close();
            }
        }

        private void chkMatytiSlepti2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatytiSlepti2.Checked)
            {
                txt_slaptazodisDest.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Rodyti slaptažodį";
            }
            else
            {
                txt_slaptazodisDest.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Paslėpti slaptažodį";
            }
        }

        private void chkMatytiSlepti3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatytiSlepti3.Checked)
            {
                txt_slaptazodisStud.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Rodyti slaptažodį";
            }
            else
            {
                txt_slaptazodisStud.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Paslėpti slaptažodį";
            }
        }

        private void txt_prisijungimas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
