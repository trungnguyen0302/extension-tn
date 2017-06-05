using Extension.TN.String;
using NUnit.Framework;

namespace Extension.TN.UnitTest.String
{
    [TestFixture]
    [Category("StringExtension")]
    public class InternalStringExtensionTest
    {
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("1,2,3,,,,3", "1,2,3")]
        [TestCase("1,2,3,  ,2,,3", "1,2,3")]
        public void Distinct_InputText_DistinctWithComma(string text, string expected)
        {
            // Arrange
            // Act
            var actual = text.DistinctWithComma();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("<b>AAA", "AAA")]
        [TestCase("<span>AAA</span>", "AAA")]
        [TestCase("&gt;", ">")]
        public void StripHtml_HtmlText_DecodeText(string text, string expected)
        {
            // Arrange
            // Act
            var actual = text.StripHtml();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}