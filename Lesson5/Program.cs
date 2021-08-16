using System;

namespace Lesson5
{
    

    class Product
    {
        public string name;
        public int fee, total;
        public int id;

        public Product (string name, int fee, int total, int id) { this.name = name;  this.fee = fee; this.total = total; }


    }

    class Inventory
    {
        


    }

    class Program
    {
        static void Main(string[] args)
        {
            Product someProduct = null;
           /* Product paper = new Product("Бумага", 100, 2500);
            Product pen = new Product("Ручка", 140, 1000);
            Product pensil = new Product("Карандаш", 135, 1000);
            Product notebook = new Product("Тетрадь", 500, 150);
            Product bottle = new Product("Бутылка", 3000, 60);
            Product ring = new Product("Кольцо", 140000, 12);
           */


            string user_command = "";
            string user_command_name = "";
            string user_command_fee = "";
            string user_command_total = "";

            int parseFee = 0;
            int parseTotal = 0;
            int idNum = 0;
            object[] catalog = new object[10];


            bool infinity = true;

            while (infinity)
            {
                Console.WriteLine("Введите команду");
                user_command = Console.ReadLine();

                // Ветвление
                switch (user_command)
                {
                    case "exit":
                        {
                            infinity = false;
                            break;
                        }
                    case "help":
                        {
                            Console.WriteLine("Список команд");
                            Console.WriteLine("--------------------------------------------");

                            Console.WriteLine("add - добавляет товар");
                            Console.WriteLine("delete - удаляет товар");
                            Console.WriteLine("change - изменяет параметры товара");
                            Console.WriteLine("get_info - выводит параметры товара");

                            break;
                        }
                    case "get_info":
                        {

                            for (int i = 0; i < catalog.Length; i++)
                            {
                                Console.WriteLine(catalog[i]);
                            }

                            break;
                        }

                    case "add":
                        {
                            
                            
                            Console.WriteLine("Введите название товара ");
                            user_command_name = Console.ReadLine();
                             
                            Console.WriteLine("Введите стоимость товара ");
                            user_command_fee = Console.ReadLine();
                            parseFee = int.Parse(user_command_fee);

                            Console.WriteLine("Введите количество добавляемого товара ");
                            user_command_total = Console.ReadLine();
                            parseTotal = int.Parse(user_command_total);                            

                            idNum++;

                            catalog[idNum -1] = new Product(user_command_name, parseFee, parseTotal, idNum);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Команда не определена, повторите снова");
                            Console.WriteLine("Для вывода списка команд введите - help");
                            Console.WriteLine("Для выхода введите - exit");
                            break;
                        }                                         
                }


            }
            

            

        }

    }
}
