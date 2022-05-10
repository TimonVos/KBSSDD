using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class IndividualRating : Rating
    {
        public Student Student { get; set; }

        public IndividualRating(Group group, Student student, Criterion criterion, Indicator indicator) : base(group, criterion, indicator)
        {
            Student = student;
        }
    }
}
