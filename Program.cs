using System.Data;
using System.Data.SqlTypes;

namespace FileIODemo;
public class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\Gajanan\source\repos\FileIODemo\FileIODemo\Demo.txt";
        //FileExitPath(path);
        //ReadAll_Files_fromFile(path);
        // ReadAllText(path);
        //CoyFileToAnother(path);
        // DeleteFile(path);
        BinarySerialization b = new BinarySerialization();
        //b.SerialiZation();
        b.Deserlization();
    }
    public static void FileExitPath(string Path)
    {
        if (File.Exists(Path))
        {
            Console.WriteLine("File Exits");
        }
        else
        {
            Console.WriteLine("File not  Exits");
        }
    }
    public static void ReadAll_Files_fromFile(string Path)
    {
        string[] lines;
        lines = File.ReadAllLines(Path);
        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
        Console.WriteLine(lines[2]);
    }
    public static void ReadAllText(string Path)
    {
        string line;
        line = File.ReadAllText(Path);
        Console.WriteLine(line);
    }
    public static void DeleteFile(string Path)
    {
        string coypath= @"C:\Users\Gajanan\source\repos\FileIODemo\FileIODemo\Example.txt";
        File.Delete(coypath);
    }
    public static void CoyFileToAnother(string Path)
    {
        string copypath = @"C:\Users\Gajanan\source\repos\FileIODemo\FileIODemo\Example.txt"; ;
        File.Copy(Path, copypath);
    }
    public static void ReadFrom_StreamReader(string Path)
    {
        using (StreamReader sr=File.OpenText(Path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
