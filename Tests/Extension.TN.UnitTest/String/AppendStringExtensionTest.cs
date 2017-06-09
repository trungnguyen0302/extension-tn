using Extension.TN.String;
using NUnit.Framework;
using System.Linq;

namespace Extension.TN.UnitTest.String
{
    [TestFixture]
    [Category("StringExtension")]
    public class AppendStringExtensionTest
    {
        [TestCase(null, null, null)]
        [TestCase("", "abc", "abc")]
        [TestCase("abc", "", "abc")]
        [TestCase("abc", "xyz", "abc\r\nxyz")]
        public void AppendWithNewLine_InputExtendText_CheckAndAppendWithNewLine(string root, string append, string expected)
        {
            // Arrange
            // Act
            var actual = root.AppendWithNewLine(append);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, new string[] { "a", "b" }, "")]
        [TestCase("", new string[] { "a", "b" }, "")]
        [TestCase("a,b, c", new string[] { }, "")]
        [TestCase("a,b, c", new string[] { "c", "d", "e" }, "c")]
        [TestCase("a,b, c", new string[] { "c", "a", "d", "e" }, "a, c")]
        public void Intersected_StringWithComma_IntersectStringAndList(string textWithComma, string[] list, string expected)
        {
            // Arrange
            // Act
            var actual = textWithComma.Intersected(list.ToList());

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, null, "")]
        [TestCase("456", null, "456")]
        [TestCase("", "abc", "")]
        [TestCase("1,2,3", "", "1,2,3")]
        [TestCase("1,2,3", "4,5", "1,2,3")]
        [TestCase("1,2,3,4", "4,5,2", "1,3")]
        public void Eliminate_InputEliminationText_ReturnRootAfterElimination(string root, string elimination, string expected)
        {
            // Arrange
            // Act
            var actual = root.Eliminate(elimination);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}