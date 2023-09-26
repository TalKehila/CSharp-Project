
var builder = WebApplication.CreateBuilder(args);

//Add services to the container.

//builder.Services.AddScoped<Data>();

string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyWebPet;Integrated Security=True";
builder.Services.AddDbContext<MyData>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionString));

//builder.Services.AddDbContext<MyData>(options => options.UseSqlite("Data Source=c:\\temp\\PetWeb.db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
	var ctx = scope.ServiceProvider.GetRequiredService<MyData>();
	ctx.Database.EnsureDeleted();
	ctx.Database.EnsureCreated();
}


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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
