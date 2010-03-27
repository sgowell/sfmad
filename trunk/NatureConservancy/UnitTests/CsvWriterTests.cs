using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntegrationTests;
using NUnit.Framework;
using Web.Services;

namespace UnitTests
{
    [TestFixture]
    public class CsvWriterTests
    {
        [Test]
        public void creates_csv_columns()
        {
            var writer = new StringCsvWriter();
            writer.AddCell("hello");
            writer.AddCell("world");
            writer.EndLine();
            writer.Writer.ToString().ShouldEqual("hello,world\r\n");
            Assert.Ignore("Consider Delimiters");
        }
    }
}
