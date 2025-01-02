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
    public partial class main : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter ad;
        DataRow row;

        public main()
        {
            conn = new SQLiteConnection();
            cmd = new SQLiteCommand();
            ad = new SQLiteDataAdapter();
            row = null;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "data Source=example.db";
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Products";
            //var result = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            ad.SelectCommand = cmd;
            ad.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "id" && e.RowIndex >= 0)
                {
                // بررسی اینکه سطر معتبر باشد
                if (e.RowIndex >= 0)
                {
                    // بررسی نام ستون کلیک‌شده
                    string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                    // دریافت مقدار کلیک‌شده
                    var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (cellValue != null)
                    {
                        string selectedValue = cellValue.ToString();

                        // اتصال به پایگاه داده
                        using (SQLiteConnection conn = new SQLiteConnection("data source=example.db"))
                        {
                            conn.Open();

                            // استفاده از کوئری پویا بر اساس ستون کلیک‌شده
                            string query = string.Empty;

                            if (columnName == "id")
                            {
                                query = "SELECT * FROM products WHERE id=@value";
                            }
                            else if (columnName == "Game")
                            {
                                query = "SELECT * FROM products WHERE Game=@value";
                            }
                            else if (columnName == "Start_Time")
                            {
                                query = "SELECT * FROM products WHERE Start_Time=@value";
                            }
                            else if (columnName == "Finish_Time")
                            {
                                query = "SELECT * FROM products WHERE Finish_Time=@value";
                            }
                            else if (columnName == "Payment")
                            {
                                query = "SELECT * FROM products WHERE Payment=@value";
                            }

                            if (!string.IsNullOrEmpty(query))
                            {
                                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@value", selectedValue);

                                    using (SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd))
                                    {
                                        DataTable dt = new DataTable();
                                        ad.Fill(dt);

                                        if (dt.Rows.Count > 0)
                                        {
                                            DataRow row = dt.Rows[0];

                                            // مقداردهی به کنترل‌های متنی
                                            txtgame.Text = row["Game"].ToString();
                                            txtstart.Text = row["Start_Time"].ToString();
                                            txtfinish.Text = row["Finish_Time"].ToString();
                                            txtpa.Text = row["Payment"].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No data found for the selected value.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No valid column selected for processing.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected cell value is null.");
                    }
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your reqest has been successfully registered");
            txtgame.Text = "";
            txtstart.Text = "";
            txtfinish.Text = "";
            txtpa.Text = "";
        }
    }
}
