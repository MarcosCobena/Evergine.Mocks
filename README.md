# Evergine.Mocks

## Introduction

This repository looks for ways of testing applications made with Evergine, inspired on [Xamarin.Forms.Mocks](https://github.com/jonathanpeppers/Xamarin.Forms.Mocks).

Goals:

- Enable testing components and behaviors
- Provide an artifact (NuGet, ideally) to be consumed by our real-world projects

Out of scope:

- Enable testing drawables or anything related to rendering

## Approach

The most of our applications contain a bunch of components (it-self, or behaviors/drawables) which contain logic.
Such components, usually, consume other artifacts from outside:

- other components
- services
- managers
- entities from its hierarchy

Beacause of this, isolating a component for testing is quite complicated.
However, we can rely on a mock Windows System which, in a headless fashion, replicates the same behavior the app would have.

## Status

- [x] Support running single update-draw loop on demand
- [x] Support reading actual Content
- [x] Support BindComponent attribute
- [x] Support BindService attribute
- [x] Support Camera3D.Display
- [ ] WIP Support custom KeyboardDispatcher
- [ ] WIP Support custom MouseDispatcher
- [ ] Support custom TouchDispatcher

### Changes needed in our projects

- Leave Application.Initialize() empty: refactor its entire logic into a separate public method, called from each WindowsSystem
  - This is needed to avoid tests to set the ScreenContext up and navigate to an actual Scene by default

```csharp
windowsSystem.Run(
    () =>
    {
        // Pull initialization logic from here...
        application.Initialize();
        // to here
        application.NavigateToMainScene();
    },
    () =>
    {
        [...]
    });
```

- Execute tests sequentially: Evergine currently does not support running tests in parallel
  - You can see how to do it with xUnit [here](https://github.com/MarcosCobena/Evergine.Mocks/blob/main/src/Sample/Sample.Tests/AssemblyInfo.cs)

### Changes needed in Evergine

- New GraphicsBackend value: Mock, None, Test
- Maybe: Allow running tests in parallel (it seems there are some static references preventing such)
