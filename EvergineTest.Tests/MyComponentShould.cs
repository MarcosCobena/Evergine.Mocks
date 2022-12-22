using Evergine.Common.Graphics;
using Evergine.Framework.Services;
using Evergine.Mocks;
using System.Diagnostics;
using Xunit;

namespace EvergineTest.Tests
{
    public class MyComponentShould
    {
        [Fact]
        public void ChangeMyBooleanPropertyToTrueOnStart()
        {
            // Arrange
            var application = new MyApplication();
            var windowsSystem = MockWindowsSystem.Create(application);

            // Act
            windowsSystem.RunOneLoop();

            // Assert
            var screenContextManager = application.Container.Resolve<ScreenContextManager>();
            var scene = screenContextManager.CurrentContext.FindScene<MyScene>();
            var entity = scene.Managers.EntityManager.Find("MyEntity");
            var component = entity.FindComponent<MyComponent>();
            Assert.True(component.MyBooleanProperty);
        }
    }
}