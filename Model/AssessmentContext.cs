namespace Model
{
    public class AssessmentContext
    {
        public List<Competence> Competences { get; set; } = new List<Competence>();
        public List<Criterion> Criteria { get; set; } = new List<Criterion>();

        public List<Indicator> Indicators { get; set; } = new List<Indicator>() {
            new Indicator("Ontwikkelpunt", 3),
            new Indicator("Competent", 7),
            new Indicator("Voorbeeldig", 9),
        };
        public List<Stipulation> Stipulations { get; set; } = new List<Stipulation>();
        public Group? Group { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();

        private readonly Random _random = new Random();

        public AssessmentContext()
        {
            CreateData();
        }

        private void CreateData()
        {
            Group = CreateGroup();
            CreateCompetences();
            CreateCriteria();
            CreateStipulations();
        }

        private Group CreateGroup()
        {
            var studentsCount = _random.Next(4, 7);
            var students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
                students.Add(new Student(Faker.RandomNumber.Next(1150000, 1170000), Faker.Name.FullName()));

            return new Group(Faker.Company.Name(), Faker.RandomNumber.Next(1, 7), students);
        }

        private void CreateCompetences()
        {
            var competencesCount = _random.Next(3, 7);

            for (int i = 0; i < competencesCount; i++)
                Competences.Add(new Competence(Faker.Lorem.Words(1).First(), 100 / competencesCount));
        }

        private void CreateCriteria()
        {
            foreach (var competence in Competences)
            {
                var criteriaCount = _random.Next(3, 13);

                for (int i = 0; i < criteriaCount; i++)
                    Criteria.Add(new Criterion(Faker.Lorem.Sentence(1), Faker.Lorem.Paragraph(), competence));
            }
        }

        private void CreateStipulations()
        {
            foreach (var criterion in Criteria)
                foreach (var indicator in Indicators)
                    Stipulations.Add(new Stipulation(criterion, indicator, Faker.Lorem.Sentence()));
        }

        public IEnumerable<Criterion> GetCriteria(Competence competence)
        {
            return from criterion in Criteria
                   where criterion.Competence == competence
                   select criterion;
        }

        public IEnumerable<Stipulation> GetStipulations(Criterion criterion)
        {
            return from stipulation in Stipulations
                   where stipulation.Criterion == criterion
                   select stipulation;
        }

        public IEnumerable<Stipulation> GetStipulation(Criterion criterion, Indicator indicator)
        {
            return from stipulation in Stipulations
                   where stipulation.Criterion == criterion
                   && stipulation.Indicator == indicator
                   select stipulation;
        }
        public IEnumerable<Rating> GetRatings(ISubject subject)
        {
            return from rating in Ratings
                   where rating.Subject == subject
                   select rating;
        }

        public Rating GetRating(ISubject subject, Criterion criterion)
        {
            return (from rating in Ratings
                    where rating.Subject == subject
                    && rating.Criterion == criterion
                    select rating).First();
        }
    }
}
