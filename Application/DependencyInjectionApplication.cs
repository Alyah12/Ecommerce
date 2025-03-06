namespace Aplication;

public static class  DependencyInjectionApplication
{
    /// <summary>
    /// Adds the application layer dependencies to the dependency injection container.
    /// </summary>
    /// <param name="services">The IServiceCollection instance to which the application layer services will be added.</param>
    /// <param name="configuration">The application configuration instance.</param>
    /// <returns>The updated IServiceCollection instance with the application layer configured.</returns>
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddMediatR(typeof(CreateCompanyCommandRequest).Assembly)
            .AddNotifications()
            .AddValidations()
            .AddSerilog(configuration);

        return services;
    }

}