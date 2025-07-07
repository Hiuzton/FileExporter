using FileExporter.Contracts;
using FileExporter.Compression;
using FileExporter.Exports;
using FileExporter.Context;
using Moq;

namespace FileExporter.Tests
{
    public class ExportTests
    {
        [Fact]
        public void CsvExporter_Should_Export_Content()
        {
            // Arrange
            var exporter = new CsvExporter();
            var compression = new ZipCompression();

            // Act & Assert
            var exception = Record.Exception(() => exporter.Export("Test CSV Content"));
            Assert.Null(exception);
        }

        [Fact]
        public void PdfExporter_Should_Export_Content()
        {
            var exporter = new PdfExporter();
            var compression = new RarCompression();

            var exception = Record.Exception(() => exporter.Export("PDF Export Content"));
            Assert.Null(exception);
        }

        [Fact]
        public void ZipCompression_Should_Compress_File()
        {
            var strategy = new ZipCompression();
            var exception = Record.Exception(() => strategy.Compress("test.zip"));
            Assert.Null(exception);
        }

        [Fact]
        public void RarCompression_Should_Compress_File()
        {
            var strategy = new RarCompression();
            var exception = Record.Exception(() => strategy.Compress("test.rar"));
            Assert.Null(exception);
        }

        [Fact]
        public void CompressionContext_Should_Switch_Strategy_And_Compress()
        {
            var mockStrategy = new Mock<ICompressionStrategy>();
            var context = new CompressionContext(mockStrategy.Object);

            context.Compress("output.txt");

            mockStrategy.Verify(s => s.Compress("output.txt"), Times.Once);
        }
    }
}
