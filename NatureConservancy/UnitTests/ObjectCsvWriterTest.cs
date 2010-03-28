using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Web.Services;

namespace UnitTests
{
    [TestFixture]
    public class ObjectCsvWriterTest
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _objectCsvWriter = new ObjectCsvWriter();
        }

        [TearDown]
        public void TearDown()
        {
            _objectCsvWriter = null;
        }

        #endregion

        private ObjectCsvWriter _objectCsvWriter;

        private static string GetStreamValue(Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            var streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();
        }

        public class TestObject
        {
            public string FirstName;
            public string LastName;
        }

        [Test]
        public void WriteToStreamTest()
        {
            var testObjects = new List<TestObject>();
            testObjects.Add(new TestObject {FirstName = "Fred", LastName = "Flintstone"});
            testObjects.Add(new TestObject { FirstName = "Barney", LastName = "Rubble" });

            using (var stream = new MemoryStream())
            {
                _objectCsvWriter.WriteToCSV(testObjects, stream, true);

                string streamValue = GetStreamValue(stream);
                Assert.AreEqual("\"Fred\",\"Flintstone\"\r\n\"Barney\",\"Rubble\"\r\n", streamValue);
            }
        }
    }
}