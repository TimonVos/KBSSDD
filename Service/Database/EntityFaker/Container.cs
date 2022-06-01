namespace Service.Database.EntityFaker
{
    public class Container<E> : IDisposable where E : class
    {
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

        public Container<E> Save()
        {
            if (!_isSaved)
                _save();

            _isSaved = true;

            return this;
        }

        public Container<E> Update()
        {
            if (_isSaved)
                _update();
            else
                throw new Exception("Container is not saved");

            return this;
        }

        public Container<E> Remove()
        {
            if (_isSaved)
                _remove();

            return this;
        }

        public void Dispose() => Remove();
    }
}
