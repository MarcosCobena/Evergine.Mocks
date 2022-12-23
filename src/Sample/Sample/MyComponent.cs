using Evergine.Common.Graphics;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using System.Diagnostics;

namespace Sample
{
    public class MyComponent : Component
    {
        [BindComponent]
        protected Transform3D transform3D;

        [BindService]
        protected GraphicsContext graphicsContext;

        [BindComponent]
        protected Camera3D camera;

        public bool MyBooleanProperty { get; private set; }

        protected override void Start()
        {
            base.Start();

            this.MyBooleanProperty = true;
            this.transform3D.Scale *= 2;
            Debug.WriteLine(this.graphicsContext.BackendType);
            Debug.WriteLine($"{this.camera.Display.Width}x{this.camera.Display.Height}");
        }
    }
}
