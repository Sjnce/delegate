using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_после_теста
{
    public partial class Form1 : Form
    {
        class Complect<P>
        {
            public P Price;
            public int OldYear;

            public Complect(P P, int O)
            {
                Price = P;
                OldYear = O;
            }

            public void Printinfo()
            {
                MessageBox.Show($"Цена: {Price}," +
                    $" год выпуска {OldYear}");
            }
        }

        class CPU<T>
        {
            public T Chastota;
            public int Potok;

            public CPU(T C, int Po)
            {
                Chastota = C;
                Potok = Po;
            }

            public void Printinfo()
            {
                MessageBox.Show($"Цастота ЦП: {Chastota}," +
                    $" количество потоков: {Potok}");
            }
        }

        class Videocard<M>
        {
            public M ChastotaP;
            public int ChastotaSh;

            public Videocard(M CP, int PSh)
            {
                ChastotaP = CP;
                ChastotaSh = PSh;
            }

            public void Printinfo()
            {
                MessageBox.Show($"Видеокарта имеет {ChastotaP} частоты памяти" +
                    $" и {ChastotaSh} частоты шины");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
