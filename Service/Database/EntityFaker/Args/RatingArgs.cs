using Model;

namespace Service.Database.EntityFaker.Args
{
    public class RatingArgs : FakerArgs
    {
        public Assessment Assessment
        {
            get => _assesssment; set
            {
                if (value != _assesssment)
                {
                    _assesssment = value;
                    RemoveRelated = false;
                }
            }
        }
        public Criterion Criterion
        {
            get => _criterion; set
            {
                if (value != _criterion)
                {
                    _criterion = value;
                    RemoveRelated = false;
                }
            }
        }
        public Requirement Requirement
        {
            get => _requirement; set
            {
                if (value != _requirement)
                {
                    _requirement = value;
                    RemoveRelated = false;
                }
            }
        }
        private Assessment _assesssment = EntityFaker.CreateAssessment();
        private Criterion _criterion = EntityFaker.CreateCriterion();
        private Requirement _requirement = EntityFaker.CreateRequirement();
    }
}
