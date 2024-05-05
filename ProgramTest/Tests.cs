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
            List<string> objects = new List<string> { "Ñ", "Ñ", "Ç", "Ñ", "Ê", "Ç", "Ç", "Ç", "Ê", "Ê", "Ñ", "Ç", "Ñ", "Ñ", "Ê", "Ç" };
            Dictionary<string, int> colorOrder = new Dictionary<string, int> { { "Ç", 1 }, { "Ñ", 2 }, { "Ê", 3 } };

            var orderedObjects = objects.OrderBy(obj => colorOrder.ContainsKey(obj) ? colorOrder[obj] : int.MaxValue).ToList();

            List<string> expected = new List<string> { "Ç", "Ç", "Ç", "Ç", "Ç", "Ç", "Ñ", "Ñ", "Ñ", "Ñ", "Ñ", "Ñ", "Ê", "Ê", "Ê", "Ê" };

            CollectionAssert.AreEqual(expected, orderedObjects);

        }
    }
}