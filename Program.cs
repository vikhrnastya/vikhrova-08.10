using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вихрова_08._10
{
    internal class Program
    {
        static void Main(string[] args)
        { Employee employee = new Employee();
            employee.фио = "Иванов";
            employee.зарплата = 63500;
            employee.Show();
            double всяЗарплата = employee.ВсяЗарплата();
            Console.WriteLine($"Годовая зарплата: {всяЗарплата} руб.");
            Console.ReadKey();
        }
    }

    class Employee
    {
        public string фио;
        public double зарплата;
        public void Show()
        {
            Console.WriteLine($"Служащий: {фио}, зарплата в месяц: {зарплата} руб.");
        }
        public double ВсяЗарплата()
        {
            return зарплата * 12;
        }
    }
}
