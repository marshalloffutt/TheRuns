using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using TheRuns.Models;
using TheRuns.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<RunDatabaseSettings>(
                builder.Configuration.GetSection(nameof(RunDatabaseSettings)));

builder.Services.Configure<UserDatabaseSettings>(
                builder.Configuration.GetSection(nameof(UserDatabaseSettings)));

builder.Services.AddSingleton<IRunDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<RunDatabaseSettings>>().Value);

builder.Services.AddSingleton<IUserDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<UserDatabaseSettings>>().Value);

builder.Services.AddScoped<IRunService, RunService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v3.22.1", new OpenApiInfo { Title = "The Runs", Version = "v3.22.1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(o =>
    {
        //o.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        //o.SwaggerEndpoint("/swagger/v2/swagger.json", "v2");
        o.SwaggerEndpoint("/swagger/v3.22.1/swagger.json", "v3.22.1");
    });
}

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
