using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockSwapChain : SwapChain
    {
        private SwapChainDescription description;

        public MockSwapChain(SwapChainDescription description)
        {
            this.description = description;
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
            throw new NotImplementedException();
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