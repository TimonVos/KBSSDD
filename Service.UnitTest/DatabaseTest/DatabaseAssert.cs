using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Service.UnitTest.DatabaseTest
{
    internal static class DatabaseAssert
    {
        public static void Throws(TestDelegate code, int evtId, string contains = "")
        {
            DbUpdateException exception;
            SqlException? sqlException;
            exception = Assert.Throws<DbUpdateException>(code);
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);

            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(evtId));

                if (!string.IsNullOrEmpty(contains))
                    StringAssert.Contains(contains, sqlException.Message);
            }
        }
    }
}
