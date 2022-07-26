using Microsoft.VisualStudio.TestTools.UnitTesting;
using MysampleLibrary;
using System;


namespace MySampleLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Checkparcelnumber_valid_number_istrue()
        //{
        //    string sampleparcelnumber = "BLR1234";
        //    bool validnumber = parcel.checkparcelnumber(sampleparcelnumber);
        //    Assert.IsTrue(validnumber);
        //}
        //[TestMethod]
        //public void Checkparcelnumber_valid_number_isfalse()
        //{
        //    string sampleparcelnumber = "1234";
        //    bool validnumber = parcel.checkparcelnumber(sampleparcelnumber);
        //    Assert.IsFalse(validnumber);
        //}
        [TestCase("BLR1234", true)]
        [TestCase("BLR1234", true)]
        public void charan(string parcelnumber,bool ER)
        {
            bool AR = parcel.checkparcelnumber(parcelnumber);
            Assert.AreEqual(AR, ER);
        }
    }
}
