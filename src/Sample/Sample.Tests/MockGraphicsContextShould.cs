using Evergine.Mocks;
using System;
using Xunit;

namespace Sample.Tests
{
    public class MockGraphicsContextShould
    {
        [Fact]
        public void NotReturnNotImplementedExceptionInShaderCompile()
        {
            var scene = new ImGuiScene();
            var application = new MyApplication();
            var windowsSystem = MockWindowsSystem.Create(application, scene);

            windowsSystem.RunOneLoop(TimeSpan.FromSeconds(1d / 60));
        }
    }
}
