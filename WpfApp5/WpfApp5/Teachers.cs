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
    public partial class Teachers : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-ПК\MEGAHYPER;Initial Catalog=school;Integrated Security=True");

        public Teachers()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            disp_data();

        }

       

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Teachers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        { DialogResult dialog = MessageBox.Show("Вы уверены, что хотите сохранить?", "Сохранить", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Teachers values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить?", "Удалить", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Teachers where Name='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                textBox1.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Teachers where Name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
