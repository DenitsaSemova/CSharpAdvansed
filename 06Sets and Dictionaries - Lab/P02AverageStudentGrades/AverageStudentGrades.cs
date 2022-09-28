using System;
using System.Collections.Generic;
using System.Linq;

namespace P02AverageStudentGrades
{
    internal class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int numberOfStudents = 0;

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            numberOfStudents = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                var entry = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                               
                if (students.ContainsKey(entry[0]))
                {
                    students[entry[0]].Add(Double.Parse(entry[1]));
                }
                else
                {
                    students[entry[0]] = new List<double>() 
                    { 
                        Double.Parse(entry[1]) 
                    };
                    // ili students[name].Add(grade);
                }
            }

            foreach (var item in students)
            {

                Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value.Select(i => i.ToString("F2")))} (avg: {item.Value.Average():f2})");

            }

        }
    }
}
