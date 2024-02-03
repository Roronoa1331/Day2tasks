using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ForFIles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string[] sourceFilePath =
            {
                "C:\\Users\\potte\\OneDrive\\Masaüstü\\doing tasks\\name1.txt",
                "C:\\Users\\potte\\OneDrive\\Masaüstü\\doing tasks\\name2.txt",
                "C:\\Users\\potte\\OneDrive\\Masaüstü\\doing tasks\\name3.txt"

            };
            string folderPath = @"C:\Users\potte\OneDrive\Masaüstü\doing tasks\";
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            string destinationFilePath = @"C:\Users\potte\OneDrive\Masaüstü\doing tasks\name4.txt";

            FileInfo newfile = new FileInfo(destinationFilePath);
            

            string combiningContent = " ";
            foreach (string item in sourceFilePath)
            {
                StreamReader reader = new StreamReader(item);
                combiningContent += reader.ReadToEnd() + Environment.NewLine;
                reader.Close();
            }

            StreamWriter writer = new StreamWriter(destinationFilePath);
            writer.Write(combiningContent);
            writer.Close();


        }
    }
}
