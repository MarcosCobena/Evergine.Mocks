using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockTexture : Texture
    {
        public MockTexture(MockGraphicsContext mockGraphicsContext, ref TextureDescription description)
            : base(mockGraphicsContext, ref description)
        {
        }

        public override string? Name { get; set; }

        public override IntPtr NativePointer => throw new NotImplementedException();
    }
}
