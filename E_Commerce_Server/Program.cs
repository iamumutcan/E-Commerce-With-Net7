using E_Commerce_Business.Repository;
using E_Commerce_Business.Repository.IRepository;
using E_Commerce_DataAccess.Data;
using E_Commerce_Server.Data;
using E_Commerce_Server.Service;
using E_Commerce_Server.Service.IService;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Syncfusion.Blazor;
using Syncfusion.Licensing;


//Read keys from file
var secretsPath = Path.Combine(Directory.GetCurrentDirectory(), "secrets.json");
var json = File.ReadAllText(secretsPath);
var secrets = JObject.Parse(json);

// Register Syncfusion license
var syncfusionApiKey = secrets["SyncfusionApiKey"].ToString();
SyncfusionLicenseProvider.RegisterLicense(syncfusionApiKey);


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//Path
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IFileUpload, FileUpload>();
builder.Services.AddScoped<IProductPriceRepository, ProductPriceRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
