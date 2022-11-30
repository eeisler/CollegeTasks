using System.ComponentModel;

namespace task_30._11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\work\new\school.txt";

            string[] allFilesStr = File.ReadAllLines(filePath);

            int counter = 0;
            for (int i = 0; i < allFilesStr.Length; ++i)
            {
                string[] info = allFilesStr[i].Split();
                counter += Convert.ToInt32(info[2]);
                if (Convert.ToInt32(info[2]) < 3)
                {
                    Console.WriteLine("Students with bad marks: " + info[0] + " " + info[1]);
                }
            }

            Console.WriteLine($"Average mark: {counter/allFilesStr.Length}");
            
                
        }
    }
}