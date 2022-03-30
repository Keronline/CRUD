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

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F8434JD\\SQLEXPRESS;Initial Catalog=BD_CRUD;Integrated Security=True");

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Table_ProductInfo", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
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
            con.Open();
            SqlCommand command = new SqlCommand("insert into Table_ProductInfo values ('" + int.Parse(textBox1.Text) + "', '" + textBox2.Text + "', '" + comboBox1.Text + "', getdate())", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted!");
            con.Close();
            BindData();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete Table_ProductInfo where ProductID= '" + int.Parse(textBox1.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put Product");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            con.Open();
            SqlCommand command = new SqlCommand("update Table_ProductInfo set ItemName = '" + textBox2.Text + "', Color = '" + comboBox1.Text + "',UpdateDate = '" +DateTime.Parse(dateTimePicker1.Text)+ "' where ProductID= '" + int.Parse(textBox1.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("!Successfully  UpDate");*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Table_ProductInfo where ProductID='"+int.Parse(textBox1.Text)+ "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}