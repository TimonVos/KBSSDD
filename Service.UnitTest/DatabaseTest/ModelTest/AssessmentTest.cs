﻿using Model;
using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class AssessmentTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Assert attributes

        [Test]
        public void Assessment_can_be_multiple_per_group_and_project()
        {
            using var group = EntityFaker.Contained.CreateGroup().Save();
            using var project = EntityFaker.Contained.CreateProject().Save();

            using var assessmentA = EntityFaker.Contained.CreateAssessment(new AssessmentArgs
            {
                Group = group.Instance,
                Project = project.Instance
            }).Save();

            using var assessmentB = EntityFaker.Contained.CreateAssessment(new AssessmentArgs
            {
                Group = group.Instance,
                Project = project.Instance
            }).Save();

            using var context = new AssessmentContext();

            var assessments = context.Assessments.Where(a =>
                a.Group == group.Instance &&
                a.Project == project.Instance
            ).ToList();

            Assert.That(assessments.Count, Is.EqualTo(2));
            Assert.That(assessments.Any(a => a.AssessmentId == assessmentA.Instance.AssessmentId), Is.True);
            Assert.That(assessments.Any(a => a.AssessmentId == assessmentB.Instance.AssessmentId), Is.True);
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Assessment_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateAssessment().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Assessments.Any(
                a => a.AssessmentId == container.Instance.AssessmentId
            ), Is.True);
        }

        [Test]
        public void Assessment_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateAssessment().Save();

            using var context = new AssessmentContext();
            Assessment? assessment = (from p in context.Assessments
                                      where p.ProjectId == container.Instance.ProjectId
                                      select p).FirstOrDefault();

            Assert.That(assessment, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(assessment.AssessmentId, Is.EqualTo(container.Instance.AssessmentId));
            });
        }

        [Test]
        public void Assessment_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateAssessment().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Assessment? before = (from a in context.Assessments
                                  where a.AssessmentId == container.Instance.AssessmentId
                                  select a).FirstOrDefault();

            Assert.That(before, Is.Not.Null);
            var temp = EntityFaker.CreateAssessment();

            context.Assessments.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assessment? after = (from a in context.Assessments
                                 where a.ProjectId == container.Instance.ProjectId
                                 select a).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.AssessmentId, Is.EqualTo(before.AssessmentId));
            });
        }

        [Test]
        public void Assessment_can_be_deleted()
        {
            using var container = EntityFaker.Contained.CreateAssessment().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Assessments.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Assessments.Any(
                a => a.AssessmentId == container.Instance.AssessmentId
            ), Is.False);
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Assessment_can_have_groups()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Assessment_can_have_projects()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Assessment_can_belong_to_ratings()
        {
            throw new NotImplementedException();
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }
    }
}