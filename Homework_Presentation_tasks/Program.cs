using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_Presentation_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая 1\n");
            {                
                for (int i = 0; i < args.Length; i++)
                {
                    
                    Regex regex = new Regex(@"(-){0,1}(\d){1,}([\.\,]\d{1,}){0,}", RegexOptions.IgnoreCase);
                    MatchCollection matchFind = regex.Matches(args[i]);

                   
                    foreach (var item in matchFind)
                    {
                        Console.WriteLine($"Совпадение {item}");
                    }
                }
              

                Console.WriteLine("\nПрактическая 2\n");

                string exit = "END_INPUT";
                string input = "";
                do
                {
                    Console.WriteLine("Чтобы остановить программу, напишите: \"END_INPUT\"");
                    Console.WriteLine("Имя, телефон, адрес электронной почты: ");
                    string data = Console.ReadLine();
                    input = data;
                    if (data == exit)
                    {
                        Console.WriteLine("Остановлено");
                        break;
                    }
                    Regex phone = new Regex(@"(\d+)");
                    Regex name = new Regex(@"(^.*?\s)");
                    Regex email = new Regex(@"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)");
                    MatchCollection matchFind2 = phone.Matches(data);
                    MatchCollection matchFind3 = name.Matches(data);
                    MatchCollection matchFind4 = email.Matches(data);
                    Console.WriteLine("Таблица с данными:");
                    foreach (var item in matchFind2)
                    {
                        Console.Write($"Телефон: {item}\n");
                    }
                    foreach (var item in matchFind3)
                    {
                        Console.Write($"Имя: \t{item}\n");
                    }
                    foreach (var item in matchFind4)
                    {
                        Console.Write($"Email: \t{item}\n");
                    }
                } while (input != exit);


                Console.ReadLine();
            }
        }
    }
}
