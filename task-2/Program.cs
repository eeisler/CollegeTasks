using System.IO;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo dr in drives)
            { 
                Console.WriteLine($"Name of the directory: {dr.Name} \nType: {dr.DriveType}" );

                if (dr.IsReady) 
                {
                    Console.WriteLine($"Disk space: {dr.TotalSize/1024/1024/1024} Gb\nFree space: {dr.TotalFreeSpace/1024/1024/1024} Gb\nLabel: {dr.VolumeLabel}");
                }
                Console.WriteLine();
            }
            string dirName = @"D:\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("SubCatalogs:");
                string[] dirs = Directory.GetDirectories(dirName);
                if (dirs.Length == 0) 
                {
                    Console.WriteLine("No catalogs");
                }
                foreach (string dir in dirs)
                    Console.WriteLine(dir);

                Console.WriteLine();

                Console.WriteLine("Files: ");
                string[] files = Directory.GetFiles(dirName);
                if (files.Length == 0)
                {
                    Console.WriteLine("No files");
                }
                foreach (string f in files)
                    Console.WriteLine(f);
            }

            string path = @"D:\work";
            string subpath = @"new\temp";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            Console.ReadLine();

            Console.WriteLine($"Name ")
        }
    }
}