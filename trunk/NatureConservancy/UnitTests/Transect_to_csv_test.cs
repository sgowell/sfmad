using IntegrationTests.Repositories;
using Moq;
using NUnit.Framework;
using Web.Models;
using Web.Services;

namespace UnitTests
{
    public class Transect_to_csv_test : base_test
    {
        private Transect transect = TransectFixture.Create();
        private Mock<ICsvWriter> csvWriter =new Mock<ICsvWriter>();
        public override void because()
        {
            new Transect[] {transect}.WriteTo(csvWriter);
        }

        [Test]
        public void should_write_transect_number()
        {
            Assert.Ignore("Need To Test");
        }
    }
}
