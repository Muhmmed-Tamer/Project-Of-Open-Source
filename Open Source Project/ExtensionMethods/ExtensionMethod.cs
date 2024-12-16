using Open_Source_Project.Repository;
using Open_Source_Project.Services;

namespace Open_Source_Project.ExtensionMethods
{
    public static class ExtensionMethod
    {
        public static void AddInterfacesAndClasses(this IServiceCollection Services)
        {
            Services.AddScoped<ITableRepository , TableRepository>();
            Services.AddScoped<IUser_TableRepository , User_TableRepository>();
            Services.AddScoped<IUnitOfWork,UnitOfWork>();
        }
    }
}
