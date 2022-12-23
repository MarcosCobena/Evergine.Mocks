using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockGraphicsContextCapabilities : GraphicsContextCapabilities
    {
        public override bool IsComputeShaderSupported => false;

        public override bool FlipProjectionRequired => throw new NotImplementedException();

        public override MatrixMajorness MatrixMajorness => throw new NotImplementedException();

        public override bool IsMRTSupported => throw new NotImplementedException();

        public override bool IsShadowMapSupported => false;

        public override ClipDepth ClipDepth => ClipDepth.ZeroToOne;

        public override MultiviewStrategy MultiviewStrategy => MultiviewStrategy.Unsupported;

        public override bool IsRaytracingSupported => throw new NotImplementedException();
    }
}
