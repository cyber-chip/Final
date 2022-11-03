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
    public partial class Uspev : Form
    {
        public Uspev()
        {
            InitializeComponent();
        }

        private void uspev_KarimovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uspev_KarimovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd1DataSet);

        }

        private void Uspev_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd1DataSet.Uspev_Karimov". При необходимости она может быть перемещена или удалена.
            this.uspev_KarimovTableAdapter.Fill(this.bd1DataSet.Uspev_Karimov);

        }
    }
}
