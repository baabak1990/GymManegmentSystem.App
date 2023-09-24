using System.Reflection;
using GymManegmentSystem.UI.Contracts;
using GymManegmentSystem.UI.Services;
using GymManegmentSystem.UI.Services.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region HttpClient
//Using NSwage To Generate These Two Interface and class 
builder.Services.AddHttpClient<IClient, Client>(cl => cl.BaseAddress = new Uri("https://localhost:44331"));

#endregion
#region IoC

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
//It is better To Use Local Services As A SingleTone
builder.Services.AddSingleton<ILocalStorageServices, LocalStorageServices>();

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
