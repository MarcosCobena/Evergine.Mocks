**IMPORTANT:** this repository has been moved to [Evergine](https://github.com/EvergineTeam), we will take care of it from there.

# Evergine.Mocks

[![Tests status](https://github.com/MarcosCobena/Evergine.Mocks/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MarcosCobena/Evergine.Mocks/actions/workflows/dotnet.yml)
[![Nuget](https://img.shields.io/nuget/v/Evergine.Mocks)](https://www.nuget.org/packages/Evergine.Mocks)

## Introduction

Library to enable testing applications made with Evergine, inspired on [Xamarin.Forms.Mocks](https://github.com/jonathanpeppers/Xamarin.Forms.Mocks).

Goals:

- Enable testing components and behaviors

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

- [x] running single update-draw loop on demand
- [x] reading actual Content
- [x] BindComponent attribute
- [x] BindService attribute
- [x] Camera3D.Display
- [x] mock KeyboardDispatcher
- [x] mock MouseDispatcher
- [ ] mock TouchDispatcher

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
