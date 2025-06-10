namespace Web.Extension
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {

            // Aquí colocas tu clase principal del perfil de mapeo (puede estar en Utilities.Map.Map o similar)
            services.AddAutoMapper(typeof(Utilities.Map.Map));
            return services;
        }
    }
}
