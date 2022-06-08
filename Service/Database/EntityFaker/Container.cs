namespace Service.Database.EntityFaker
{
    /// <summary>
    /// Helper class to create disposable test data so that manual deletion is not required.
    /// </summary>
    /// <typeparam name="E">Targeted model</typeparam>
    public class Container<E> : IDisposable where E : class
    {
        /// <summary>
        /// Gets the instance of the model.
        /// </summary>
        public E Instance { get; set; }
        private bool _isSaved = false;
        private Action _save;
        private Action _update;
        private Action _remove;

        public Container(E entity, Action save, Action update, Action remove)
        {
            Instance = entity;
            _save = save;
            _update = update;
            _remove = remove;
        }
        /// <summary>
        /// Should save the model to the database.
        /// </summary>
        /// <returns></returns>
        public Container<E> Save()
        {
            if (!_isSaved)
                _save();

            _isSaved = true;

            return this;
        }
        /// <summary>
        /// Should update the model in the database.
        /// Must be saved first.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Container was not saved</exception>
        public Container<E> Update()
        {
            if (_isSaved)
                _update();
            else
                throw new Exception("Container is not saved");

            return this;
        }
        /// <summary>
        /// Removes the model from the database.
        /// </summary>
        /// <returns></returns>
        public Container<E> Remove()
        {
            if (_isSaved)
                _remove();

            return this;
        }

        public void Dispose() => Remove();
    }
}
