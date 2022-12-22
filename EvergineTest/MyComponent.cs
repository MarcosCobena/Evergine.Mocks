using Evergine.Framework;

namespace EvergineTest
{
    public class MyComponent : Component
    {
        public bool MyBooleanProperty { get; private set; }

        protected override void Start()
        {
            base.Start();

            this.MyBooleanProperty = true;
        }
    }
}
