using FileExporter.Compression;
using FileExporter.Context;
using FileExporter.Creator;

namespace FileExporterApp
{
    class Program
    {
        static void Main()
        {
            var compressionContext = new CompressionContext(new ZipCompression());

            ExportService exportService = new CsvExportService();
            exportService.Export("Report Data", new ZipCompression());

            exportService = new PdfExportService();
            exportService.Export("Confidential PDF", new RarCompression());
        }
    }
}
