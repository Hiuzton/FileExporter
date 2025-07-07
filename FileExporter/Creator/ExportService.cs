using FileExporter.Contracts;

namespace FileExporter.Creator
{
    public abstract class ExportService
    {
        public abstract IExporter CreateExporter();

        public void Export(string content, ICompressionStrategy compression)
        {
            var exporter = CreateExporter();
            exporter.Export(content);
            compression.Compress("ExportedFile");
            Console.WriteLine("File export complete.");
        }
    }
}
