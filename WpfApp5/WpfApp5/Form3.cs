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

namespace WpfApp5
{
    public partial class Form3 : Form
    { SqlConnection con = new SqlConnection(@"Data Source=ADMIN-ПК\MEGAHYPER;Initial Catalog=school;Integrated Security=True");
        
        public Form3()
        {
            InitializeComponent();
        }

        //Подключение не было закрыто.Подключение открыто.



        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Pupils values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Данные внесены");
        }

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select = from Pupils";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dOBLabel_Click(object sender, EventArgs e)
        {

        }

        private void dOBDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

       
    }
}
