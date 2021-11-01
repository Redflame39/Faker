using System;

namespace Faker
{
    public class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();
            User user = faker.Create<User>();
            Console.WriteLine(user);
        }
    }
}
