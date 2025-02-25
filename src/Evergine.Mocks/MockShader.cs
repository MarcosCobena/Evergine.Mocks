using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockShader : Shader
    {
        public override string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public override nint NativePointer => throw new NotImplementedException();

        public MockShader(GraphicsContext context, ref ShaderDescription description)
            : base(context, ref description)
        {
        }

        protected override void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
