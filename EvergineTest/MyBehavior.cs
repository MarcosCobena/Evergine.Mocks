using Evergine.Framework;
using System;

namespace EvergineTest
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
            if (isFirstTime)
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
