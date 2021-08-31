using Xunit;

namespace XUnitBug.Tests
{

    [CollectionDefinition(nameof(RunTestsSeparately), DisableParallelization = true)]
    public class RunTestsSeparately
    {
    }
}
