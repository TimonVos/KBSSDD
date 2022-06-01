using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.AssessmentServices;
using Service.Database;

namespace Service.UnitTest.Grade
{
    public class RatingSaveTest
    {
        private Assessment _assessment;
        private List<Requirement> _requirements;
        private Project _project;
        private Group _group;

        [SetUp]
        public void SetUp()
        {
            using var context = new AssessmentContext();
            _project = context.Projects.FirstOrDefault();
            _group = new Group
            {
                Name = "Groep 1",
                Number = 1
            };
            context.Groups.Add(_group);
            context.SaveChanges();
            _assessment = new Assessment { Group = context.Groups.FirstOrDefault(), Project = _project };
            context.SaveChanges();
            _group.Assessments.Add(_assessment);
            context.Update(_group);
            context.SaveChanges();
            _assessment = context.Assessments.Where(assess => assess.AssessmentId == _assessment.AssessmentId).
                    Include(assess => assess.Ratings).FirstOrDefault();
            _requirements = new List<Requirement>(context.Requirements.Include(req => req.Criterion).Include(req => req.Indicator));
        }

        [Test, Order(1), NonParallelizable]
        public void AssessmentHelper_CanSaveNewRating()
        {
            using var context = new AssessmentContext();

            AssessmentHelper helper = new AssessmentHelper();
            helper.SaveRating(_assessment, _requirements[0]);

            Assert.That(context.Ratings.Any(rating => rating.AssessmentId == _assessment.AssessmentId));
            context.Dispose();
        }
        [Test, Order(2), NonParallelizable]
        public void AssessmentHelper_CanUpdateRating()
        {
            using var context = new AssessmentContext();
            
            AssessmentHelper helper = new AssessmentHelper();
            helper.SaveRating(_assessment, _requirements[0]);

            Assert.That(context.Ratings.Any(rating => rating.AssessmentId == _assessment.AssessmentId));
            Rating rating = new Rating
            {
                Assessment = _assessment,
                AssessmentId = _assessment.AssessmentId,
                Criterion = _requirements[1].Criterion,
                CriterionId = _requirements[1].CriterionId,
                Requirement = _requirements[1],
                RequirementId = _requirements[1].RequirementId
            };
            helper.SaveRating(_assessment, _requirements[1]);
            Assert.That(context.Assessments.
                Where(assess => assess.AssessmentId == _assessment.AssessmentId).FirstOrDefault().
                Ratings.Where(rat => rat.RequirementId == _requirements[1].RequirementId).Equals(rating));
        }

        [TearDown]
        public void TearDown()
        {
            var context = new AssessmentContext();
            context.Groups.RemoveRange(_group);
            context.Ratings.RemoveRange();
            context.Assessments.Remove(_assessment);
            context.SaveChanges();
            context.Dispose();
        }
    }
}
