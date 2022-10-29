using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void AccountHandler(string message);
    public class Class1 
    {
        public int Sum;
        public string Fio;

        public Class1(string fio, int sum)
        {
            Fio = fio;
            Sum = sum;
        }

        int sum;
        AccountHandler taken;
        public Class1(int sum) => this.sum = sum;
        // Регистрируем делегат
        public void RegisterHandler(AccountHandler del)
        {
            taken += del;
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountHandler del)
        {
            taken -= del; // удаляем делегат
        }
        public void Add(int sum) => this.sum += sum;
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
                taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
        }
    }
}
