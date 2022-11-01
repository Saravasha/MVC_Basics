var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddMvc();



builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".ZigiPlz";
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "fevercheck",
    pattern: "{controller=Doctor}/{action=FeverCheck}/{id?}");

app.MapControllerRoute(
    name: "guessingame",
    pattern: "{controller=GuessingGame}/{action=Game}/{id?}");


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseSession();
app.Run();
