using Evergine.Framework;
using Evergine.Mocks;
using Xunit;

namespace Sample.Tests
{
    public class MyBehaviorShould
    {
        private readonly MyBehavior component;

        private readonly MockWindowsSystem windowsSystem;

        public MyBehaviorShould()
        {
            this.component = new MyBehavior();
            var entity = new Entity()
                .AddComponent(this.component);
            var scene = new MockScene();
            scene.Add(entity);
            var application = new MyApplication();
            this.windowsSystem = MockWindowsSystem.Create(application, scene);
        }

        [Fact]
        public void KeepMyBooleanPropertyFalseOnStart()
        {
            // Arrange

            // Act
            this.windowsSystem.RunOneLoop();

            // Assert
            Assert.False(this.component.MyBooleanProperty);
        }

        [Fact]
        public void ChangeMyBooleanPropertyToTrueAfterTwoLoops()
        {
            // Arrange

            // Act
            this.windowsSystem.RunOneLoop();
            this.windowsSystem.RunOneLoop();

            // Assert
            Assert.True(this.component.MyBooleanProperty);
        }
    }
}
