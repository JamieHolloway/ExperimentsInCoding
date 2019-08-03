using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExperimentsInCoding
{
    public static class StreamFactory
    {
        public static string GetLines() =>
            String.Join(
                Environment.NewLine,
                new[]
                {
                    "Single Responsibility Principle",
                    "Open/Closed Principle",
                    "Liskov Substitution Principle",
                    "Interface Segregation Principle",
                    "Dependency Inversion Principle"
                });

        public static Stream GetStream()
        {
            return
                new MemoryStream()
                    .Tee(stream =>
                        GetLines()
                            .Map(Encoding.UTF8.GetBytes)
                            .Tee(buffer => stream.Write(buffer, 0, buffer.Length)))
                    .Tee(stream => stream.Position = 0L);
        }
    }
}