using FileExporter.Contracts;
using FileExporter.Exports;

namespace FileExporter.Creator
{
    public class CsvExportService : ExportService
    {
        public override IExporter CreateExporter() => new CsvExporter();
    }
}
