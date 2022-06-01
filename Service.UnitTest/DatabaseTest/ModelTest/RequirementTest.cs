using Bogus;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class RequirementTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Assert attributes

        [Test]
        public void Requirement_id_cannot_be_inserted()
        {

        }

        [Test]
        public void Requirement_required_fields_are_not_nullable()
        {

        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Requirement_can_be_created()
        {

        }

        [Test]
        public void Requirement_can_be_read()
        {

        }

        [Test]
        public void Requirement_can_be_updated()
        {

        }

        [Test]
        public void Requirements_can_be_deleted()
        {

        }

        #endregion

        #region Assert relationships



        #endregion

        [TearDown]
        public void TearDown()
        {
        }
    }
}
