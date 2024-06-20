using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClassLibraryDEMOPrepearing;

namespace WindowsFormsAppDEMOPrepearing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void UpdateDataGrid(string tableName)
        {
            AppState.db.GetConnection();
            AppState.db.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter($"select * from {tableName}", AppState.db.GetConnection());
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dataGridView1.DataSource = table;
            AppState.db.Close();
        }

        //sql = $"Insert into Врачи values({Convert.ToInt32(textBox1.Text)}, '{textBox2.Text}', @price, @pros, @salary)";
        //                cmd = new SqlCommand(sql, db.get());
        //cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox3.Text); 
        //                cmd.Parameters.Add("@pros", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox4.Text);
        //                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = Convert.ToDecimal(textBox5.Text);
        //                cmd.ExecuteNonQuery();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"Insert into {comboBox1.Text} ";
                switch (comboBox1.Text)
                {
                    case "ЗапросМастера":
                        sql += $"values({Convert.ToInt32(textBox1.Text)}, {Convert.ToInt32(textBox2.Text)}, '{textBox3.Text}')";
                        break;
                    case "Роль":
                        sql += $"values({Convert.ToInt32(textBox1.Text)}, '{textBox2.Text}')";
                        break;
                    case "СтатусЗаявки":
                        sql += $"values({Convert.ToInt32(textBox1.Text)}, '{textBox2.Text}')";
                        break;
                    case "ТипПроблемы":
                        sql += $"values({Convert.ToInt32(textBox1.Text)}, '{textBox2.Text}')";
                        break;
                    case "ТипТехники":
                        sql += $"values({Convert.ToInt32(textBox1.Text)}, '{textBox2.Text}')";
                        break;
                }
                AppState.db.Open();
                SqlCommand cmd = new SqlCommand(sql, AppState.db.GetConnection());
                cmd.ExecuteNonQuery();
                AppState.db.Close();
                UpdateDataGrid(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"update {comboBox1.Text} set ";
                switch (comboBox1.Text)
                {
                    case "ЗапросМастера":
                        sql += $"кодМастера = {Convert.ToInt32(textBox2.Text)}, запрос = '{textBox3.Text}'" +
                            $"where кодЗапросаМастера = {Convert.ToInt32(textBox1.Text)}";
                        break;
                    case "Роль":
                        sql += $"название = '{textBox2.Text}' where кодРоли = {Convert.ToInt32(textBox1.Text)}";
                        break;
                    case "СтатусЗаявки":
                        sql += $"название = '{textBox2.Text}' where кодСтатусаЗаявки = {Convert.ToInt32(textBox1.Text)}";
                        break;
                    case "ТипПроблемы":
                        sql += $"название = '{textBox2.Text}' where кодТипаПроблемы = {Convert.ToInt32(textBox1.Text)}";
                        break;
                    case "ТипТехники":
                        sql += $"название = '{textBox2.Text}' where кодТипаТехники = {Convert.ToInt32(textBox1.Text)}";
                        break;
                }
                AppState.db.Open();
                SqlCommand cmd = new SqlCommand(sql, AppState.db.GetConnection());
                cmd.ExecuteNonQuery();
                AppState.db.Close();
                UpdateDataGrid(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"delete from {comboBox1.Text} ";
                switch (comboBox1.Text)
                {
                    case "ЗапросМастера":
                        sql += $"where кодЗапросаМастера = {Convert.ToInt32(textBox1.Text)}";
                        break;
                    case "Роль":
                        sql += $"where кодРоли = {Convert.ToInt32(textBox1.Text)}";
                        break; 
                    case "СтатусЗаявки":
                        sql += $"where кодСтатусаЗаявки = {Convert.ToInt32(textBox1.Text)}";
                        break;
                    case "ТипПроблемы":
                        sql += $"where кодТипаПроблемы = {Convert.ToInt32(textBox1.Text)}";
                        break;
                    case "ТипТехники":
                        sql += $"where кодТипаТехники = {Convert.ToInt32(textBox1.Text)}";
                        break;
                }
                AppState.db.Open();
                SqlCommand cmd = new SqlCommand(sql, AppState.db.GetConnection());
                cmd.ExecuteNonQuery();
                AppState.db.Close();
                UpdateDataGrid(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = comboBox1.Text;
            UpdateDataGrid(tableName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            switch (comboBox1.Text)
            {
                case "ЗапросМастера":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    break;
                case "Роль":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    break;
                case "СтатусЗаявки":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    break;
                case "ТипПроблемы":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    break;
                case "ТипТехники":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = Statistic.ПолучитьКоличествоЗаявок(2);
            MessageBox.Show($"Общее количество сделанных заявок - {count}.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
