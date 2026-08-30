[![](https://img.shields.io/nuget/v/soenneker.invocations.actions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.invocations.actions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.invocations.actions/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.invocations.actions/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.invocations.actions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.invocations.actions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.invocations.actions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.invocations.actions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.invocations.actions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.invocations.actions/actions/workflows/codeql.yml)

# Soenneker.Invocations.Actions

Represents a deferred synchronous action with explicit state, allowing a static delegate to avoid closure allocation.

## Install

```bash
dotnet add package Soenneker.Invocations.Actions
```

## Usage

```csharp
using Soenneker.Invocations.Actions;

var batch = new UploadBatch();

var invocation = new ActionInvocation(
    static state => ((UploadBatch)state!).Flush(),
    batch);

workQueue.Enqueue(invocation);

// Later:
ActionInvocation pending = workQueue.Dequeue();
pending.Invoke();
```

`Invoke()` passes the stored `State` to the action. It is synchronous, can be called repeatedly, and does not catch exceptions thrown by the action.

Use a `static` lambda or static method when avoiding closure capture matters. A capturing lambda still works, but then the compiler creates the closure this type is intended to avoid. Value-type state is boxed because state is stored as `object`.
