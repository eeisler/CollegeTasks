namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание - считываем текст с файла и записываем его в массив
            // техника - цена и найти самое дорогую

            string filename = @"D:\work\new\temp\technics.txt";
            FileInfo file = new FileInfo(filename);

            using (StreamReader sr = new StreamReader(filename))
            {
                string[] lines = sr.ReadToEnd().Split('\n');

                int maxprice = 0;
                string item = "";
                foreach (string line in lines)
                {
                    int price = Convert.ToInt32(line.Split()[2]);

                    if (price > maxprice)
                    {
                        item = line;
                        maxprice = price;
                    }
                }
                Console.WriteLine($"The most expencive item: {item}");

            }



























            //using (StreamReader sr = new StreamReader(filename))
            //{
            //    string[] lines = sr.ReadToEnd().Split('\n');

            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }

            //}
            //if (!file.Exists)
            //{ 
            //    file.Create();
            //}

            //Console.WriteLine("Enter the text: ");

            //using (StreamWriter sw = new StreamWriter(filename))
            //{
            //    string line = "";
            //    while (line != "stop")
            //    {
            //        line = Console.ReadLine();
            //        sw.WriteLine(line);
            //    }
            //}

            //Console.WriteLine("Files: ");


        }
    }
}