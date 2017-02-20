namespace Net.Core.Demo.Web.Storage
{
    public static class DbInitializer
    {
        public static void Initialize(DemoAppContext context)
        {
            context.Database.EnsureCreated();

        }

    }
}