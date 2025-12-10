using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CodingExercise.Tests
{
    [TestFixture]
    public class StringOperationsTest
    {
        // Positive test case: Ensure that the CountCharacterOccurrences method correctly counts
        // the occurrences of each character in a non-empty string.
        [Test]
        public void CountCharacterOccurrences_ReturnsCorrectCounts()
        {
            // Arrange
            string input = "hello world";
            
            // Act
            var result = StringOperations.CountCharacterOccurrences(input);
            
            // Assert
            Assert.That(result['h'], Is.EqualTo(1));
            Assert.That(result['e'], Is.EqualTo(1));
            Assert.That(result['l'], Is.EqualTo(3));
            Assert.That(result['o'], Is.EqualTo(2));
            Assert.That(result[' '], Is.EqualTo(1));
            Assert.That(result['w'], Is.EqualTo(1));
            Assert.That(result['r'], Is.EqualTo(1));
            Assert.That(result['d'], Is.EqualTo(1));
        }

        // Negative test case: Ensure that the CountCharacterOccurrences method throws
        // an exception for an empty string.
        [Test]
        public void CountCharacterOccurrences_EmptyString_ThrowsException()
        {
            // Arrange
            string input = "";
            
            // Act & Assert
            Assert.Throws<ArgumentException>(() => StringOperations.CountCharacterOccurrences(input));
        }

        // Parameterized test case: Ensure that the CountCharacterOccurrences method
        // correctly counts the occurrences for various strings.
        [TestCase("programming", 'g', 2)]
        [TestCase("mississippi", 's', 4)]
        [TestCase("hello world", 'l', 3)]
        [TestCase("test string", 't', 3)]
        public void CountCharacterOccurrences_VariousInputs_ReturnsCorrectCounts(string input, char character, int expectedCount)
        {
            // Act
            var result = StringOperations.CountCharacterOccurrences(input);
            
            // Assert
            Assert.That(result[character], Is.EqualTo(expectedCount));
        }
    }
}
