using FileExporter.Contracts;

namespace FileExporter.Exports
{
    public class PdfExporter : IExporter
    {
        public void Export(string content)
        {
            string file = "document.pdf";
            Console.WriteLine($"Exported to PDF: {file} with content: {content}");
        }
    }
}
