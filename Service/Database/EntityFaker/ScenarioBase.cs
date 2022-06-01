namespace Service.Database.EntityFaker
{
    public abstract class ScenarioBase<T> : IDisposable where T : ScenarioBase<T>
    {
        public bool IsSaved { get; protected set; } = false;
        public T Save()
        {
            if (!IsSaved)
            {
                SaveScenario();
                IsSaved = true;
            }

            return (T)this;
        }

        public T Remove()
        {
            if (IsSaved)
            {
                RemoveScenario();
                IsSaved = false;
            }

            return (T)this;
        }

        protected abstract void SaveScenario();

        protected abstract void RemoveScenario();

        public void Dispose()
        {
            Remove();
        }
    }
}
