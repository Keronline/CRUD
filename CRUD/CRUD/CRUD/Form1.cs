using MongoDB.Driver;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;



namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conect = new SqlConnection("Data Source=DESKTOP-F8434JD\\SQLEXPRESS;Initial Catalog=BD_CRUD;Integrated Security=True");
            conect.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_ProductInfo values ('"+int.Parse(textBox1.Text)+"', '" + textBox2.Text + "', '"+comboBox1.Text +"', getdate())", conect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted!");
            conect.Close();
        }
    }
}