[![](https://img.shields.io/nuget/v/soenneker.invocations.actions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.invocations.actions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.invocations.actions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.invocations.actions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.invocations.actions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.invocations.actions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.invocations.actions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.invocations.actions/actions/workflows/codeql.yml)

# Soenneker.Invocations.Actions

Deferred, stateful synchronous action invocation without closure capture.

## Install

```bash
dotnet add package Soenneker.Invocations.Actions
```

## What you get

- `ActionInvocation` — Deferred, stateful synchronous action invocation without closure capture.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ActionInvocation.State` | Gets state. | Gets state. |
