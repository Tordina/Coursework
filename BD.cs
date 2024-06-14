using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface5
{
    public partial class BD : Form
    {
        public BD()
        {
            InitializeComponent();
        }

        private void Бд_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.страна". При необходимости она может быть перемещена или удалена.
            this.странаTableAdapter.Fill(this.musical_groupDataSet.страна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.стили". При необходимости она может быть перемещена или удалена.
            this.стилиTableAdapter.Fill(this.musical_groupDataSet.стили);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.роли". При необходимости она может быть перемещена или удалена.
            this.ролиTableAdapter.Fill(this.musical_groupDataSet.роли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.премии". При необходимости она может быть перемещена или удалена.
            this.премииTableAdapter.Fill(this.musical_groupDataSet.премии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.музыканты". При необходимости она может быть перемещена или удалена.
            this.музыкантыTableAdapter.Fill(this.musical_groupDataSet.музыканты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.группа_стиль". При необходимости она может быть перемещена или удалена.
            this.группа_стильTableAdapter.Fill(this.musical_groupDataSet.группа_стиль);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.группа_премия". При необходимости она может быть перемещена или удалена.
            this.группа_премияTableAdapter.Fill(this.musical_groupDataSet.группа_премия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.группа_музыканты". При необходимости она может быть перемещена или удалена.
            this.группа_музыкантыTableAdapter.Fill(this.musical_groupDataSet.группа_музыканты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.группа_альбом". При необходимости она может быть перемещена или удалена.
            this.группа_альбомTableAdapter.Fill(this.musical_groupDataSet.группа_альбом);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.Musical_group". При необходимости она может быть перемещена или удалена.
            this.musical_groupTableAdapter.Fill(this.musical_groupDataSet.Musical_group);

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void musical_groupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musical_groupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musical_groupDataSet);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void информацияTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void musical_groupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void премииDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}
