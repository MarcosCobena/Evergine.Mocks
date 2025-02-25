using Evergine.Framework;
using Evergine.UI;

namespace Sample
{
    public class ImGuiScene : Scene
    {
        public override void RegisterManagers()
        {
            base.RegisterManagers();
            this.Managers.AddManager(new ImGuiManager()
            {
                ////ImGuizmoEnabled = true,
                ////ImPlotEnabled = true,
                ////ImNodesEnabled = false,
                ////CustomFonts = [".\\Roboto.ttf",],
            });
        }

        protected override void CreateScene()
        {
        }
    }
}
