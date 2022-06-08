using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.EntityFaker.Args;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Rating CreateRating(RatingArgs? fakerArgs = null)
        {
            fakerArgs ??= new RatingArgs();
            var rating = new Rating
            {
                Assessment = fakerArgs.Assessment,
                Criterion = fakerArgs.Criterion,
                Requirement = fakerArgs.Requirement
            };

            if (fakerArgs.Save)
                Save(rating);

            return rating;
        }

        public static void Save(Rating rating)
        {
            using var context = GetContext();
            if (rating.Assessment.AssessmentId != 0)
                context.Entry(rating.AssessmentId).State = EntityState.Unchanged;
            if (rating.Criterion.CriterionId != 0)
                context.Entry(rating.Criterion).State = EntityState.Unchanged;
            if (rating.Requirement.RequirementId != 0)
                context.Entry(rating.Requirement).State = EntityState.Unchanged;
            context.Ratings.Add(rating);
            context.SaveChanges();
        }

        public static void Update(Rating rating)
        {
            using var context = GetContext();
            context.Ratings.Add(rating);
            context.SaveChanges();
        }

        public static void Remove(Rating rating, bool removeRelated = false)
        {
            using var context = GetContext();
            if (context.Ratings.Any(r => r == rating))
            {
                context.Ratings.Remove(rating);
                context.SaveChanges();
            }

            if (removeRelated)
            {
                if (rating.Assessment is not null)
                    Remove(rating.Assessment, true);
                else
                {
                    var criterion = context.Assessments.Where(a => a.AssessmentId == rating.AssessmentId).FirstOrDefault();

                    if (criterion is not null)
                        Remove(criterion, true);
                }

                if (rating.Criterion is not null)
                    Remove(rating.Criterion, true);
                else
                {
                    var criterion = context.Criteria.Where(c => c.CriterionId == rating.CriterionId).FirstOrDefault();

                    if (criterion is not null)
                        Remove(criterion, true);
                }

                if (rating.Requirement is not null)
                    Remove(rating.Requirement, true);
                else
                {
                    var requirement = context.Requirements.Where(r => r.RequirementId == rating.RequirementId).FirstOrDefault();

                    if (requirement is not null)
                        Remove(requirement, true);
                }
            }
        }

        public static IEnumerable<Rating> CreateRatings(RatingsArgs? fakerArgs = null)
        {
            fakerArgs ??= new RatingsArgs();
            using var context = new AssessmentContext();

            var ratings = new List<Rating>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                var requirement = CreateRequirement();

                ratings.Add(CreateRating(new RatingArgs
                {
                    Save = false,
                    Assessment = fakerArgs.Assessment,
                    Criterion = requirement.Criterion,
                    Requirement = requirement,
                }));

                count--;
            }

            if (fakerArgs.Save)
                SaveRange(ratings);

            return ratings;
        }

        public static void SaveRange(IEnumerable<Rating> ratings)
        {
            using var context = GetContext();
            context.Ratings.AddRange(ratings);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Rating> ratings)
        {
            using var context = GetContext();
            context.Ratings.AddRange(ratings);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Rating> ratings, bool removeRelated = false)
        {
            using var context = GetContext();
            context.RemoveRange(ratings);
            context.SaveChanges();
            context.Dispose();

            if (removeRelated)
            {
                ratings
                    .GroupBy(r => r.Criterion)
                    .Select(r => r.FirstOrDefault())
                    .ToList()
                    .ForEach(r =>
                    {
                        if (r is not null)
                            Remove(r.Criterion, true);
                    });

                ratings
                    .GroupBy(r => r.Indicator)
                    .Select(r => r.FirstOrDefault())
                    .ToList()
                    .ForEach(r =>
                    {
                        if (r is not null)
                            Remove(r.Indicator);
                    });
            }
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Rating> CreateRating(RatingArgs? fakerArgs = null)
        {
            fakerArgs ??= new RatingArgs();
            fakerArgs.Save = false;

            var rating = EntityFaker.CreateRating(fakerArgs);
            return new Container<Rating>(rating,
                () => EntityFaker.Save(rating),
                () => EntityFaker.Update(rating),
                () => EntityFaker.Remove(rating, fakerArgs.RemoveRelated)
            );
        }

        public Container<IEnumerable<Rating>> CreateRatings(RatingsArgs? fakerArgs = null)
        {
            fakerArgs ??= new RatingsArgs();
            fakerArgs.Save = false;

            var ratings = EntityFaker.CreateRatings(fakerArgs);
            return new Container<IEnumerable<Rating>>(ratings,
                () => EntityFaker.SaveRange(ratings),
                () => EntityFaker.UpdateRange(ratings),
                () => EntityFaker.RemoveRange(ratings, fakerArgs.RemoveRelated)
            );
        }
    }
}
