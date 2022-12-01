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
    public partial class Destytojas : Form
    {
        public Destytojas()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Praktinis;Integrated Security=True");
        private void AtsijungtiDest_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Ar tikrai norite atsijungti nuo sistemos?", "Uždaryti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void Destytojas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StudVardas.Text == "" || StudPavarde.Text == "" || StudGrupė.Text == "" || StudDalykas.Text == "" || PažymysDest.Text == "")
            {
                MessageBox.Show("Trūksta informacijos");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into StudentTBL2(StVardas,StPavardė,StGrupė,StDalykas,StPažymys,StMetai) values (@SVardas,@SPavardė,@SGrupė,@SDalykas,@SPažymys,@SMetai)", Con);
                    cmd.Parameters.AddWithValue("@SPažymys", PažymysDest.Text);
                    cmd.Parameters.AddWithValue("@SVardas", StudVardas.Text);
                    cmd.Parameters.AddWithValue("@SPavardė", StudPavarde.Text);
                    cmd.Parameters.AddWithValue("@SGrupė", StudGrupė.Text);
                    cmd.Parameters.AddWithValue("@SMetai", StudMetai.Value.Date);
                    cmd.Parameters.AddWithValue("@SDalykas", StudDalykas.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pažymys Pridėtas");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reset()
        {
            key = 0;
            StudVardas.Text = "";
            StudPavarde.Text = "";
            StudGrupė.Text = "";
            StudDalykas.Text = "";
            PažymysDest.Text = "";
            StudMetai.Text = "";

        }
        
        int key = 0;
        private void StudentsDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudVardas.Text = StudentsDVG.SelectedRows[0].Cells[1].Value.ToString();
            StudPavarde.Text = StudentsDVG.SelectedRows[0].Cells[2].Value.ToString();
            StudGrupė.Text = StudentsDVG.SelectedRows[0].Cells[3].Value.ToString();
            StudDalykas.Text = StudentsDVG.SelectedRows[0].Cells[4].Value.ToString();
          //  StudMetai.Text = StudentsDVG.SelectedRows[0].Cells[5].Value.ToString();
            PažymysDest.Text = StudentsDVG.SelectedRows[0].Cells[6].Value.ToString();
            if (StudVardas.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StudentsDVG.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTBL2";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (StudVardas.Text == "" || StudPavarde.Text == "" || StudGrupė.Text == "" || StudDalykas.Text == "" || PažymysDest.Text == "")
            {
                MessageBox.Show("Trūksta informacijos");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("Update StudentTBL2 set StPažymys=@SPažymys", Con);
                    cmd.Parameters.AddWithValue("@SPažymys", PažymysDest.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Studentas Atnaujintas");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Pasirinkite studentą kurio pažymį norite ištrinti");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from StudentTBL2 where Stdid= @Stkey", Con);
                    cmd.Parameters.AddWithValue("@Stkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pažymys Panaikintas");

                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
