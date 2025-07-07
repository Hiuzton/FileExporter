using FileExporter.Contracts;
using FileExporter.Exports;

namespace FileExporter.Creator
{
    public class PdfExportService : ExportService
    {
        public override IExporter CreateExporter() => new PdfExporter();
    }
}
