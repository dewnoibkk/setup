using NUnit.Framework;
using Test.Core;

namespace Setup.Identity.Tests
{
    public class IdentityDemoTests : BaseTestFixture
    {
        private IdentityDemo target;
        public override void Setup()
        {
            base.Setup();
            this.target = new IdentityDemo();
        }

        [Test]
        public void Test()
        {
            this.target.Test();
        }
    }
}
