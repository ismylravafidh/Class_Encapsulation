namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=");
            Dog dog = new Dog("Buddy",7);
            dog._breed = "Buildog";
            dog.getInfo();
            Console.WriteLine("=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=");
            Cat cat = new Cat("Felix",3);
            cat._breed = "Maine Coon";
            cat.getInfo();
            Console.WriteLine("=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=");
            Dolphin dolphin = new Dolphin("Jacques", 1);
            dolphin._breed = "Irrawaddy";
            dolphin.getInfo();
            Console.WriteLine("=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=");
            Snake snake = new Snake("Diablo",6);
            snake._breed = "Copperhead";
            snake.IsPoisonous = false;
            snake.getInfo();
            Console.WriteLine("=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/=");
        }
    }
}