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
    }
}
