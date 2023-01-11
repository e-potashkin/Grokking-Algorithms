using System.Collections.Generic;
using Chapter_2;
using NUnit.Framework;

namespace GrokkingAlgorithms.Tests;

class Chapter2Test
{
    private static readonly object[] _sourceLists =
    {
        new object[] {new List<int> {2, 3, 1}, new int[] { 1, 2, 3 } },
        new object[] {new List<int> {5, 6, 1, 4, 3, 2, 7, 9, 8}, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } }
    };

    [Test, TestCaseSource(nameof(_sourceLists))]
    public void SelectionSort_SelectionSorting_ReturnsExceptedArray(List<int> list, int[] expected)
    {
        var exp = SelectionSort.SelectionSorting(list);

        Assert.AreEqual(expected, exp);
    }
}
