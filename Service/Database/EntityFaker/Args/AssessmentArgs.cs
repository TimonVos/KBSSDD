using Model;

namespace Service.Database.EntityFaker.Args
{
    public class AssessmentArgs : FakerArgs
    {
        public Group Group
        {
            get => _group; set
            {
                if (value != _group)
                {
                    _group = value;
                    RemoveRelated = false;
                }
            }
        }
        public Project Project
        {
            get => _project; set
            {
                if (value != _project)
                {
                    _project = value;
                    RemoveRelated = false;
                }
            }
        }
        private Group _group = EntityFaker.CreateGroup();
        private Project _project = EntityFaker.CreateProject();
    }
}
