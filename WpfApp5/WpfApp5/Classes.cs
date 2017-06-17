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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Classes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.schoolDataSet.Classes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.classesTableAdapter.Update(this.schoolDataSet);
        }
    }
}
