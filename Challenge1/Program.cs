using Challenge1;

class Program
{
    static void Main(string[] args)
    {
        string folderPath = @"C:\SoftwareDevelopmentPlus";  // You can replace this with your folder path
        string searchString = "example";      // The string you're looking for in files

        FolderScanner.ScanFolder(folderPath, searchString);
    }
}