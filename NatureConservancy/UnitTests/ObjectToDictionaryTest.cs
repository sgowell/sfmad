using System;
using System.Linq;
using NUnit.Framework;
using Web.Services;

namespace UnitTests
{
    [TestFixture]
    public class ObjectToDictionaryTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            _ObjectConverter = new ObjectConverter();
        }

        [TearDown]
        public void TearDown()
        {
            _ObjectConverter = null;
        }

        #endregion

        private ObjectConverter _ObjectConverter;

        public class FavoriteObject
        {
            public string FavoriteColor;
            public DateTime FavoriteDate;
            public int FavoriteNumber;
            public SubFavorite SubFavoriteInstance;

            #region Nested type: SubFavorite

            public class SubFavorite
            {
                public string Dummy;
            }

            #endregion
        }

        [Test]
        public void TestActualType()
        {
            var testObject = new FavoriteObject {FavoriteColor = "green", FavoriteNumber = 1, FavoriteDate = new DateTime(2010, 1, 2)};

            var result = _ObjectConverter.ToDictionary(testObject);
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.That((string) result["FavoriteColor"] == testObject.FavoriteColor);
            Assert.That((int) result["FavoriteNumber"] == 1);
            Assert.That((DateTime) result["FavoriteDate"] == testObject.FavoriteDate);
        }

        [Test]
        public void TestActualTypeWithSubTypeIncluded()
        {
            var testObject = new FavoriteObject { FavoriteColor = "green", FavoriteNumber = 1, FavoriteDate = new DateTime(2010, 1, 2) };

            var result = _ObjectConverter.ToDictionary(testObject, true);
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count());
            Assert.That((string)result["FavoriteColor"] == testObject.FavoriteColor);
            Assert.That((int)result["FavoriteNumber"] == 1);
            Assert.That((DateTime)result["FavoriteDate"] == testObject.FavoriteDate);
        }

        [Test]
        public void TestAnonymousType()
        {
            var testObject = new {FavoriteColor = "green", FavoriteNumber = 1, FavoriteDate = new DateTime(2010, 1, 2)};

            var result = _ObjectConverter.ToDictionary(testObject);
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.That((string) result["FavoriteColor"] == testObject.FavoriteColor);
            Assert.That((int) result["FavoriteNumber"] == 1);
            Assert.That((DateTime) result["FavoriteDate"] == testObject.FavoriteDate);
        }
    }
}