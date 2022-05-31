using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Model;
using Service.AssessmentServices;
using Service.Database;

namespace Service.UnitTest.Grade
{
    public class GradeCalculationTest
    {
        private Faker _faker = new Faker();

        private Assessment _assessment;
        private List<Rating> _ratings;
        private Project _project;
        private Group _group;
        private Form _form;
        private List<Competence> _competences;
        private List<Criterion> _criteria;
        private List<Requirement> _requirements;
        private List<Indicator> _indicators;

        [SetUp]
        public void SetUp()
        {
            _project = new Project { Name = _faker.Company.CompanyName(), Code = "VOE.OOSDH.ICTM" };
            _group = new Group { Name = "Groep 1", Number = 1, };
            _assessment = new Assessment { Group = _group, Project = _project };
            _form = new Form { Name = "KBS" };
            _competences = new List<Competence>
            {
                new Competence
                {
                    Description = _faker.Commerce.ProductDescription(), Name = "Analyseren", Weight = 80
                },
                new Competence
                {
                    Description = _faker.Commerce.ProductDescription(), Name = "Adviseren", Weight = 20
                }
            };
            _criteria = new List<Criterion>
            {
                new Criterion { Description = _faker.Company.CatchPhrase(), Name = "Communicatie" },
                new Criterion { Description = _faker.Company.CatchPhrase(), Name = _faker.Company.CatchPhrase() },
                new Criterion { Description = _faker.Company.CatchPhrase(), Name = _faker.Company.CatchPhrase() },
                new Criterion { Description = _faker.Company.CatchPhrase(), Name = _faker.Company.CatchPhrase() }
            };
            _indicators = new List<Indicator>
            {
                new Indicator { Forms = new List<Form> { _form }, Value = 7, Name = "Competent" },
                new Indicator { Forms = new List<Form> {_form}, Value = 3, Name = "Ontwikkelpunt"}
            };
            _requirements = new List<Requirement>
            {
                new Requirement
                {
                    Criterion = _criteria[0],
                    Description = "Bla Bla Bla",
                    Name = "Test",
                    Indicator = _indicators[0]
                },
                new Requirement
                {
                    Criterion = _criteria[1],
                    Description = "Test nummer 2",
                    Name = "Goed zo",
                    Indicator = _indicators[1]
                },
                new Requirement
                {
                Criterion = _criteria[2],
                Description = "Test nummer 3",
                Name = "Goed zo",
                Indicator = _indicators[0]
                },
                new Requirement
                {
                    Criterion = _criteria[3],
                    Description = "Test nummer 4",
                    Name = "Goed zo",
                    Indicator = _indicators[1]
                }
            };
            _ratings = new List<Rating>
            {
                new Rating { Assessment = _assessment, Criterion = _criteria[0], Requirement = _requirements[0] },
                new Rating { Assessment = _assessment, Criterion = _criteria[1], Requirement = _requirements[1]},
                new Rating { Assessment = _assessment, Criterion = _criteria[2], Requirement = _requirements[2]},
                new Rating { Assessment = _assessment, Criterion = _criteria[3], Requirement = _requirements[3]}
            };
            _form.Competences = _competences;
            _form.Projects.Add(_project);
            _competences[0].Criteria = new List<Criterion>();
            _competences[0].Criteria.Add(_criteria[2]);
            _competences[0].Criteria.Add(_criteria[3]);
            _competences[1].Criteria = new List<Criterion>();
            _competences[1].Criteria.Add(_criteria[0]);
            _competences[1].Criteria.Add(_criteria[1]);
            _criteria[0].Competence = _competences[1];
            _criteria[1].Competence = _competences[1];
            _criteria[2].Competence = _competences[0];
            _criteria[3].Competence = _competences[0];
            _criteria[0].Requirements = new List<Requirement>();
            _criteria[1].Requirements = new List<Requirement>();
            _criteria[0].Requirements.Add(_requirements[0]);
            _criteria[1].Requirements.Add(_requirements[1]);
            _criteria[0].Ratings = new List<Rating>();
            _criteria[1].Ratings = new List<Rating>();
            _criteria[0].Ratings.Add(_ratings[0]);
            _criteria[1].Ratings.Add(_ratings[1]);
            _requirements[0].Indicator = _indicators[0];
            _requirements[1].Indicator = _indicators[1];
            _ratings[0].Requirement = _requirements[0];
            _ratings[1].Requirement = _requirements[1];
            _assessment.Project = _project;
            _assessment.Project.Form = _form;
            _assessment.Group = _group;
            _assessment.Ratings = _ratings;

        }

        [Test, Order(1), NonParallelizable]
        public void AssessmentHelper_CanCalculateGradeFromRating()
        {
            using var context = new AssessmentContext();
            AssessmentHelper helper = new AssessmentHelper();
            

            Assert.That(helper.GetGrades(_assessment).FirstOrDefault().Value, Is.EqualTo(5));

            
        }

        [Test, Order(2), NonParallelizable]
        public void AssessmentHelper_CanCalculateMultipleGrades()
        {
            using var context = new AssessmentContext();
            AssessmentHelper helper = new AssessmentHelper();
            IDictionary<Competence, double> temp = helper.GetGrades(_assessment);
            Assert.That(temp[_competences[0]] , Is.EqualTo(temp[_competences[1]]));
        }
        [Test, Order(3), NonParallelizable]
        public void AssessmentHelper_FinalGradeCalculation_CanCalculateGradeCorrectly()
        {
            using var context = new AssessmentContext();
            AssessmentHelper helper = new AssessmentHelper();
            IDictionary<Competence, double> temp = helper.GetGrades(_assessment);
            Assert.That(helper.CalculateFinalGrade(temp) , Is.EqualTo(5));
        }
        [Test, Order(4), NonParallelizable]
        public void AssessmentHelper_CheckCriteriaAmount_CanCheckIfCompetenceIsFullyRated()
        {
            using var context = new AssessmentContext();
            AssessmentHelper helper = new AssessmentHelper();
            Assert.That(helper.CheckCriteriaAmount(_competences[0], _assessment.Ratings));
        }
        [Test, Order(5), NonParallelizable]
        public void AssessmentHelper_CheckAssessmentComplete_CanCheckEachCompetenceForCompletion()
        {
            using var context = new AssessmentContext();
            AssessmentHelper helper = new AssessmentHelper();
            Assert.That(helper.CheckAssessmentComplete(_assessment));
        }
        [Test, Order(6), NonParallelizable]
        public void AssessmentHelper_CheckAssessmentComplete_CanSeeMissingRatings()
        {
            using var context = new AssessmentContext();
            AssessmentHelper helper = new AssessmentHelper();
            _assessment.Ratings.Remove(_ratings[0]);
            Assert.That(!helper.CheckAssessmentComplete(_assessment));
        }
    }
}
