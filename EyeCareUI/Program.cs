using EyeCareUI.DataBase;
using EyeCareUI.GlobalModels;
using EyeCareUI.HUB;
using EyeCareUI.Services.AuthenticationServices;
using EyeCareUI.Services.CustomerServices;
using EyeCareUI.Services.SystemNavigationServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<SystemStructureModel>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add SignalR
builder.Services.AddSignalR();

//Add DbContext with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

//Register services
builder.Services.AddScoped<INavigationService, NavigationService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseStaticFiles();

app.MapHub<ClientIPHUB>("/RemoteIPHUB");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Authentication}/{action=Login}/{id?}")
    .WithStaticAssets();


app.Run();
