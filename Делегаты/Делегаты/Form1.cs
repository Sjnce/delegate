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

        public Form1()
        {
            InitializeComponent();
        }

        Account ac;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ac = new Account(Convert.ToInt32(textBox2.Text), textBox1.Text);
                listBox1.Items.Clear();
                listBox1.Items.Add($"Владелец счёта: {ac.fio}, состояние счета: {ac.sum}");
                MessageBox.Show($"Владелец счёта: {ac.fio}, состояние счета: {ac.sum}");
            }
            catch
            {
                MessageBox.Show("Нельзя создать пустого пользователя");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ac.Add(Convert.ToInt32(textBox3.Text));
                listBox1.Items.Clear();
                listBox1.Items.Add($"Владелец счёта: {ac.fio}, состояние счета: {ac.sum}");
                MessageBox.Show($"Владелец счёта: {ac.fio}, состояние счета: {ac.sum}");
            }
            catch
            {
                MessageBox.Show("Впишите сумму внесения");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox4.Text);
                if (ac.sum <= x)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("На счету недосатточно средств");
                    MessageBox.Show("На счету недосатточно средств");
                }
                else
                {
                    ac.Take(Convert.ToInt32(textBox4.Text));
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"Владелец счёта: {ac.fio}, состояние счета: {ac.sum}");
                    MessageBox.Show($"Владелец счёта: {ac.fio}, состояние счета: {ac.sum}");
                }
            }
            catch
            {
                MessageBox.Show("Впишите сумму которую хотите снять");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
