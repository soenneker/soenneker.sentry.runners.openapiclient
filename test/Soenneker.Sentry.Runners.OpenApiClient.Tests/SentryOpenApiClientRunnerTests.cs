using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sentry.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SentryOpenApiClientRunnerTests : HostedUnitTest
{
    public SentryOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
