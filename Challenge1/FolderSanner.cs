using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class FolderScanner
    {
        public static void ScanFolder(string folderPath, string searchString)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"The folder '{folderPath}' does not exist.");
                return;
            }

            string[] files = Directory.GetFiles(folderPath);

            foreach (var file in files)
            {
                try
                {
                    string content = File.ReadAllText(file);
                    if (content.Contains(searchString))
                    {
                        Console.WriteLine($"Present: {Path.GetFileName(file)}");
                    }
                    else
                    {
                        Console.WriteLine($"Absent: {Path.GetFileName(file)}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing file {file}: {ex.Message}");
                }
            }
        }
    }
}
