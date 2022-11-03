using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd1DataSet);

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd1DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.bd1DataSet.Students);

        }

        private void no_zkLabel_Click(object sender, EventArgs e)
        {

        }
        private StudentsTable studentstable;


        private void button1_Click(object sender, EventArgs e)
        {
            studentstable = new StudentsTable();
            studentstable.Visible = true;


        }
    }
}
