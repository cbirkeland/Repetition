using System;
using Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Test
{
    [TestClass]
    public class StringService_CutString_Tests
    {
        StringService s = new StringService();

        [TestMethod]
        public void should_add_dots_when_cut_is_made_within_string()
        {
            Assert.AreEqual("acad...", s.CutString("academy", 4));
        }

        [TestMethod]
        public void should_return_empty_string_when_cutting_at_zero()
        {
            Assert.AreEqual("", s.CutString("academy", 0));
        }
        [TestMethod]
        public void should_return_empty_string_when_cutting_empty_string()
        {
            Assert.AreEqual("", s.CutString("", 123));
        }

        [TestMethod]
        public void should_return_original_string_when_cutting_at_the_end_of_the_string()
        {
            Assert.AreEqual("academy", s.CutString("academy", 7));
        }

        [TestMethod]
        public void should_return_original_string_when_cutting_far_far_away()
        {
            Assert.AreEqual("academy", s.CutString("academy", 100));
        }

        [TestMethod]
        public void should_remove_whitespaces_when_cut_is_made_after_some_whitespaces()
        {
            Assert.AreEqual("itch...", s.CutString("itch    academy", 7));
        }


        [TestMethod]
        public void should_return_null_when_null_is_supplied()
        {
            Assert.AreEqual(null, s.CutString(null, 100));
        }


        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void should_throw_argument_exception_when_cutting_negative()
        {
            Assert.AreEqual("academy", s.CutString("academy", -10));
        }
    }
}
