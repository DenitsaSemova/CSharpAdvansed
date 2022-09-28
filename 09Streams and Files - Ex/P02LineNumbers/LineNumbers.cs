using System;
using System.Diagnostics;
using System.IO;

namespace P02LineNumbers
{
    internal class LineNumbers
    {
        static void Main(string[] args)
        {
            string sourceFile = "..//..//..//..//files//text.txt";
            string destinationPath = "..//..//..//..//files//output.txt";

            using (StreamReader streamReader = new StreamReader(sourceFile))
            {
                using (StreamWriter streamWriter = new StreamWriter(destinationPath))
                {

                    string line = streamReader.ReadLine();
                    int counter = 1;

                    while (line != null)
                    {
                        streamWriter.WriteLine($"Line {counter++}: {line}");

                        line = streamReader.ReadLine();
                    }
                }

            }
        }
    }
}
