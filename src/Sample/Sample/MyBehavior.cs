using Evergine.Framework;
using System;

namespace Sample
{
    public class MyBehavior : Behavior
    {
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
        }
    }
}
