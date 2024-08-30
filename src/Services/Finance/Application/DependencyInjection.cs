namespace FinanceAPI.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {          
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
             typeof(LoginCommand).Assembly, typeof(ICommand<>).Assembly));
            services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();           

            return services;
        }
    }
}
