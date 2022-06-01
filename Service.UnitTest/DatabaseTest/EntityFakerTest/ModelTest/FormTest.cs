using Service.Database.EntityFaker;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class FormTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_form()
        {
            var formA = EntityFaker.CreateForm(new FakerArgs { Save = true });
            var formB = EntityFaker.CreateForm(new FakerArgs { Save = true });

            Assert.That(formA.FormId, Is.Not.EqualTo(formB.FormId));

            EntityFaker.RemoveRange(new[] { formA, formB });
        }

        [Test]
        public void EntityFaker_can_create_forms()
        {
            var formsA = EntityFaker.CreateForms(new EnumerableFakerArgs { Save = true });
            var formsB = EntityFaker.CreateForms(new EnumerableFakerArgs { Save = true });

            var formsT = formsA.ToList();
            formsT.AddRange(formsB);
            Assert.That(formsT.DistinctBy(s => s.FormId).Count, Is.EqualTo(formsA.Count() + formsB.Count()));

            EntityFaker.RemoveRange(formsT);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
