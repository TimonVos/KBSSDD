namespace Service.Database.EntityFaker
{
    /// <summary>
    /// Base class for scenarios.
    /// T must be the class that inherits this class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ScenarioBase<T> : IDisposable where T : ScenarioBase<T>
    {
        /// <summary>
        /// Tracks whether the model has been saved or not.
        /// </summary>
        public bool IsSaved { get; protected set; } = false;
        /// <summary>
        /// Saves the model to the database.
        /// </summary>
        /// <returns></returns>
        public T Save()
        {
            if (!IsSaved)
            {
                SaveScenario();
                IsSaved = true;
            }

            return (T)this;
        }
        /// <summary>
        /// Removes the model from the database.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void Dispose()
        {
            Remove();
        }
    }
}
