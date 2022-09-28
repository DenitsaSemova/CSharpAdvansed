using System;
using System.IO;

namespace P00Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../"; //taka rabotqt linux i iOS i nqma da raboti na windows (@"..\..\..\")

            string fileName = "Program.cs";

            path = Path.Combine(path, fileName); // taka raboti na vsichki OS

            using (StreamReader reader = new StreamReader(path))
            { 
                string line = reader.ReadLine();
                int count = 0;

                while (line != null)
                {
                    Console.WriteLine($"Line {++count}: {line}");

                    line = reader.ReadLine();
                }
            }
        }
    }
}
