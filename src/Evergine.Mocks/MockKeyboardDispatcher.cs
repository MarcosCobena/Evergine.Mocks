using Evergine.Common.Input.Keyboard;

namespace Evergine.Mocks
{
    public class MockKeyboardDispatcher : KeyboardDispatcher
    {
        public void Press(Keys key)
        {
            this.HandleKeyDown(key);
        }

        public void Release(Keys key)
        {
            this.HandleKeyUp(key);
        }

        public void Type(char character)
        {
            this.HandleKeyChar(character);
        }
    }
}
