using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassLibrary1.Class1;

namespace Делегаты
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Account account;
        void DisplayMessage(Account sender, AccountEventArgs e)
        {
            MessageBox.Show($"Пользователь счета: {account.fio}\nСумма транзакции: {e.Sum} руб.\n" 
                + e.Message + $"\nТекущая сумма на счете: {sender.sum} руб.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                account = new Account(Convert.ToInt32(textBox2.Text), textBox1.Text);
                listBox1.Items.Clear();
                listBox1.Items.Add($"Пользователь: {account.fio}, счет: {account.sum}");
            }
            catch
            {
                MessageBox.Show("Введите информацию пользователя");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox3.Text);
            if (account.sum < x)
            {
                account.Notify += DisplayMessage;
                listBox1.Items.Clear();
                listBox1.Items.Add("На счету пользователя недостаточно средств");
                account.Notify -= DisplayMessage;
            }
            else
            {
                account.Notify += DisplayMessage;
                account.Take(Convert.ToInt32(textBox3.Text));
                listBox1.Items.Clear();
                listBox1.Items.Add($"Пользователь: {account.fio}, счет: {account.sum}");
                account.Notify -= DisplayMessage;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            account.Notify += DisplayMessage;
            account.Add(Convert.ToInt32(textBox4.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add($"Пользователь: {account.fio}, счет: {account.sum}");
            account.Notify -= DisplayMessage;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
