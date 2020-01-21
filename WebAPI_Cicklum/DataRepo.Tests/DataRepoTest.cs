using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using Moq;
using BusinessModels;
using System.Collections.Generic;
using System.Linq;

namespace DataRepo.Tests
{
    [TestClass]
    public class DataRepoTest
    {
        private static Mock<IDetailsDataBusiness> mDetailsDataBusiness;
        private static Mock<IDataBusiness> mDataBusiness;
        private static IDataRepo repo;
        private const string NameBusiness = "NameBusinessMocked";

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            mDataBusiness = new Mock<IDataBusiness>();
            repo = new Repository.DataRepo(mDataBusiness.Object);
            Arrange();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            mDetailsDataBusiness = new Mock<IDetailsDataBusiness>();
            mDetailsDataBusiness.Setup(m => m.NumStaf).Returns(25);
            mDetailsDataBusiness.Setup(m => m.Type).Returns(Utilities.TypeEnum.Commercial);
            mDataBusiness.Setup(m => m.Details).Returns(new List<IDetailsDataBusiness>() { mDetailsDataBusiness.Object });
            repo.DataBusiness = mDataBusiness.Object;
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            mDetailsDataBusiness.Invocations.Clear();
            mDataBusiness.Invocations.Clear();
        }

        [TestMethod]
        public void TestWithoutDetailsModified()
        { 
            //act
            var result = repo.GetData();
            //assert
            Assert.IsTrue(result.Details.FirstOrDefault().Type == Utilities.TypeEnum.Commercial);
            Assert.IsTrue(result.Details.FirstOrDefault().NumStaf == 25);
            Assert.AreEqual(result.Name, NameBusiness);
        }

        [TestMethod]
        public void TestWithDataModified()
        {
            //arrange
            mDetailsDataBusiness.Setup(m => m.NumStaf).Returns(200);
            mDetailsDataBusiness.Setup(m => m.Type).Returns(Utilities.TypeEnum.Industrial);
            mDataBusiness.Setup(m => m.Details).Returns(new List<IDetailsDataBusiness>() { mDetailsDataBusiness.Object });
            repo.DataBusiness = mDataBusiness.Object;
            //act
            var result = repo.GetData();
            //assert
            Assert.IsTrue(result.Details.FirstOrDefault().Type == Utilities.TypeEnum.Industrial);
            Assert.IsTrue(result.Details.FirstOrDefault().NumStaf == 200);
            Assert.AreEqual(result.Name, NameBusiness);
        }

        #region private methods

        private static void Arrange()
        {
            mDataBusiness.Setup(m => m.Name).Returns(NameBusiness);
        }
        
        #endregion
    }
}
