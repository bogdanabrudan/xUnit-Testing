using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{
    public class CollectionsFixture
    {
        public Collections Col => new Collections();
    }

    public class CollectionsTests : IClassFixture<CollectionsFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CollectionsFixture _collectionsFixture;
        private readonly MemoryStream memoryStream;

        public CollectionsTests(ITestOutputHelper testOutputHelper, CollectionsFixture collectionsFixture)
        {
            _testOutputHelper = testOutputHelper;
            _collectionsFixture = collectionsFixture;
            _testOutputHelper.WriteLine("Constructor");

            memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
            var fibo = _collectionsFixture.Col;
            Assert.All(fibo.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {

            _testOutputHelper.WriteLine("FiboIncludes13");
            var fibo = _collectionsFixture.Col;
            Assert.Contains(13,fibo.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludes4()
        {
            var fibo = _collectionsFixture.Col;
            Assert.DoesNotContain(4, fibo.FiboNumbers);
        }

        public void Dispose()
        {
            memoryStream.Close();
        }
        
        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Collections(); 
            var result = calc.IsOdd(value);
            Assert.True(result);
        }
    }
}
