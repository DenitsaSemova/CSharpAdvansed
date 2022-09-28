using System;
using System.IO;
using System.Linq;

namespace P01ReverseText
{
    internal class ReverseText
    {
        static void Main(string[] args)
        {
            string path = "../../../"; //taka rabotqt linux i iOS i nqma da raboti na windows (@"..\..\..\")

            string inputFileName = "ReverseText.cs";
            string outputFileName = "reverse.txt";

            path = Path.Combine(path, inputFileName); // taka raboti na vsichki OS

            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(outputFileName))
                {

                    string line = reader.ReadLine();

                    while (line != null)
                    {
                       writer.WriteLine(string.Join("", line.Reverse()));

                        line = reader.ReadLine();
                    }

                }

            }
        }
    }
}
