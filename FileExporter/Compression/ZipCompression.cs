using FileExporter.Contracts;

namespace FileExporter.Compression
{
    public class ZipCompression : ICompressionStrategy
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"[ZIP] Compressing {fileName}...");
        }
    }
}
