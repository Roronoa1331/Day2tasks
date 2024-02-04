using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2ForFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2 
            string fileName = Console.ReadLine();
            string folderPath = "C:\\Users\\potte\\OneDrive\\Masaüstü\\task2\\";
            string folder = Console.ReadLine();
            string finalPath = Path.Combine(folderPath, folder);
            DirectoryInfo directoryInfo = new DirectoryInfo(finalPath);
           

            if(!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            directoryInfo.Refresh();
            DateTime creationDate = directoryInfo.CreationTime;


            Console.WriteLine(folder + " Created");
            Console.WriteLine(creationDate + " - it had been created this date");
            FileInfo file = new FileInfo(@"C:\\Users\\potte\\OneDrive\\Masaüstü\\task2\\" + folder + "\\" +fileName);
            StreamWriter str = file.CreateText();

        }
    }
}
