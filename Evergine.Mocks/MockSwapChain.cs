﻿using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockSwapChain : SwapChain
    {
        public MockSwapChain(SwapChainDescription _)
        {
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override Texture GetCurrentFramebufferTexture()
        {
            throw new NotImplementedException();
        }

        public override void Present()
        {
            // Intentionally empty
        }

        public override void RefreshSurfaceInfo(SurfaceInfo surfaceInfo)
        {
            throw new NotImplementedException();
        }

        public override void ResizeSwapChain(uint width, uint height)
        {
            throw new NotImplementedException();
        }
    }
}