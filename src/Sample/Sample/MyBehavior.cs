using Evergine.Common.Input.Keyboard;
using Evergine.Common.Input.Mouse;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using System;

namespace Sample
{
    public class MyBehavior : Behavior
    {
        [BindComponent(source: BindComponentSource.Scene)]
        protected Camera3D camera;

        [BindComponent]
        protected Transform3D transform3D;

        private bool isFirstTime;

        public MyBehavior()
        {
            this.isFirstTime = true;
        }

        public bool MyBooleanProperty { get; private set; }

        protected override void Update(TimeSpan gameTime)
        {
            if (this.isFirstTime)
            {
                this.isFirstTime = false;
            }
            else
            {
                this.MyBooleanProperty = true;
            }

            this.UpdateInputDispatchers();
        }

        private void UpdateInputDispatchers()
        {
            var position = this.transform3D.Position;
            var keyboardDispatcher = this.camera.Display.KeyboardDispatcher;

            if (keyboardDispatcher.IsKeyDown(Keys.Up))
            {
                position.Y++;
            }

            var mouseDispatcher = this.camera.Display.MouseDispatcher;

            if (mouseDispatcher.IsMouseOver
                && mouseDispatcher.IsButtonDown(MouseButtons.Left)
                && (mouseDispatcher.PositionDelta.X >= 100))
            {
                position.X++;
            }

            this.transform3D.Position = position;
        }
    }
}
