using Evergine.Common.Graphics;
using Evergine.Framework;
using System.Diagnostics;

namespace Evergine.Mocks
{
    public class MockWindowsSystem : WindowsSystem
    {
        private Action? renderCallback;

        private MockWindowsSystem()
        { 
        }

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
            throw new NotImplementedException();
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

        public static MockWindowsSystem Create(Application application)
        {
            var instance = new MockWindowsSystem();
            application.Container.RegisterInstance(instance);
            var graphicsContext = new MockGraphicsContext();
            graphicsContext.CreateDevice();
            var swapChainDescription = new SwapChainDescription()
            {
                //SurfaceInfo = window.SurfaceInfo,
                //Width = window.Width,
                //Height = window.Height,
                ColorTargetFormat = PixelFormat.R8G8B8A8_UNorm,
                ColorTargetFlags = TextureFlags.RenderTarget | TextureFlags.ShaderResource,
                DepthStencilTargetFormat = PixelFormat.D24_UNorm_S8_UInt,
                DepthStencilTargetFlags = TextureFlags.DepthStencil,
                SampleCount = TextureSampleCount.None,
                //IsWindowed = Windowed,
                RefreshRate = 60
            };
            var swapChain = graphicsContext.CreateSwapChain(swapChainDescription);
            //swapChain.VerticalSync = VSync;
            //var graphicsPresenter = application.Container.Resolve<GraphicsPresenter>();
            //var firstDisplay = new Display(window, swapChain);
            //graphicsPresenter.AddDisplay("DefaultDisplay", firstDisplay);
            application.Container.RegisterInstance(graphicsContext);
            var clockTimer = Stopwatch.StartNew();
            instance.Run(
                () =>
                {
                    application.Initialize();
                },
                () =>
                {
                    var gameTime = clockTimer.Elapsed;
                    clockTimer.Restart();

                    application.UpdateFrame(gameTime);
                    application.DrawFrame(gameTime);
                });

            return instance;
        }
    }
}