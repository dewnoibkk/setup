using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace Test.Core
{
    [ExcludeFromCodeCoverage, TestFixture, Parallelizable(ParallelScope.All)]
    public abstract class BaseTestFixture
    {
        /// <summary>
        /// Identifies methods to be called once prior to any child tests.
        /// </summary>
        [OneTimeSetUp]
        public virtual void Initialize() { }

        /// <summary>
        /// Indicates a method of a TestFixture called just before each test method.
        /// </summary>
        [SetUp]
        public virtual void Setup() { }

        /// <summary>
        /// Marks a class with one-time setup or teardown methods for all the test fixtures in a namespace.
        /// </summary>
        [TearDown]
        public virtual void TearDown() { }

        /// <summary>
        /// Identifies methods to be called once after all child tests.
        /// </summary>
        [OneTimeTearDown]
        public virtual void Completed() { }
    }
}
