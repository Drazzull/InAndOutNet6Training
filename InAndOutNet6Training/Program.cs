var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IMvcBuilder builderMvc = builder.Services.AddControllersWithViews();

IMvcBuilder builderRazor = builder.Services.AddRazorPages();

#if DEBUG
if (builder.Environment.IsDevelopment())
{
    builderMvc.AddRazorRuntimeCompilation();
    builderRazor.AddRazorRuntimeCompilation();
}
#endif

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();