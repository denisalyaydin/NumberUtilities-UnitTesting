using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberUtilitiesTests
{
    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenNoNumbersDivisibleByThree()
    {
        List<int> numbers = new List<int> { 1, 2, 4, 5, 7, 8 };

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsEmpty()
    {
        List<int> numbers = new List<int>();

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsNull()
    {
        List<int> numbers = null;

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnSingleNumber_WhenOnlyOneDivisibleByThree()
    {
        List<int> numbers = new List<int> { 1,3,4 };
        string expected = "3";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnOnlyNumbersDivisibleByThree_WhenListHasMixedValues()
    {
        List<int> numbers = new List<int> { 1, 3, 4, 6 ,8, 9 };
        string expected = "3, 6, 9";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldHandleNegativeNumbersCorrectly()
    {
        List<int> numbers = new List<int> { 1, 3, 4, -6, 8, -9 };
        string expected = "3, -6, -9";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnUniqueNumbers_WhenListHasDuplicates()
    {
        List<int> numbers = new List<int> { 1, 3, 3, 5, 6, 6, 10, 11 };
        string expected = "3, 6";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

}
