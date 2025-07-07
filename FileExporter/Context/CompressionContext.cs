using FileExporter.Contracts;

namespace FileExporter.Context
{
    public class CompressionContext
    {
        private ICompressionStrategy _strategy;

        public CompressionContext(ICompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ICompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Compress(string fileName)
        {
            _strategy.Compress(fileName);
        }
    }
}
