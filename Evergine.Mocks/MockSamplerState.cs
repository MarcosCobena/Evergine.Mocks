using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockSamplerState : SamplerState
    {
        public MockSamplerState(GraphicsContext context, ref SamplerStateDescription description) : base(context, ref description)
        {
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override IntPtr NativePointer => throw new NotImplementedException();
    }
}