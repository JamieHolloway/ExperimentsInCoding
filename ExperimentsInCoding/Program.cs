using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExperimentsInCoding
{
    class Program
    {
        public static string MapTest(string value)
        {
            return $"my string was == {value}";
        }

        static void Main(string[] args)
        {

            //var numbers = MyLinq.Random().Where(n => n > 0.5).Take(10).OrderBy(n => n);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight",   Rating = 8.9f, Year = 2008 },
                new Movie { Title = "The King's Speech", Rating = 8.0f, Year = 2010 },
                new Movie { Title = "Casablanca",        Rating = 8.5f, Year = 1942 },
                new Movie { Title = "Star Wars V",       Rating = 8.7f, Year = 1980 }
            };

            var query = movies.Where(m => m.Year > 2000);

            foreach (var item in query)
            {
                Console.WriteLine(item.Title);
            }

            /* on linq
            Func<int, int> square = x => x * x;

            Func<int, int, int> add = (x, y) =>
            {
                int temp = x + y;
                return temp;
            };

            Action<int> write = x =>
            {
                var holdColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(x);
                Console.ForegroundColor = holdColor;
            };

            //write(square(add(3, 5)));

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name= "John" },
                new Employee { Id = 2, Name= "Paul" },
                new Employee { Id = 3, Name= "Ringo" },
                new Employee { Id = 4, Name= "George" }
            };

            developers.Where(e => e.Name.StartsWith("J")).Aggregate(e => e.N);

            foreach (var employee in developers.Where(e => e.Name.StartsWith("J")))
            {
                Console.WriteLine(employee.Name);
            }

            foreach (var employee in developers.Where(delegate(Employee arg)
            {
                return arg.Name.StartsWith("J");
            }))
            {
                Console.WriteLine(employee.Name);
            }

            foreach (var employee in developers.Where(NameStartsWithJ))
            {
                Console.WriteLine(employee.Name);
            }
            */


            /*
            Console.WriteLine(StreamFactory.GetLines().Map(MapTest));
            */

            /* building functional expressions
            var result = Disposable
                .Using(
                    StreamFactory.GetStream,
                    stream => new byte[stream.Length].Tee(b => stream.Read(b, 0, (int) stream.Length)))
                .Map(Encoding.UTF8.GetString)
                .Tee(Console.WriteLine);

            Disposable
                .Using(
                    StreamFactory.GetStream,
                    stream => new byte[stream.Length].Tee(b => stream.Read(b, 0, (int)stream.Length)))
                .Map(Encoding.UTF8.GetString)
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select((s, ix) => Tuple.Create(ix, s))
                .ToDictionary(k => k.Item1, v => v.Item2)
                .Map(HtmlBuilder.BuildSelectBox("beSOLID", true))
                .Tee(Console.WriteLine);
            */


            /* StringBuilder Extension Methods
            var line1 = "Single Responsibility Principle";
            var line2 = "Open/Closed Principle";
            var line3 = "Liskov Substitution Principle";
            var line4 = "Interface Segregation Principle";
            var line5 = "Dependency Inversion Principle";

            Console.SetWindowSize(120,40);

            var lines = new StringBuilder()
                .AppendLine(line1)
                .AppendLine(line2)
                .AppendLine($"{line3}")
                .AppendLineWhen(() => true, line4)
                .AppendWhen(() => true,
                    sb => sb.AppendLine(line5));

            Console.WriteLine(lines.ToString());
            */

            /* console color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("writing a red line");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("end of experiment");
            */

            /* tupples
            var latLng = LattitudeLongitude.GetLattitudeLongitude(lattitude: "47.730667", longitude: "-122.218755");
            Console.WriteLine($"Lattude is {latLng.lattitude}, Longitude is {latLng.longitude}");
            */

            Console.Read();
        }

        private static bool NameStartsWithJ(Employee arg)
        {
            return arg.Name.StartsWith("J");
        }
    }
}
