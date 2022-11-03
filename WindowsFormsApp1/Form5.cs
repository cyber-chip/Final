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
    public partial class StudentsTable : Form
    {
        public StudentsTable()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd1DataSet);

        }

        private void studentsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd1DataSet);

        }

        private void studentsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd1DataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.bd1DataSet.Students);

        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private System.Windows.Forms.DataGridViewColumn COL;


        private void button3_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, записывающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex).
            //Нумерация пунктов списка начинается с нуля, а нумерация столбцов с единицы.
            //Первый столбец в списке ListBox1 - «Фамилия» носит в таблице имя
            // DataGridViewTextBoxColumn3, указанное в свойствах полей
            //в Меню действий таблицы.
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn8;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn7;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён
            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) studentsDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else studentsDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsBindingSource.Filter = "fam='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentsBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < studentsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < studentsDataGridView.RowCount - 1; j++)
                {
                    studentsDataGridView[i, j].Style.BackColor = Color.White;
                    studentsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.

            for (int i = 0; i < studentsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < studentsDataGridView.RowCount - 1; j++)
                {
                    if (studentsDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        studentsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        studentsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}