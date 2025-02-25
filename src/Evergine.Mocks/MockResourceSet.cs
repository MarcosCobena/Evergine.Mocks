using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockResourceSet : ResourceSet
    {
        public override string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public MockResourceSet(ref ResourceSetDescription description)
            : base(ref description)
        {
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
