using System.Reflection;
using GymManagement.UI.Asp.NetMVC.Contracts;
using GymManagement.UI.Asp.NetMVC.Services;
using GymManagement.UI.Asp.NetMVC.Services.Base;

var builder = WebApplication.CreateBuilder(args);
#region HttpClient
builder.Services.AddHttpClient<IClient, Client>(cl => cl.BaseAddress = new Uri("https://localhost:7181"));
#endregion
#region Ioc

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton<ILocalStorageServices, LocalStorageServices>();
builder.Services.AddScoped<IMemberServices, MemberService>();
builder.Services.AddScoped<IMembershipServices,MembershipServices>();
#endregion
// Add services to the container.
builder.Services.AddControllersWithViews();
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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
