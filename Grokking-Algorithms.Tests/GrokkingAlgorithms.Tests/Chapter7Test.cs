using Chapter_7;
using NUnit.Framework;

namespace GrokkingAlgorithms.Tests;

class Chapter7Test
{
    [TestCase(ExpectedResult = "[a, 5], [b, 2], [fin, 6]")]
    public string FindLowest_Find_ReturnString()
    {
        return FindLowest.Find();
    }
}
