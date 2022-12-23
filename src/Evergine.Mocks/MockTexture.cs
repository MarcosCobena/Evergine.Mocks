using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockTexture : Texture
    {
        private MockGraphicsContext mockGraphicsContext;
        
        private TextureDescription description;

        public MockTexture(MockGraphicsContext mockGraphicsContext, ref TextureDescription description)
            : base(mockGraphicsContext, ref description)
        {
            this.mockGraphicsContext = mockGraphicsContext;
            this.description = description;
        }

        public override string Name { get; set; }

        public override IntPtr NativePointer => throw new NotImplementedException();
    }
}