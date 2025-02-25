using Evergine.Common.Graphics;

namespace Evergine.Mocks
{
    internal class MockGraphicsPipelineState : GraphicsPipelineState
    {
        public override string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public MockGraphicsPipelineState(ref GraphicsPipelineDescription description)
            : base(ref description)
        {
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
