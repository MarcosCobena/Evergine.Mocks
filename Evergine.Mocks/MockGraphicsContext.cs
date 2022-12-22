using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    public class MockGraphicsContext : GraphicsContext
    {
        public MockGraphicsContext()
        {
            base.Factory = new MockResourceFactory(this);
            //PipelineStateCache = new DX11PipelineStateCache(this);
            //capabilities = new DX11Capabilities(this);
        }
        
        public override IntPtr NativeDevicePointer => throw new NotImplementedException();

        // TODO add new Test backend, for instance
        public override GraphicsBackend BackendType => GraphicsBackend.DirectX11;

        public override GraphicsContextCapabilities Capabilities => new MockGraphicsContextCapabilities();

        public override void CreateDeviceInternal()
        {
            // Intentionally empty
        }

        public override SwapChain CreateSwapChain(SwapChainDescription description)
        {
            return new MockSwapChain(description);
        }

        public override bool GenerateTextureMipmapping(Texture texture)
        {
            throw new NotImplementedException();
        }

        public override MappedResource MapMemory(GraphicsResource resource, MapMode mode, uint subResource = 0)
        {
            throw new NotImplementedException();
        }

        public override CompilationResult ShaderCompile(string shaderSource, string entryPoint, ShaderStages stage, CompilerParameters parameters)
        {
            throw new NotImplementedException();
        }

        public override void UnmapMemory(GraphicsResource resource, uint subResource = 0)
        {
            throw new NotImplementedException();
        }

        public override void UpdateTextureData(Texture texture, IntPtr source, uint sourceSizeInBytes, uint subResource)
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        protected override void InternalUpdateBufferData(Common.Graphics.Buffer buffer, IntPtr source, uint sourceSizeInBytes, uint destinationOffsetInBytes = 0)
        {
            throw new NotImplementedException();
        }
    }
}
