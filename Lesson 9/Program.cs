using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите первое целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int b = Convert.ToInt32(Console.ReadLine());
            int summa = a + b;
            int vichitanie = a - b;
            int proizvedenie = a * b;
            Console.WriteLine("Введите код опрерации:");
            Console.WriteLine("1-сложение");
            Console.WriteLine("2-вычитание");
            Console.WriteLine("3-произведение");
            Console.WriteLine("4-частное");
            Console.WriteLine("Ваш выбор: ");
            int cod = Convert.ToInt32(Console.ReadLine());
            if (cod == 1)
                Console.WriteLine("Результат: {0}", summa);
            if (cod == 2)
                Console.WriteLine("Результат: {0}", vichitanie);
            if (cod == 3)
                Console.WriteLine("Результат: {0}", proizvedenie);
            if (cod >= 5 || cod <=0)
                Console.WriteLine("Опрераций с выбранным номером не существует");
            try
            {                         
                double chastnoe = ((double)a)/b;
                if (b == 0)
                    Console.WriteLine("На ноль делить нельзя!");
                else if (cod == 4)
                    Console.WriteLine("Результат: {0:.00}",chastnoe);              
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }    
            
            Console.ReadKey();
            
        }
    }
}
