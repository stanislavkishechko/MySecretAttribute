using System;
using System.IO;
using System.Linq;

namespace MySecretAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter("Record Log.txt"))
            {
                var type = typeof(Product);

                var properties = type.GetProperties();

                var record = type.Name;

                sw.WriteLine("Class: {0}\n", record);

                foreach (var prop in properties)
                {
                    var attrs = prop.GetCustomAttributes(false);

                    if (!attrs.Any(a => a.GetType() == typeof(SecretAttribute)))
                    {
                        sw.WriteLine($"{prop.Name}");
                    }
                }
            }

            using (var sr = new StreamReader("Record Log.txt"))
            {
                var text = sr.ReadToEnd();
                Console.Write(text);
            }

            Console.ReadLine();
        }
    }
}
