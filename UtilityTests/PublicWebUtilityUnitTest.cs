using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;

namespace UtilityTests
{
    [TestClass]
    public class PublicWebUtilityUnitTest
    {
        [TestMethod]
        public void TestCurrentShortDate()
        {
            WebUtility util = new PublicWebUtilityImpl();


            Assert.AreEqual(new DateTime().ToShortDateString(), util.GetCurrentShortDate());
        }

        [TestMethod]
        public void TestCurrentLongDate()
        {
            WebUtility util = new PublicWebUtilityImpl();

            Assert.AreEqual(new DateTime().ToLongDateString(), util.GetCurrentLongDate());
        }

        [TestMethod]
        public void TestShortDateFromEpoch()
        {
            WebUtility util = new PublicWebUtilityImpl();

            String expected1 = "1/1/1970";
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            //test that the epoch
            Assert.AreEqual(expected1, util.ShortDateFromEpoch(0));

            String expected2 = "3/06/2017";
            //test a more recent date
            Assert.AreEqual(expected2, util.ShortDateFromEpoch(1488812400000));
        }

        [TestMethod]
        public void TestEpochMillisFromString()
        {
            WebUtility util = new PublicWebUtilityImpl();

            var date1 = "Monday, March 6, 2017 9:00:00 AM";
            long expected1 = 1488812400000;

            Assert.AreEqual(expected1, util.EpochMillisFromString(date1));

            var date2 = "Thursday, January 1, 1970 12:00:00 AM";
            long expected2 = 0;

            Assert.AreEqual(expected2, util.EpochMillisFromString(date2));

            var date3 = "08/12/1993";
            long expected3 = 745113600000;

            Assert.AreEqual(expected3, util.EpochMillisFromString(date3));

        }

        [TestMethod]
        public void TestSecureMethod()
        {
            WebUtility util = new PublicWebUtilityImpl();
            Assert.AreEqual("Secure operations are not supported by this platform.", util.ToMD5(""));
        }
    }
}
