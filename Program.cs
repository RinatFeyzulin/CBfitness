using CBfitness.BL.Controller;
using CBfitness.BL.Model;


namespace CBfitness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, in programm GBfitness");
            
            Console.WriteLine("Write name User");
            var name = Console.ReadLine();

            Console.WriteLine("Write gender ");
            var gender = Console.ReadLine();

            Console.WriteLine("Write date Brithday ");
            var birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Write weigth ");
            var weigth = double.Parse(Console.ReadLine());

            Console.WriteLine("Write heigth ");
            var heigth = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthday, weigth, heigth);
            userController.Save();

        }
    }
}