using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ex3
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
            string s = textBox1.Text;
            Regex regex = new Regex(@"^7\w\s\w\w\s\w\w\w\w\w\w$(\w*)"); 

            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    listBox1.Items.Add(match.Value);
            }
            else
            {
                listBox1.Items.Add("Совпадений не найдено");
            }
        }
    }
}
