using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Mocks;
using Xunit;

namespace EvergineTest.Tests
{
    public class MyComponentShould
    {
        private readonly MyComponent component;

        private readonly MockWindowsSystem windowsSystem;

        public MyComponentShould()
        {
            this.component = new MyComponent();
            var entity = new Entity()
                .AddComponent(component)
                .AddComponent(new Transform3D());
            var scene = new MockScene();
            scene.Add(entity);
            var application = new MyApplication();
            this.windowsSystem = MockWindowsSystem.Create(application, scene);
        }
        [Fact]
        public void KeepMyBooleanPropertyFalseBeforeStarting()
        {
            // Arrange

            // Act

            // Assert
            Assert.False(this.component.MyBooleanProperty);
        }
        [Fact]
        public void ChangeMyBooleanPropertyToTrueOnStart()
        {
            // Arrange
            
            // Act
            windowsSystem.RunOneLoop();

            // Assert
            Assert.True(component.MyBooleanProperty);
        }
    }
}