
using Microsoft.EntityFrameworkCore;
using NASA_gestionale_task.Models;
using NASA_gestionale_task.Repositories;
using NASA_gestionale_task.Services;

namespace NASA_gestionale_task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Importanti per la configurazione di Context e Repository
            builder.Services.AddDbContext<NasaContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
                ));
            builder.Services.AddScoped<OggettoCelesteRepo>();
            builder.Services.AddScoped<SistemaRepo>();
            builder.Services.AddScoped<OggettoCelesteService>();


            #endregion

            var app = builder.Build();

            app.UseCors(builder =>
                 builder
                 .WithOrigins("*")
                 .AllowAnyMethod()
                 .AllowAnyHeader());


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
