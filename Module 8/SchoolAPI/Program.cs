using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SchoolAPI.Filters;
using System.Reflection;

namespace SchoolAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            //SchoolContext context = new SchoolContext(connectionString);
            //context.Database.EnsureCreated();

            builder.Services.AddDbContext<SchoolContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services to the container.

            builder.Services.AddControllers();
            //(options =>
            //{
            //    options.Filters.Add<ValidateStudentFilter>();
            //});

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(setup =>
            {
                setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "School API",
                    Version = "v1",
                    Description = "API pour gérer les étudiants, enseignants et salles de classe.",
                    Contact = new OpenApiContact
                        { Name = "Corentin Z", Url = new Uri("https://www.corentinz.fr") },
                    License = new OpenApiLicense
                        { Name = "GNU v3", Url = new Uri("https://www.gnu.org/licenses/quick-guide-gplv3.pdf") }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                setup.IncludeXmlComments(xmlPath);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
