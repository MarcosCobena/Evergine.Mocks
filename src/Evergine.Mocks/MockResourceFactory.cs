using Evergine.Common.Graphics;
using Evergine.Common.Graphics.Raytracing;

namespace Evergine.Mocks
{
    internal class MockResourceFactory : ResourceFactory
    {
        private MockGraphicsContext mockGraphicsContext;

        public MockResourceFactory(MockGraphicsContext mockGraphicsContext)
        {
            this.mockGraphicsContext = mockGraphicsContext;
        }

        protected override GraphicsContext GraphicsContext => this.mockGraphicsContext;

        public override QueryHeap CreateQueryHeap(ref QueryHeapDescription description)
        {
            throw new NotImplementedException();
        }

        protected override Common.Graphics.Buffer CreateBufferInternal(IntPtr data, ref BufferDescription description)
        {
            return new MockBuffer(this.mockGraphicsContext, ref description);
        }

        protected override CommandQueue CreateCommandQueueInternal(CommandQueueType queueType = CommandQueueType.Graphics)
        {
            return new MockCommandQueue(queueType);
        }

        protected override ComputePipelineState CreateComputePipelineInternal(ref ComputePipelineDescription description)
        {
            throw new NotImplementedException();
        }

        protected override FrameBuffer CreateFrameBufferInternal(FrameBufferAttachment? depthTarget, FrameBufferAttachment[] colorTargets, bool disposeAttachments)
        {
            return new MockFrameBuffer(depthTarget, colorTargets);
        }

        protected override GraphicsPipelineState CreateGraphicsPipelineInternal(ref GraphicsPipelineDescription description)
        {
            throw new NotImplementedException();
        }

        protected override RaytracingPipelineState CreateRaytracingPipelineInternal(ref RaytracingPipelineDescription description)
        {
            throw new NotImplementedException();
        }

        protected override ResourceLayout CreateResourceLayoutInternal(ref ResourceLayoutDescription description)
        {
            return new MockResourceLayout(ref description);
        }

        protected override ResourceSet CreateResourceSetInternal(ref ResourceSetDescription description)
        {
            return new MockResourceSet(ref description);
        }

        protected override SamplerState CreateSamplerStateInternal(ref SamplerStateDescription description)
        {
            return new MockSamplerState(this.mockGraphicsContext, ref description);
        }

        protected override Shader CreateShaderInternal(ref ShaderDescription description)
        {
            return new MockShader(this.mockGraphicsContext, ref description);
        }

        protected override Texture CreateTextureInternal(DataBox[] data, ref TextureDescription description, ref SamplerStateDescription samplerState)
        {
            return new MockTexture(this.mockGraphicsContext, ref description);
        }

        protected override Texture GetTextureFromNativePointerInternal(IntPtr texturePointer, ref TextureDescription textureDescription)
        {
            throw new NotImplementedException();
        }
    }
}
