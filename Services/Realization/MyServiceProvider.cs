using Microsoft.Extensions.DependencyInjection;

namespace APO_Tsarehradskiy.Services.Realization
{
    public static class MyServiceProvider
    {
        private static ServiceProvider? _provider;
        public static void Initialize(ServiceProvider? provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }
            _provider = provider;
        }
        public static T GetRequiredService<T>()
        {
            if (_provider == null) throw new ArgumentNullException(nameof(_provider));
            return _provider.GetRequiredService<T>();
        }
        public static T? TryGetService<T>() where T : class
        {
            return _provider?.GetService<T>();
        }
    }
}
