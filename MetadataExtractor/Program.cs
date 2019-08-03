using System;
using MetadataExtractor;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetadataExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var directories = ImageMetadataReader.ReadMetadata(@"C:\Users\jamieho\OneDrive\Pictures\photos\20180818-MichaelTina-Wedding\raw\DSC_6578.JPG");

            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                    Console.WriteLine($"[{directory.Name}] {tag.Name} = {tag.Description}");

                if (directory.HasError)
                {
                    foreach (var error in directory.Errors)
                        Console.WriteLine($"ERROR: {error}");
                }
            }
        }
    }
}
