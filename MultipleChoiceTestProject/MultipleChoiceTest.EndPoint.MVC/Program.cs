using Microsoft.EntityFrameworkCore;
using MultipleChoiceTest.Application.Contract.IServices;
using MultipleChoiceTest.Application.Contract.Mappers;
using MultipleChoiceTest.Application.Services;
using MultipleChoiceTest.Model.Interfaces;
using MultipleChoiceTest.Persistence.EF.Contexts;
using MultipleChoiceTest.Persistence.EF.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ITestService, TestService>();

builder.Services.AddScoped<ITestRepository, TestRepository>();

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();

builder.Services.AddScoped<IUserTestRepository, UserTestRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

AddDbContext(builder);

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tests}/{action=GetInputs}/{id?}");


app.Run();

void AddDbContext(WebApplicationBuilder webApplicationBuilder)
{
    webApplicationBuilder.Services.AddDbContext<MultipleChoiceTestContext>
        (options => options.UseSqlServer(webApplicationBuilder.Configuration.GetConnectionString("TestConnectionString")));
}