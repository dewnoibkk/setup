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
    }
}
