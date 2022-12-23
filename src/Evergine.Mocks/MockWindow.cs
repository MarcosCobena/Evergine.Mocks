using Evergine.Common.Graphics;
using Evergine.Common.Input.Keyboard;
using Evergine.Common.Input.Mouse;
using Evergine.Common.Input.Pointer;

namespace Evergine.Mocks
{
    internal class MockWindow : Window
    {
        public MockWindow(string title, uint width, uint height)
            : base(title, width, height)
        {
            this.KeyboardDispatcher = new MockKeyboardDispatcher();
            this.MouseDispatcher = new MockMouseDispatcher();
            this.TouchDispatcher = new MockTouchDispatcher();
        }

        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool Visible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override KeyboardDispatcher KeyboardDispatcher { get; }

        public override MouseDispatcher MouseDispatcher { get; }

        public override PointerDispatcher TouchDispatcher { get; }
    }
}
