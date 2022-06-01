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
    public class RatingSaveTest
    {
        private Faker _faker = new Faker();

        private Assessment _assessment;
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
            _assessment = new Assessment();
            _form = new Form { Name = "KBS" };
            _competences = new List<Competence>
            {
                new Competence
                {
                    Description = _faker.Commerce.ProductDescription(), Name = "Analyseren", Weight = 80,
                    Evidence = "Sprint Backlog"
                },
                new Competence
                {
                    Description = _faker.Commerce.ProductDescription(), Name = "Adviseren", Weight = 20,
                    Evidence = "Product Backlog"
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
            _requirements[0].Indicator = _indicators[0];
            _requirements[1].Indicator = _indicators[1];
            _assessment.Project = _project;
            _assessment.Project.Form = _form;
            _assessment.Group = _group;
        }

        [Test, Order(1), NonParallelizable]
        public void AssessmentHelper_CanSaveNewRating()
        {
            using var context = new AssessmentContext();
            context.Assessments.Add(_assessment);
            context.Requirements.AddRange(_requirements);
            context.Projects.Add(_project);
            context.Criteria.AddRange(_criteria);
            context.Competences.AddRange(_competences);
            context.Requirements.AddRange(_requirements);
            context.Groups.Add(_group);
            context.Indicators.AddRange(_indicators);
            context.SaveChanges();

            AssessmentHelper helper = new AssessmentHelper();
            helper.SaveRating(_assessment, _requirements[0]);

            Assert.That(context.Ratings.Any(rating => rating.AssessmentId == _assessment.AssessmentId));
        }

        [TearDown]
        public void TearDown()
        {
            var context = new AssessmentContext();

            context.Assessments.Remove(_assessment);
            context.Requirements.RemoveRange(_requirements);
            context.Projects.Remove(_project);
            context.Criteria.RemoveRange(_criteria);
            context.Competences.RemoveRange(_competences);
            context.Requirements.RemoveRange(_requirements);
            context.Groups.Remove(_group);
            context.Indicators.RemoveRange(_indicators);
            context.SaveChanges();
        }
    }
}
