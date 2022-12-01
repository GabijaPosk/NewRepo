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
    public partial class Studentas : Form
    {
        public Studentas()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Praktinis;Integrated Security=True");

        private void AtsijungtiStud_Click(object sender, EventArgs e)
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

        private void Studentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktinisDataSet10.StudentTBL2' table. You can move, or remove it, as needed.
            
            this.studentTBL2TableAdapter.Fill(this.praktinisDataSet10.StudentTBL2);
        }
    }
}
