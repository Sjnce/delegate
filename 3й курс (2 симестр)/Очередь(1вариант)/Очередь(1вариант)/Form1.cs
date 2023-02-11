using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Очередь_1вариант_
{
    public partial class Form1 : Form
    {
        #region форма
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        Queue<string> people = new Queue<string>();

        #region кнопки
        private void button1_Click(object sender, EventArgs e) //Добавить
        {
            people.Enqueue(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e) //Вывести
        {
            listBox1.Items.Clear();
            foreach (var person in people)
            {
                listBox1.Items.Add(person);
            }
        }

        private void button3_Click(object sender, EventArgs e) //Удалить
        {
            try
            {
                people.Dequeue();
            }
            catch
            {
                listBox1.Items.Add("Нельзя удалить того, чего нет. Очередь пуста");
            }
        }
        #endregion
    }
}
