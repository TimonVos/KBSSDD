using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Indicator CreateIndicator(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            var indicator = _indicatorFaker.Generate();

            if (fakerArgs.Save)
                Save(indicator);

            return indicator;
        }

        public static void Save(Indicator indicator)
        {
            using var context = GetContext();
            context.Indicators.Add(indicator);
            context.SaveChanges();
        }

        public static void Update(Indicator indicator)
        {
            using var context = GetContext();
            context.Indicators.Add(indicator);
            context.SaveChanges();
        }

        public static void Remove(Indicator indicator)
        {
            using var context = GetContext();
            context.Indicators.Remove(indicator);
            context.SaveChanges();
        }

        public static IEnumerable<Indicator> CreateIndicators(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
            using var context = new AssessmentContext();

            var indicators = new List<Indicator>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                indicators.Add(CreateIndicator(new FakerArgs
                {
                    id = id,
                    Save = false,
                }));

                id = indicators.Last().IndicatorId + 1;
                count--;
            }

            if (fakerArgs.Save)
                SaveRange(indicators);

            return indicators;
        }

        public static void SaveRange(IEnumerable<Indicator> indicators)
        {
            using var context = GetContext();
            context.Indicators.AddRange(indicators);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Indicator> indicators)
        {
            using var context = GetContext();
            context.Indicators.AddRange(indicators);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Indicator> indicators)
        {
            using var context = GetContext();
            context.Indicators.RemoveRange(indicators);
            context.SaveChanges();
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Indicator> CreateIndicator(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            fakerArgs.Save = false;

            var indicator = EntityFaker.CreateIndicator(fakerArgs);
            return new Container<Indicator>(indicator,
                () => EntityFaker.Save(indicator),
                () => EntityFaker.Update(indicator),
                () => EntityFaker.Remove(indicator)
            );
        }

        public Container<IEnumerable<Indicator>> CreateIndicators(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
            fakerArgs.Save = false;

            var indicators = EntityFaker.CreateIndicators(fakerArgs);
            return new Container<IEnumerable<Indicator>>(indicators,
                () => EntityFaker.SaveRange(indicators),
                () => EntityFaker.UpdateRange(indicators),
                () => EntityFaker.RemoveRange(indicators)
            );
        }
    }
}
