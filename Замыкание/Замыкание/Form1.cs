using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Замыкание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var fn = Outer();
            fn(); //1
            fn(); //2
            fn(); //3
            fn(); //4
            fn(); //5
            fn(); //6
            fn(); //7
            fn(); //8
            fn(); //9
            fn(); //10

            Action Outer()  // метод или внешняя функция
            {
                var x = 1;  // лексическое окружение - локальная переменная
                void Inner()    // локальная функция
                {
                    do
                    {
                        listBox1.Items.Add(x);
                        x++;
                    }
                    while (x < 1);
                }
                return Inner;   // возвращаем локальную функцию
            }
        }
    }
}
