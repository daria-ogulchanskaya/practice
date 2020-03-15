using System;
using System.Collections.Generic;
using System.Linq;
namespace Task3
{
    public class Program
    {
        public static Random Random = new Random();

        static void Main(string[] args)
        {
            var weapons = new List<Weapon>();
            var types = Enum.GetValues(typeof(Type));

            for (int i = 0; i < 10; i++)
            {
                var index = Random.Next(types.Length);
                var type = (Type)types.GetValue(index);

                weapons.Add(new Weapon(type));
            }

            var result = weapons.GroupBy(x => x.Type);

            foreach (var type in result)
                Console.WriteLine($"{type.Key} {type.Count()}");

            Console.ReadKey();
        }
    }
}
