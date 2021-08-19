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
    public partial class FormSam : Form
    {
        public FormSam()
        {
            InitializeComponent();
        }

        private void FormSam_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Самолеты". При необходимости она может быть перемещена или удалена.
            this.самолетыTableAdapter.Fill(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Самолеты);

        }
    }
}
