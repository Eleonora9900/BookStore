using BookStore_BL.Interfaces;
using BookStore_BL.Services;
using BookStore_DL.Interfaces;
using BookStore_DL.Repositories;
using BookStore.HealthChecks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookstoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IAuthorRepository, AuthorRepository>();
            builder.Services.AddSingleton<IBookRepository, BookRepository>();

            builder.Services.AddSingleton<IAuthorService, AuthorService>();
            builder.Services.AddSingleton<IBookService, BookService>();
            builder.Services.AddSingleton<ILibraryService, LibraryService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
            builder.Services.AddHealthChecks().AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

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
