using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void InitialTestReturnTrue()
        {
            //Arrange
            var expected = true;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("");
            //Assert
            Assert.AreEqual(expected, actual);

            //Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            //Arrange
            var expected = true;
            // Act
            var actual = BalancedBrackets.HasBalancedBrackets("");
            //Assert
            Assert.AreEqual(expected, actual);

           // Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void StringBetweenBracketsReturnsTrue()
        {
            //Arrange
            var expected = true;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("[LaunchCode]");
            //Assert
            Assert.AreEqual(expected, actual);

           // Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        [TestMethod]
        public void BracketsInsideOfStringReturnTrue()
        {
            //Arrange
            var expected = true;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("Launch[code]");
            //Assert
            Assert.AreEqual(expected, actual);

            //Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[code]"));
        }
        [TestMethod]
        public void BracketsOutsideOfStringReturnsTrue()
        {
            //Arrange
            var expected = true;
            // Act
            var actual = BalancedBrackets.HasBalancedBrackets("[]LaunchCode");
            //Assert
            Assert.AreEqual(expected, actual);

           // Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void TwoSetOfBracketsOutsideOfStringReturnTrue()
        {
            //Arrange
            var expected = true;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("[]LaunchCode[]");
            //Assert
            Assert.AreEqual(expected, actual);

           // Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]Launchcode[]"));
        }
        [TestMethod]
        public void NestedBracketsWithStringReturnTrue()
        {
            //Arrange
            var expected = true;
            // Act
            var actual = BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]");
            //Assert
            Assert.AreEqual(expected, actual);

           // Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]"));
        }
        [TestMethod]
        public void ReverseBracketsReturnFalse()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("][");
            //Assert
            Assert.AreEqual(expected, actual);

           // Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void OnlyOneBracketReturnsFalse()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("[LaunchCode");
            //Assert
            Assert.AreEqual(expected, actual);

            //Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }
        [TestMethod]
        public void WrongOrderBracketsWithStringReturnFalse()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("]LaunchCode[");
            //Assert
            Assert.AreEqual(expected, actual);

            //Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode["));
        }
        [TestMethod]
        public void MismatchBracketsReturnFalse()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("[Launch[code]");
            //Assert
            Assert.AreEqual(actual, expected);

           // Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launch[code]"));
        }
        [TestMethod]
        public void WrongOrderAndMismatchBracketsReturnFalse()
        {
            //Arrange
            var expected = false;
            //Act
            var actual = BalancedBrackets.HasBalancedBrackets("]Launch[code[");
            //Assert
            Assert.AreEqual(expected, actual);
            
            //Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Launch[code["));
        }
    }
}
