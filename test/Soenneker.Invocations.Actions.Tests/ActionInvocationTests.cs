using System;
using System.Threading.Tasks;
using Soenneker.Tests.Unit;

namespace Soenneker.Invocations.Actions.Tests;

public sealed class ActionInvocationTests : UnitTest
{
    [Test]
    public void Default()
    {

    }

    [Test]
    public async Task Invoke_passes_explicit_state()
    {
        var counter = new Counter();
        var invocation = new ActionInvocation(static state => ((Counter)state!).Value++, counter);

        invocation.Invoke();
        invocation.Invoke();

        await Assert.That(counter.Value).IsEqualTo(2);
        await Assert.That(invocation.State).IsSameReferenceAs(counter);
    }

    private sealed class Counter
    {
        public int Value { get; set; }
    }
}
