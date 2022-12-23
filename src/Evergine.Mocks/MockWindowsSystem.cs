using Evergine.Common.Graphics;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Framework.Services;

namespace Evergine.Mocks
{
    public class MockWindowsSystem : WindowsSystem
    {
        private Action? renderCallback;

        private MockWindow? mockWindow;

        private MockWindowsSystem()
        {
        }

        public MockKeyboardDispatcher? KeyboardDispatcher => (MockKeyboardDispatcher?)this.mockWindow?.KeyboardDispatcher;

        public MockMouseDispatcher? MouseDispatcher => (MockMouseDispatcher?)this.mockWindow?.MouseDispatcher;

        public override Surface CreateSurface(uint width, uint height)
        {
            throw new NotImplementedException();
        }

        public override Surface CreateSurface(object nativeSurface)
        {
            throw new NotImplementedException();
        }

        public override Window CreateWindow(string title, uint width, uint height, bool visible = true)
        {
            this.mockWindow = new MockWindow(title, width, height);

            return this.mockWindow;
        }

        protected override void CreateLoopThread(Action loadAction, Action renderCallback)
        {
            loadAction();
            this.renderCallback = renderCallback;
        }

        public void RunOneLoop()
        {
            this.renderCallback?.Invoke();
        }

        public static MockWindowsSystem Create(Application application, Scene scene)
        {
            var instance = new MockWindowsSystem();
            application.Container.RegisterInstance(instance);
            const uint width = 1280;
            const uint height = 720;
            var window = instance.CreateWindow(string.Empty, width, height);
            var graphicsContext = new MockGraphicsContext();
            graphicsContext.CreateDevice();
            var swapChainDescription = new SwapChainDescription()
            {
                ColorTargetFormat = PixelFormat.R8G8B8A8_UNorm,
                ColorTargetFlags = TextureFlags.RenderTarget | TextureFlags.ShaderResource,
                DepthStencilTargetFormat = PixelFormat.D24_UNorm_S8_UInt,
                DepthStencilTargetFlags = TextureFlags.DepthStencil,
                SampleCount = TextureSampleCount.None,
                RefreshRate = 60,
            };
            var swapChain = graphicsContext.CreateSwapChain(swapChainDescription);
            var graphicsPresenter = application.Container.Resolve<GraphicsPresenter>();
            var firstDisplay = new Display(window, swapChain);
            graphicsPresenter.AddDisplay("DefaultDisplay", firstDisplay);
            application.Container.RegisterInstance(graphicsContext);
            float oneFrameLengthMilliseconds = 1000f / swapChainDescription.RefreshRate;
            var oneFrameLength = TimeSpan.FromMilliseconds(oneFrameLengthMilliseconds);
            var gameTime = TimeSpan.Zero;
            instance.Run(
                () =>
                {
                    application.Initialize();
                    var screenContextManager = application.Container.Resolve<ScreenContextManager>();
                    var screenContext = new ScreenContext(scene);
                    screenContextManager.To(screenContext);
                },
                () =>
                {
                    gameTime += oneFrameLength;
                    application.UpdateFrame(gameTime);
                    application.DrawFrame(gameTime);
                });

            return instance;
        }
    }
}
