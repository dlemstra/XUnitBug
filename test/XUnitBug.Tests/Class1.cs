using System;
using Xunit;

namespace XUnitBug.Tests
{
    public partial class AllClasses
    {
        [Collection(nameof(RunTestsSeparately))]
        public class Class1
        {
            [Fact]
            public void Test()
            {
                var random = new Random(1234);
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
