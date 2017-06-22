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
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-ПК\MEGAHYPER;Initial Catalog=school;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Pupils values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Данные внесены");
        }

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pupils";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Pupils where Name='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            textBox1.Clear();

            MessageBox.Show("Данные удалены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disp_data();

            MessageBox.Show("Данные Выведены");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Pupils where Name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            textBox1.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
