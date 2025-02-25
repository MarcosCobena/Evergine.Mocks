using Evergine.Framework;
using Evergine.UI;

namespace Sample
{
    public class ImGuiScene : Scene
    {
        public override void RegisterManagers()
        {
            base.RegisterManagers();
            this.Managers.AddManager(new ImGuiManager());
        }

        protected override void CreateScene()
        {
        }
    }
}
