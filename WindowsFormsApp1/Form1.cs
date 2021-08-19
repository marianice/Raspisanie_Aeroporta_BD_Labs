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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Рейсы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Самолеты". При необходимости она может быть перемещена или удалена.
            this.самолетыTableAdapter.Fill(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Самолеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Расписание_рейсов". При необходимости она может быть перемещена или удалена.
            this.расписание_рейсовTableAdapter.Fill(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Расписание_рейсов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Аэропорты". При необходимости она может быть перемещена или удалена.
            this.аэропортыTableAdapter.Fill(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Аэропорты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Авиакомпании". При необходимости она может быть перемещена или удалена.
            this.авиакомпанииTableAdapter.Fill(this.курсоваяАэропорты_и_расписание_рейсов1SQLDataSet.Авиакомпании);

        }

        private void наВыборкуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void авиакомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAvia myForm3 = new FormAvia();
            myForm3.Show();
        }

        private void аэропортыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAero myForm4 = new FormAero();
            myForm4.Show();
        }

        private void расписаниеРейсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRasp myForm5 = new FormRasp();
            myForm5.Show();
        }

        private void рейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormR myForm6 = new FormR();
            myForm6.Show();
        }

        private void самолетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSam myForm7 = new FormSam();
            myForm7.Show();
        }
    }
}
