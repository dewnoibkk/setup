using System;
using NUnit.Framework;
using Setup.Web.Api.Controllers;
using Test.Core;

namespace Setup.Web.Api.Tests.Controllers
{
    class ValuesControllerTests : BaseTestFixture
    {
        private ValuesController target;

        public override void Setup()
        {
            this.target = new ValuesController();
        }

        [Test]
        public void Get_Test()
        {
            this.target.Get();

            Assert.Pass();
        }


        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void GetId_Test(int id)
        {
            this.target.Get(id);

            Assert.Pass();
        }

        [Test]
        [TestCase("Hello world")]
        public void Post_Test(string message)
        {
            Assert.Throws<NotSupportedException>(() => this.target.Post(message));
        }

        [Test]
        [TestCase(1, "Hello world")]
        public void Put_Test(int id, string value)
        {
            Assert.Throws<NotSupportedException>(() => this.target.Put(id, value));
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void Delete_Test(int id)
        {
            Assert.Throws<NotSupportedException>(() => this.target.Delete(id));
        }
    }
}
