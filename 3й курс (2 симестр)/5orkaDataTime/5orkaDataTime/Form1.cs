using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _5orkaDataTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            select();
        }
        string connStr = "server=10.90.12.110;port=33333;user=st_1_20_10;database=is_1_20_st10_KURS;password=34088849;";
        MySqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr); 
        }

        public void select()
        {
            DataSet ds;
            ds = new DataSet();
            string connectionString = "server=10.90.12.110;port=33333;user=st_1_20_10;database=is_1_20_st10_KURS;password=34088849";
            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand command = new MySqlCommand();
            string commandString = "SELECT * FROM 1_tables";
            command.CommandText = commandString;
            command.Connection = connection;
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                this.dataGridView1.Columns.Add("id", "Номер");
                this.dataGridView1.Columns["id"].Width = 90;
                this.dataGridView1.Columns.Add("name", "Название");
                this.dataGridView1.Columns["name"].Width = 165;
                this.dataGridView1.Columns.Add("sale", "Цена");
                this.dataGridView1.Columns["sale"].Width = 80;
                this.dataGridView1.Columns.Add("date", "Срок годности");
                this.dataGridView1.Columns["date"].Width = 80;
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id"].ToString(), reader["name"].ToString(), reader["sale"].ToString(), reader["date"].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
