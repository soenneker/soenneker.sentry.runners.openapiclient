using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sentry.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SentryOpenApiClientRunnerTests : FixturedUnitTest
{
    public SentryOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
