using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace QuickTestsForm
{
    [TestFixture]
    class ReplaceTest
    {
        [Test]
        public void StringIsCorrectReplaced()
        {
            var textToReplace = "ajsdopfijsawhatever(1)ajsdopfijsa";

            const string pattern = @"\([0-9]*\)";

            var contadorRegex = new Regex("whatever"+pattern);

            textToReplace = contadorRegex.Replace(textToReplace, "whatever(2)");

            Assert.AreEqual("ajsdopfijsawhatever(2)ajsdopfijsa", textToReplace);
        }
    }
}
