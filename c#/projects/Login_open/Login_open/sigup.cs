using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login_open
{
    public partial class sigup : Form
    {
        public sigup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtlast.Text == "" || txtuser.Text == "" || txtpass.Text == "")
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
                    string query = "INSERT INTO users (first_name,last_name,username,password) VALUES (@first_name,@last_name,@username,@password)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // تنظیم مقادیر پارامترها
                        cmd.Parameters.AddWithValue("@first_name", txtname.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtlast.Text);
                        cmd.Parameters.AddWithValue("@username", txtuser.Text);
                        cmd.Parameters.AddWithValue("@password", txtpass.Text);

                         cmd.ExecuteNonQuery();
                         
                        Form1 login = new Form1();
                        login.ShowDialog();
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
    }
}

