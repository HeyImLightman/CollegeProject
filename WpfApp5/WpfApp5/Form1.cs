using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Ucheniks". При необходимости она может быть перемещена или удалена.
            this.ucheniksTableAdapter.Fill(this.schoolDataSet.Ucheniks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.schoolDataSet.Teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.schoolDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.schoolDataSet.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Lessens". При необходимости она может быть перемещена или удалена.
            this.lessensTableAdapter.Fill(this.schoolDataSet.Lessens);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.schoolDataSet.Classes);

        }
    }
}
