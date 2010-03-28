using IntegrationTests.Repositories;
using NUnit.Framework;
using Web;
using Web.Models;
using Web.Services;

namespace UnitTests
{
    [TestFixture]
    public class Transect_to_csv_test : base_test
    {
        private readonly Transect transect = TransectFixture.Create();
        private readonly PretendCsvWriter csvWriter = new PretendCsvWriter();

        public override void establish_context()
        {
            transect.Id = 123;
        }

        public override void because()
        {
            new[] {transect}.WriteTo(csvWriter);
        }

        public class PretendCsvWriter : StringCsvWriter
        {
        }

        [Test]
        public void should_write_transect_number()
        {
            string contents = csvWriter.GetContents();

            Assert.AreEqual("\"0\",\"0\",\"0\",\"123\"\r\n", contents);
        }
    }
}