using System;

namespace НекаяСущность_26._01._2021
{
    class Animal
    {
        public string name;
        public int age;
        public string breed;
        public string color_fur;
        public string action1;
        public string action2;

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: { age}");
            Console.WriteLine($"Цвет шерсти: { color_fur}");
            Console.WriteLine($"Порода : {breed}");
            Console.WriteLine($"Любимое занятие: {action1}");
            Console.WriteLine($"Не самое любимое занятие: {action2} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.name = "Тайсон";
            cat.age = 7;
            cat.breed = "Шотландский вислоухий";
            cat.color_fur = "Чёрный";
            cat.action1 = "Просить кушать";
            cat.action2 = "Купаться";
            cat.GetInfo();
            Console.WriteLine();


            Animal dog = new Animal();
            dog.name = "Бублик";
            dog.age = 4;
            dog.breed = "Немецкая Овчарка";
            dog.color_fur = "Белый";
            dog.action1 = "Лаять";
            dog.action2 = "Играть с детьми";
            dog.GetInfo();
            Console.WriteLine();

            Animal hamster = new Animal();
            hamster.name = "Хома";
            hamster.age = 3;
            hamster.breed = "Обычный домашний";
            hamster.color_fur = "Рыжий";
            hamster.action1 = "Бегать";
            hamster.action2 = "Сидеть в руках у чужих";
            hamster.GetInfo();

            Console.ReadKey();
        }
    }
}
