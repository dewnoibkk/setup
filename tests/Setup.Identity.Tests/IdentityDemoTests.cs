using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Test.Core;

namespace Setup.Identity.Tests
{
    class IdentityDemoTests : BaseTestFixture
    {
        private IdentityDemo target;

        public override void Setup()
        {
            this.target = new IdentityDemo();
        }

        [Test]
        public void Demo_Test()
        {
            this.target.Demo();

            Assert.Pass();
        }

        [Test]
        public void SonarTest()
        {
            this.target.SonarTest();

            Assert.Pass();
        }
    }
}
