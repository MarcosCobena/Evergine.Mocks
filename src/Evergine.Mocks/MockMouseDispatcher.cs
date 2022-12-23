using Evergine.Common.Input.Mouse;
using Evergine.Mathematics;

namespace Evergine.Mocks
{
    internal class MockMouseDispatcher : MouseDispatcher
    {
        public override CursorTypes CursorType => throw new NotImplementedException();

        public override bool TrySetCursorType(CursorTypes cursorType)
        {
            throw new NotImplementedException();
        }

        protected override bool NativeSetCursorPosition(Point position)
        {
            throw new NotImplementedException();
        }
    }
}
