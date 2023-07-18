using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Mocks;
using System;
using Xunit;

namespace Sample.Tests
{
    public class Camera3dShould
    {
        private readonly Camera3D camera3d;

        private readonly MockWindowsSystem windowsSystem;

        public Camera3dShould()
        {
            this.camera3d = new Camera3D();
            var entity = new Entity()
                .AddComponent(new Transform3D())
                .AddComponent(this.camera3d);
            var scene = new MockScene();
            scene.Add(entity);
            var application = new MyApplication();
            this.windowsSystem = MockWindowsSystem.Create(application, scene);
        }

        [Fact]
        public void ProvideValidAspectRatio()
        {
            // Arrange

            // Act
            this.windowsSystem.RunOneLoop(TimeSpan.FromSeconds(1d / 60));

            // Assert
            Assert.NotEqual(-1, this.camera3d.AspectRatio);
        }
    }
}
