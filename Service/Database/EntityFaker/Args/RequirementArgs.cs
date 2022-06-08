using Model;

namespace Service.Database.EntityFaker.Args
{
    public class RequirementArgs : FakerArgs
    {
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
        public Indicator Indicator
        {
            get => _indicator; set
            {
                if (value != _indicator)
                {
                    _indicator = value;
                    RemoveRelated = false;
                }
            }
        }
        private Criterion _criterion = EntityFaker.CreateCriterion();
        private Indicator _indicator = EntityFaker.CreateIndicator();
    }
}
