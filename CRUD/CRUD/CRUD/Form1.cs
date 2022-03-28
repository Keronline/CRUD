using System.Data;
using System.Data.SqlClient;



namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-F8434JD\\SQLEXPRESS;Initial Catalog=BD_CRUD;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from Table_ProductInfo", conect);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
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
            conect.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_ProductInfo values ('" + int.Parse(textBox1.Text) + "', '" + textBox2.Text + "', '" + comboBox1.Text + "', getdate())", conect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted!");
            conect.Close();
            BindData();
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            conect.Open();
            SqlCommand cmd = new SqlCommand("update Table_ProductInfo set ItemName = '" + textBox2.Text + "', Color = '" + comboBox1.Text + "',UpdateDate = 'getdate()' where ProductID= '" + int.Parse(textBox1.Text) + "'", conect);
            cmd.ExecuteNonQuery();
            conect.Close();
            MessageBox.Show("!Successfully  UpDate");*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}