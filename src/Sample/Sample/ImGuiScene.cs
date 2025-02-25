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
            this.Managers.AddManager(new global::Evergine.Bullet.BulletPhysicManager3D());
        }

        protected override void CreateScene()
        {
        }
    }
}
