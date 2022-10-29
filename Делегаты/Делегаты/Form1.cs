using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Делегаты
{
    public partial class Form1 : Form
    {
        Class1 account;
        AccountHandler Ach;
        void PrintSimpleMessage(string message) => listBox1.Items.Add(message);

        public Form1()
        {
            InitializeComponent();
        }

        public class Bank
        {
            public int Sum;
            public string Fio;

            public Bank(int s, string f)
            {
                Sum = s;
                Fio = f;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.Add(Convert.ToInt32(textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 account = new Class1(200);
            account.RegisterHandler(PrintSimpleMessage);
            account.Take(100);
            account.Take(150);

            void PrintSimpleMessage(string message) => Console.WriteLine(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account.Take(Convert.ToInt32(textBox1.Text));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
