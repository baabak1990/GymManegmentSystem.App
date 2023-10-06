using System.Reflection;
using GymManagementUI.AspNetMVC.UI.Contracts;
using GymManagementUI.AspNetMVC.UI.Services;
using GymManagementUI.AspNetMVC.UI.Services.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
#region Ioc

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
//Add it As SingleTone
builder.Services.AddSingleton<ILocalStorageService, LocalStorageService>();
#endregion
#region HttpCLient
//URI To Connect With API we bring it from lunch settings in api project
builder.Services.AddHttpClient<IClient, Client>
	(cl => cl.BaseAddress = new Uri("https://localhost:44331"));

#endregion
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
