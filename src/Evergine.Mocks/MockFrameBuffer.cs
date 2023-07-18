using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockFrameBuffer : FrameBuffer
    {
        public override string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public override bool RequireFlipProjection => false;

        public MockFrameBuffer(FrameBufferAttachment? depthTarget, FrameBufferAttachment[] colorTargets)
        {
            this.DepthStencilTarget = depthTarget;
            this.ColorTargets = colorTargets;

            if (depthTarget.HasValue)
            {
                var textureDescription = depthTarget.Value.Texture.Description;
                this.Width = textureDescription.Width;
                this.Height = textureDescription.Height;
            }
        }
    }
}
