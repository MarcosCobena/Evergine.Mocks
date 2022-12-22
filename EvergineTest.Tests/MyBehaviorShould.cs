using Evergine.Common.Graphics;
using Evergine.Framework.Services;
using Evergine.Mocks;
using System.Diagnostics;
using Xunit;

namespace EvergineTest.Tests
{
    public class MyBehaviorShould
    {
        [Fact]
        public void KeepMyBooleanPropertyFalseOnStart()
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
            var component = entity.FindComponent<MyBehavior>();
            Assert.False(component.MyBooleanProperty);
        }

        [Fact]
        public void ChangeMyBooleanPropertyToTrueAfterTwoLoops()
        {
            // Arrange
            var application = new MyApplication();
            var windowsSystem = MockWindowsSystem.Create(application);

            // Act
            windowsSystem.RunOneLoop();
            windowsSystem.RunOneLoop();

            // Assert
            var screenContextManager = application.Container.Resolve<ScreenContextManager>();
            var scene = screenContextManager.CurrentContext.FindScene<MyScene>();
            var entity = scene.Managers.EntityManager.Find("MyEntity");
            var component = entity.FindComponent<MyBehavior>();
            Assert.True(component.MyBooleanProperty);
        }
    }
}