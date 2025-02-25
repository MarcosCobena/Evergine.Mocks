using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockCommandQueue : CommandQueue
    {
        private readonly GraphicsContext graphicsContext;

        public MockCommandQueue(CommandQueueType commandQueueType, GraphicsContext graphicsContext)
        {
            this.graphicsContext = graphicsContext;
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override CommandBuffer CommandBuffer()
        {
            return new MockCommandBuffer(this.graphicsContext);
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Submit()
        {
            // Intentionally empty
        }

        public override void WaitIdle()
        {
            // Intentionally empty
        }
    }
}
