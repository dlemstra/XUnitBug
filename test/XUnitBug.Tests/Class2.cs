using System;
using Xunit;

namespace XUnitBug.Tests
{
    public partial class AllClasses
    {
        [CollectionDefinition(nameof(RunTestsSeparately))]
        public class Class2
        {
            [Fact]
            public void Test()
            {
                var random = new Random(5678);
                for (var i = 0; i < 1_000_000; i++)
                {
                    var value = random.Next();
                    SharedClass.Value = value;

                    Assert.Equal(value, SharedClass.Value);
                }
            }
        }
    }
}
