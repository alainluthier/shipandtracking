using Microsoft.EntityFrameworkCore;
using ShipAndTrack.Data;
using Microsoft.Extensions.DependencyInjection;
using ShipAndTrack.Components;
using ShipAndTrack.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<PackageService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Adding database conection
builder.Services.AddDbContext<ShipAndTrackContext>(options=>
options.UseSqlite(builder.Configuration.GetConnectionString("ShipAndTrackContext")?? throw new InvalidOperationException("Connection string 'ShipAndTrackContext' not found.")));

//Registering services
builder.Services.AddScoped<PackageService>();
builder.Services.AddScoped<RegistrationService>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ShipAndTrackContext>();
    context.Database.EnsureCreated();
    DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapGet("/registration-success", () =>
{
    return "Registration Success Page";
});

app.Run();
