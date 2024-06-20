using ClassLibraryDEMOPrepearing;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppDEMOPrepearing
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {  
                string sql = $"select логин from Пользователь where логин = '{textBox1.Text}'";
                AppState.db.Open();
                SqlCommand cmd = new SqlCommand(sql, AppState.db.GetConnection());
                string login = "";
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    login += reader.GetString(0);
                }

                sql = $"select пароль from Пользователь where логин = '{login}'";
                cmd = new SqlCommand(sql, AppState.db.GetConnection());
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    string password = reader.GetString(0);
                    if (!String.IsNullOrWhiteSpace(password) && password == textBox2.Text)
                    {
                        Hide();
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                        Show();
                    } else { throw new Exception(); }
                }
                AppState.db.Close();
            }
            catch
            {
                MessageBox.Show($"Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
