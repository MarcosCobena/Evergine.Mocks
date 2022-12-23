# EvergineTest

## Introduction

This repository looks for ways of testing applications made with Evergine.

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

### Changes needed in Evergine

- New GraphicsBackend value: Mock, None, Test