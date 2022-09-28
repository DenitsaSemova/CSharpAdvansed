using System;
using System.IO;

namespace P08FullDirectoryTraversal
{
    internal class FullDirectoryTraversal
    {
        static void Main(string[] args)
        {
            var fileTest = File.Open("..//..//..//..//files//text.txt", FileMode.Open);
        }
    }
}
