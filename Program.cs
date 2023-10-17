using Microsoft.AspNetCore.Authorization;
using PoESnap.Services;

namespace PoESnap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var MyCorsPolicy = "_myCorsPolicy";
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyCorsPolicy,
                                  policy =>
                                  {
                                      policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
                                  });
            });

            builder.Services.AddSingleton<ICharacterService, CharacterService>();

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseCors(MyCorsPolicy);

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}