namespace AddbUC13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Gajanan\source\repos\AddbUC13\AddbUC13\File.txt";
            ReadAllLinesFromFile(path);
        }
        public static void ReadAllLinesFromFile(string Path)
        {
            string lines;
            lines = File.ReadAllText(Path);
            Console.WriteLine(lines);
        }
    }
}
