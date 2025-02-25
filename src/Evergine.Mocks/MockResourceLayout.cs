using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockResourceLayout : ResourceLayout
    {
        public override string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public MockResourceLayout(ref ResourceLayoutDescription description)
            : base(ref description)
        {
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
