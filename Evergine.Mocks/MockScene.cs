using Evergine.Framework;

namespace Evergine.Mocks
{
    public class MockScene : Scene
    {
        private readonly List<Entity> entitiesToAddOnCreation;

        public MockScene()
        {
            this.entitiesToAddOnCreation = new List<Entity>();
        }

        public void Add(Entity entity)
        {
            this.entitiesToAddOnCreation.Add(entity);
        }

        protected override void CreateScene()
        {
            base.CreateScene();

            foreach (var item in this.entitiesToAddOnCreation)
            {
                this.Managers.EntityManager.Add(item);
            }

            this.entitiesToAddOnCreation.Clear();
        }
    }
}
