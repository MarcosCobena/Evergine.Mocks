using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockTexture : Texture
    {
        public MockTexture(GraphicsContext graphicsContext, ref TextureDescription description)
            : base(graphicsContext, ref description)
        {
        }

        public override string? Name { get; set; }

        public override IntPtr NativePointer => throw new NotImplementedException();
    }
}
