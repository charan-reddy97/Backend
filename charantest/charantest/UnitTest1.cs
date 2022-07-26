using MysampleLibrary;
using NUnit.Framework;


namespace MySampleLibraryTest
{

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
        //[TestCase("BLR1234", true)]
       // [TestCase("BLR 1234", true)]
        //public void charan(string parcelnumber, bool ER)
        //{
        //    bool AR = parcel.checkparcelnumber(parcelnumber);
        //    Assert.AreEqual(AR, ER);
        //}
        [Test]
        public void addition()
        {
            string sampleparcel = "1234";
            bool addition = int.Parse(parcel.add(sampleparcel));
            Assert.IsTrue(addition);
        }

    }
}