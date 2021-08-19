using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection;

        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=MARY-ПК;Initial Catalog=КурсоваяАэропорты и расписание рейсов1SQL;Integrated Security=True";

            sqlConnection = new SqlConnection(connection);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Пассажиры]", sqlConnection);

            try {
                sqlReader = await command.ExecuteReaderAsync();

                while ( await sqlReader.ReadAsync()) {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "   " +
                        Convert.ToString(sqlReader["ФИО"]) + "   " +
                         Convert.ToString(sqlReader["Price"]) + "   " 
                        );
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label7.Visible) { label7.Visible = false; }

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {

                SqlCommand command = new SqlCommand("INSERT INTO  [dbo].[Пассажиры] ([ФИО], Price)VALUES(@ФИО, @Price)", sqlConnection);

                command.Parameters.AddWithValue("ФИО", textBox1.Text);
                command.Parameters.AddWithValue("Price", textBox2.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label7.Visible = true;
                label7.Text = "Не все поля заполнены";
            }
        }

        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Пассажиры]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "   " +
                        Convert.ToString(sqlReader["ФИО"]) + "   " +
                         Convert.ToString(sqlReader["Price"]) + "   ");

                    listBox2.Items.Add(Convert.ToString(sqlReader["ФИО"]) + "   " +
                        Convert.ToString(sqlReader["Price"]) + "   ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (label8.Visible) { label8.Visible = false; }

            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
               !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
               !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [dbo].[Пассажиры] SET [ФИО]=@ФИО, [Price]=@Price WHERE [Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox5.Text);
                command.Parameters.AddWithValue("ФИО", textBox4.Text);
                command.Parameters.AddWithValue("Price", textBox3.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label8.Visible = true;
                label8.Text = "Не все поля заполнены";
            }
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        } //случайно

        private async void button3_Click(object sender, EventArgs e)
        {
            if (label9.Visible) { label9.Visible = false; }
            if (!string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Пассажиры] WHERE [Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox6.Text);
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label9.Visible = true;
                label9.Text = "Не все поля заполнены";
            }

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("DROP TABLE [dbo].[Пассажиры1]; CREATE TABLE Пассажиры1([Рейс] nvarchar(10), [View] nvarchar(15), price int );" +
                "  INSERT INTO Пассажиры1 VALUES ('Рейс 1', 'Цена 1 класс', 2000),('Рейс 1', 'Цена 2 класс', 3000),('Рейс 1', 'Цена 3 класс', 4000)," +
                "('Рейс 2', 'Цена 1 класс', 5000),('Рейс 2', 'Цена 2 класс', 6000),('Рейс 2', 'Цена 3 класс', 7000); " +
                "SELECT * FROM Пассажиры1", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox5.Items.Add(Convert.ToString(sqlReader["Рейс"]) + "   " +
                        Convert.ToString(sqlReader["View"]) + "   " +
                        Convert.ToString(sqlReader["price"]) + "   " );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT  [Price], [ФИО] FROM [dbo].[Пассажиры] GROUP BY [Price], [ФИО] HAVING[Price] > 2000", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox2.Items.Add( Convert.ToString(sqlReader["ФИО"]) + "   " +
                         Convert.ToString(sqlReader["Price"]) + "   "
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT  [Price], [ФИО] FROM [dbo].[Пассажиры]  WHERE Price  BETWEEN 0 AND 12000", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox3.Items.Add(Convert.ToString(sqlReader["ФИО"]) + "   " +
                         Convert.ToString(sqlReader["Price"]) + "   "
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("DROP TABLE [dbo].[Новая]; CREATE TABLE Новая([Рейс] nvarchar(10), [View] nvarchar(15), price int );" +
                "  INSERT INTO Новая VALUES ('Рейс 1', 'Цена 1 класс', 2000),('Рейс 1', 'Цена 2 класс', 3000),('Рейс 1', 'Цена 3 класс', 4000)," +
                "('Рейс 2', 'Цена 1 класс', 5000),('Рейс 2', 'Цена 2 класс', 6000),('Рейс 2', 'Цена 3 класс', 7000); " +
                "SELECT * FROM Новая pivot(max(price) for [View] in ([Цена 1 класс],[Цена 2 класс],[Цена 3 класс])) as pvt", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox4.Items.Add(Convert.ToString(sqlReader["Рейс"]) + "   " +
                        Convert.ToString(sqlReader["Цена 1 класс"]) + "   " +
                        Convert.ToString(sqlReader["Цена 2 класс"]) + "   " +
                        Convert.ToString(sqlReader["Цена 3 класс"]) + "   " 
                         //Convert.ToString(sqlReader["price"]) + "   "
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }
        }
    }
}
