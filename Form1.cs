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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void musical_groupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musical_groupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musical_groupDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.группа_альбом". При необходимости она может быть перемещена или удалена.
            this.группа_альбомTableAdapter.Fill(this.musical_groupDataSet.группа_альбом);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musical_groupDataSet.Musical_group". При необходимости она может быть перемещена или удалена.
            this.musical_groupTableAdapter.Fill(this.musical_groupDataSet.Musical_group);

        }
    }
}
