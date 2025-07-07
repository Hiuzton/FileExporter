using FileExporter.Contracts;

namespace FileExporter.Exports
{
    public class CsvExporter : IExporter
    {
        public void Export(string content)
        {
            string file = "data.csv";
            Console.WriteLine($"Exported to CSV: {file} with content: {content}");
        }
    }
}
