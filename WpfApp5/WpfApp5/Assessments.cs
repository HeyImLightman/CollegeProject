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
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        DataSet ds;
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
            disp_data();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите сохранить?", "Сохранить", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                con.Open();
                String query = "insert into Assessments  (NamePupil, PupilsID, SubjectID, Subject, Attendance, Assessment) values (@NamePupil, @PupilsID, @SubjectID, @Subject, @Attendance, @Assessment)";
                SqlCommand sqlCmd = new SqlCommand(query, con);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@NamePupil", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@PupilsID", textBox5.Text);
                sqlCmd.Parameters.AddWithValue("@SubjectID", textBox4.Text);
                sqlCmd.Parameters.AddWithValue("@Subject", textBox2.Text);
                sqlCmd.Parameters.AddWithValue("@Attendance", checkBox1.Text);
                sqlCmd.Parameters.AddWithValue("@Assessment", textBox3.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                con.Close();
                disp_data();
                textBox1.Clear();
                textBox5.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox2.Clear();
                
            }
        
        }

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Assessments";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить?", "Удалить", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Assessments where NamePupil='" + textBox1.Text + "'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                disp_data();
                textBox1.Clear();
                textBox5.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox2.Clear();
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
            cmd.CommandText = "select * from Assessments where Name like '%" + textBox1.Text + "%'";
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
            DataSet ds;
            ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(" SELECT ID, NamePupil, PupilsID, SubjectID, Subject, Attendance, Assessment FROM dbo.Assessments", con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            sda.Fill(ds, "Assessments");
            sda.Update(ds, "Assessments");

        }
    }
}
