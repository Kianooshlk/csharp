using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Login_open
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (user.Text.Trim() == "" || pass.Text.Trim() == "")
            {
                MessageBox.Show("Empty Field", "Error");
                return;
            }

            // اتصال به پایگاه داده
            string connectionString = "Data Source=example.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // کوئری برای بررسی وجود کاربر
                    string query = "SELECT * FROM users WHERE username = @user AND password = @pass";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // تنظیم مقادیر پارامترها
                        cmd.Parameters.AddWithValue("@user", user.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", pass.Text.Trim());

                        // اجرای کوئری و خواندن نتایج
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // بررسی وجود کاربر
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("You are Logged in", "Login successful");
                            main main = new main();
                            main.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // مدیریت خطاها
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sigup sigup = new sigup();
            sigup.ShowDialog();
        }
    }
}