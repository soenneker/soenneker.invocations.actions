using System;
using System.Runtime.CompilerServices;

namespace Soenneker.Invocations.Actions;

/// <summary>
/// Deferred, stateful synchronous action invocation without closure capture.
/// </summary>
public sealed class ActionInvocation
{
    private readonly Action<object?> _action;

    /// <summary>
    /// Gets the state passed to the action when <see cref="Invoke"/> is called.
    /// </summary>
    public object? State { get; }

    /// <summary>
    /// Creates a deferred invocation from an action and its explicit state.
    /// </summary>
    /// <param name="action">The action to invoke.</param>
    /// <param name="state">The state supplied to <paramref name="action"/>.</param>
    public ActionInvocation(Action<object?> action, object? state)
    {
        _action = action ?? throw new ArgumentNullException(nameof(action));
        State = state;
    }

    /// <summary>
    /// Invokes the action with <see cref="State"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Invoke() => _action(State);
}
