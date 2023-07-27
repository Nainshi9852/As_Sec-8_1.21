using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }
        public static void runApp()
        {
            string[] students = new string[10];
            Console.WriteLine("After Sorting:-");
            students[0] = "Divy";
            students[1] = "Mark";
            students[2] = "Aditya";
            students[3] = "Aahana";
            students[4] = "Aadvik";
            students[5] = "Mona";
            students[6] = "Nainshi";
            students[7] = "Guru";
            students[8] = "Chandan";
            students[9] = "Komal";

            int n = 10;
            string temp;
            int smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].CompareTo(students[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = students[smallest];
                students[smallest] = students[i];
                students[i] = temp;
            }

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }

    }
}
