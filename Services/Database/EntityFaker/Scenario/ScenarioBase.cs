namespace Service.Database.EntityFaker.Scenario
{
    internal abstract class ScenarioBase : IDisposable
    {
        public abstract void SaveScenario();
        public abstract void RemoveScenario();
        public void Dispose()
        {
            RemoveScenario();
        }
    }
}
