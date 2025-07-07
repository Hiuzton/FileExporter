namespace FileExporter.Contracts
{
    public interface ICompressionStrategy
    {
        void Compress(string fileName);
    }
}