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
    public partial class Dėstytojai : Form
    {
        public Dėstytojai()
        {
            InitializeComponent();
            DisplayDestytojai();
        }

        //Prijungia duomenų bazę
        SqlConnection Con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Praktinis;Integrated Security=True");


        //Pakrovos langą rodo Dėstytojų lentelę
        private void DisplayDestytojai()
        {
            Con.Open();
            string Query = "Select * from DestytTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DestDVG.DataSource = ds.Tables[0];
            Con.Close();
        }


        //Grįžimo mygtukas
        private void Grįžti1_Click(object sender, EventArgs e)
        {
            Adminas form3 = new Adminas();
            form3.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Dėstytojų lentelės duomenų pakrovimas
        private void Dėstytojai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktinisDataSet9.DestytTBL' table. You can move, or remove it, as needed.
            this.destytTBLTableAdapter.Fill(this.praktinisDataSet9.DestytTBL);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Duomenų lentelės restartavimas
        private void Reset()
        {
            key = 0;
            DestVardas.Text = "";
            DestPavarde.Text = "";
            DestDalykai.Text = "";
            DestMetai.Text = "";
        }


      //Dėstytojo pridėjimas
        private void PridetiDest_Click(object sender, EventArgs e)
        {
            if (DestVardas.Text == "" || DestPavarde.Text == "" || DestDalykai.Text == "" || DestMetai.Text == "")
            {
                MessageBox.Show("Trūksta informacijos");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into DestytTBL(VardasD,PavardėD,DalykaiD,MetaiD) values (@DVardas,@DPavardė,@DGrupė,@DMetai)", Con);
                    cmd.Parameters.AddWithValue("@DVardas", DestVardas.Text);
                    cmd.Parameters.AddWithValue("@DPavardė", DestPavarde.Text);
                    cmd.Parameters.AddWithValue("@DGrupė", DestDalykai.Text);
                    cmd.Parameters.AddWithValue("@DMetai", DestMetai.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dėstytojas Pridėtas");
                    Con.Close();
                    DisplayDestytojai();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        //Dėstytojo ištrynimas
        private void IstrintiDest_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Pasirinkite Dėstytoją");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from DestytTBL where Id= @Dtkey", Con);
                    cmd.Parameters.AddWithValue("@Dtkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dėstytojas Panaikintas");

                    Con.Close();
                    DisplayDestytojai();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        //Dėstytojo redagavimas
        private void RedaguotiDest_Click(object sender, EventArgs e)
        {
            if (DestVardas.Text == "" || DestPavarde.Text == "" || DestDalykai.Text == "")
            {
                MessageBox.Show("Trūksta informacijos");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("Update DestytTBL set VardasD=@DVardas,PavardėD=@DPavardė,DalykaiD=@DDalykai,MetaiD=@DMetai", Con);
                    cmd.Parameters.AddWithValue("@DVardas", DestVardas.Text);
                    cmd.Parameters.AddWithValue("@DPavardė", DestPavarde.Text);
                    cmd.Parameters.AddWithValue("@DDalykai", DestDalykai.Text);
                    cmd.Parameters.AddWithValue("@DMetai", DestMetai.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dėstytojas Atnaujintas");
                    Con.Close();
                    DisplayDestytojai();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;


        //Dėstytojo pasirinkimas
        private void DestDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               DestVardas.Text = DestDVG.SelectedRows[0].Cells[1].Value.ToString();
               DestPavarde.Text = DestDVG.SelectedRows[0].Cells[2].Value.ToString();
               DestDalykai.Text = DestDVG.SelectedRows[0].Cells[3].Value.ToString();
               DestMetai.Text = DestDVG.SelectedRows[0].Cells[4].Value.ToString();
                if (DestVardas.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(DestDVG.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            
        }
    }
    

