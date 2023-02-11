using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace строки
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
            listBox1.Items.Clear();

            string sample = textBox1.Text;
            var letterCounter = sample.Where(char.IsLetterOrDigit)
                                      .GroupBy(char.ToLower)
                                      .Select(text => new {Letter = text.Key, Counter = text.Count()});

            int lenght1 = sample.Where(x => x == ' ').Count();
            /*
            listBox1.Items.Add(lenght1);
            */
            var t;
            if (t = lenght1)
            {
                listBox1.Items.Add(String.Format("{0} = {1}", t.Letter, t.Counter));
            }
            
            foreach (var text in letterCounter)
            {
                listBox1.Items.Add(String.Format("{0} = {1}", text.Letter, text.Counter));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
