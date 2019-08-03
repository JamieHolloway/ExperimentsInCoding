using System;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    class Generators
    {
        public static void CreateDataTable(Type className)
        {
            var result = Helper.Visit(className).ToList();
            var sb = new StringBuilder();

            foreach (var item in result)
            {
                sb.AppendLine($"dt.Columns.Add(\"{item.Name}\", typeof({item.PropertyType}));");
                //Console.WriteLine($"{item.Name} {item.DeclaringType}");
            }
            sb.AppendLine();

            var i = 0;
            foreach (var item in result)
            {
                sb.AppendLine($"itemsArray[{i++}] = item{item.DeclaringType?.ToString().Replace("CodeGenerator","").Replace("." + className.Name,"")}.{item.Name};");
            }
            sb.AppendLine();

            i = 0;
            foreach (var item in result)
            {
                sb.AppendLine($"newRow[\"{item.Name}\"] = item{item.DeclaringType?.ToString().Replace("CodeGenerator", "").Replace("." + className.Name, "")}.{item.Name};");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
