
using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockBuffer : Common.Graphics.Buffer
    {
        public MockBuffer(GraphicsContext context, ref BufferDescription description) : base(context, ref description)
        {
        }

        public override string? Name { get; set; }

        public override IntPtr NativePointer => throw new NotImplementedException();

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}