using IntegrationTests;
using NUnit.Framework;
using Web.Services;

namespace UnitTests
{
    [TestFixture]
    public class CsvWriterTests
    {
        [Test]
        public void creates_csv_columns_with_break()
        {
            var writer = new StringCsvWriter();
            writer.Delimiter = '|';
            writer.AddCell("hello");
            writer.AddCell("world");
            writer.EndLine();
            writer.Writer.ToString().ShouldEqual("hello|world\r\n");
        }

        [Test]
        public void creates_csv_columns_with_comma()
        {
            var writer = new StringCsvWriter();
            writer.Delimiter = ',';
            writer.AddCell("hello");
            writer.AddCell("world");
            writer.EndLine();
            writer.Writer.ToString().ShouldEqual("hello,world\r\n");
        }

        [Test]
        public void creates_csv_columns_with_comma_and_quotes()
        {
            var writer = new StringCsvWriter();
            writer.Delimiter = ',';
            writer.UseQuotes = true;
            writer.AddCell("hello");
            writer.AddCell("world");
            writer.EndLine();
            writer.Writer.ToString().ShouldEqual("\"hello\",\"world\"\r\n");
        }

        [Test]
        public void creates_csv_columns_with_comma_and_escaped_quotes()
        {
            var writer = new StringCsvWriter();
            writer.Delimiter = ',';
            writer.UseQuotes = true;
            writer.AddCell("he said \"the dude abides\"");
            writer.AddCell("world");
            writer.EndLine();
            writer.Writer.ToString().ShouldEqual("\"he said \\\"the dude abides\\\"\",\"world\"\r\n");
        }
    }
}