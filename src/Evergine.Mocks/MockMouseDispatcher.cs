using Evergine.Common.Input.Mouse;
using Evergine.Mathematics;

namespace Evergine.Mocks
{
    public class MockMouseDispatcher : MouseDispatcher
    {
        private CursorTypes currentCursorType;

        public override CursorTypes CursorType => this.currentCursorType;

        public override bool TrySetCursorType(CursorTypes cursorType)
        {
            this.currentCursorType = cursorType;

            return true;
        }

        protected override bool NativeSetCursorPosition(Point position)
        {
            return true;
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

        public void Enter(int x, int y)
        {
            this.HandleMouseEnter(new Point(x, y));
        }

        public void Leave(int x, int y)
        {
            this.HandleMouseLeave(new Point(x, y));
        }
    }
}
