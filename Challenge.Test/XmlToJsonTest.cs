using ChallengeLib;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System;

namespace Challenge.Test
{
    [TestFixture]
    class XmlToJsonTest
    {
        [Test]
        public void ConvertXmlToJsonTest()
        {
            // Arrange
            var converter = new XmlConverter();
            var given = "<foo>bar</foo>";
            var expected = "{\"foo\":\"bar\"}";

            // Act
            var result = converter.ConvertToJson(given);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ExceptionWhenConvertMalformedXmlToJsonTest()
        {
            var converter = new XmlConverter();

            Assert.Throws<XmlException>(() => converter.ConvertToJson("<foo>a</baz>"));
        }

        [Test]
        public void ExceptionWhenFunctionArgIsNullTest()
        {
            var converter = new XmlConverter();

            Assert.Throws<ArgumentNullException>(() => converter.ConvertToJson(null));
        }
    }
}
