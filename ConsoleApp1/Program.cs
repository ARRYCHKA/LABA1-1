using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic manager = new Logic();
            string command;
            while (true)
            { 
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1. Добавить машину");
                Console.WriteLine("2. Удалить машину");
                Console.WriteLine("3. Изменить парамерты машины");
                Console.WriteLine("4. Показать список машин");
                Console.WriteLine("5. Выход");
                
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "1":
                        
                    case "2":
                        
                    case "3":
                        
                    default:
                        
                        break;
                }
            }
            
        }
    }
}
