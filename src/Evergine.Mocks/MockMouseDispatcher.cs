using Evergine.Common.Input.Mouse;
using Evergine.Mathematics;

namespace Evergine.Mocks
{
    public class MockMouseDispatcher : MouseDispatcher
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

        public void Press(MouseButtons button)
        {
            this.HandleMouseButtonDown(button);
        }

        public void Release(MouseButtons button)
        {
            this.HandleMouseButtonUp(button);
        }

        public void Move(int x, int y)
        {
            this.HandleMouseMove(new Point(x, y));
        }

        public void Scroll(MouseScrollDirections direction)
        {
            this.HandleMouseScroll(direction);
        }
    }
}
