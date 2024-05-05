using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestOrderObjectsByColorOrder()
        {
            List<string> objects = new List<string> { "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�" };
            Dictionary<string, int> colorOrder = new Dictionary<string, int> { { "�", 1 }, { "�", 2 }, { "�", 3 } };

            var orderedObjects = objects.OrderBy(obj => colorOrder.ContainsKey(obj) ? colorOrder[obj] : int.MaxValue).ToList();

            List<string> expected = new List<string> { "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�", "�" };

            CollectionAssert.AreEqual(expected, orderedObjects);

        }
    }
}