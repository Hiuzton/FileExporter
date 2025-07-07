using FileExporter.Contracts;

namespace FileExporter.Compression
{
    public class RarCompression : ICompressionStrategy
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"[RAR] Compressing {fileName}...");
        }
    }
}
