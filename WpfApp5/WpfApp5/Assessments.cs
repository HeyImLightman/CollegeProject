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
    public partial class Assessments : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-ПК\MEGAHYPER;Initial Catalog=school;Integrated Security=True");

        public Assessments()
        {
            InitializeComponent();
        }

        private void assessmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assessmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Assessments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Assessments". При необходимости она может быть перемещена или удалена.
            this.assessmentsTableAdapter.Fill(this.schoolDataSet.Assessments);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=localhost\MEGAHYPER ; Initial Catalog=school; Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Assessments values('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + checkBox1.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
          
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
           
        }
    }
}
