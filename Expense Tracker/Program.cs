using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@32302e342e30RQMM2NPIN1rpu4Adm0/mb7YYOs3xNqLjWjEdYYcNUw0=;Mgo DSMBaFt/QHRqVVhkVFpHaV5LQmFJfFBmRGNTelZ6dVdWESFaRnZdQV1gSHxSdkBrWH1ZdHdc;Mgo DSMBMAY9C3t2VVhkQlFacldJXnxId0x0RWFab19wflBOal1TVAciSV9jS31TdURhWH9beHVXQWRZWA==;Mgo DSMBPh8sVXJ0S0J XE9AflRBQmJAYVF2R2BJfl56cV1MYV5BNQtUQF1hSn5Qd0diWXpWcXZSQmdV;@32302e342e30ICSmHmhokgRWXtfABwjtYtrn1axN6Hr1lO4GE3b3vt4=;NRAiBiAaIQQuGjN/V0Z WE9EaFtKVmBWf1ppR2NbfE5xdF9DaFZQRmYuP1ZhSXxQdkZiW35edXxURGdZUU0=;ORg4AjUWIQA/Gnt2VVhkQlFacldJXnxId0x0RWFab19wflBOal1TVAciSV9jS31TdURhWH9beHVXQWVeWA==;@32302e342e30eVP/b/6sKwFo1uu2mtW8eGfxbjLgdPqBmI7q4jHFnBw=;@32302e342e30Y611/0pTkukhu6gGqc4UUH2 R z/RqqqNSv7J3pJAPc=;@32302e342e30QpxIMuyCnMAcRFssB01dPLXJAwe3XqG2SZb3lVmr98g=;@32302e342e30Y7XGSwM2 ZqnUWSkisge5Hk5wfSXzHIJRxu9vj7yXDs=;@32302e342e30RQMM2NPIN1rpu4Adm0/mb7YYOs3xNqLjWjEdYYcNUw0=");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
