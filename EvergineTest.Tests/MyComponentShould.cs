using Evergine.Framework;
using Evergine.Mocks;
using Xunit;

namespace EvergineTest.Tests
{
    public class MyComponentShould
    {
        [Fact]
        public void ChangeMyBooleanPropertyToTrueOnStart()
        {
            // Arrange
            var component = new MyComponent();
            var entity = new Entity()
                .AddComponent(component);
            var scene = new MockScene();
            scene.Add(entity);
            var application = new MyApplication();
            var windowsSystem = MockWindowsSystem.Create(application, scene);

            // Act
            windowsSystem.RunOneLoop();

            // Assert
            Assert.True(component.MyBooleanProperty);
        }
    }
}