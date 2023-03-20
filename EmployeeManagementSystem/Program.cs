using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Repository.MsSQL;
using EmployeeManagementSystem.Repository;
using EmployeeManagementSystem.Repository.InMemoryRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EmployeeDbContext>(); //calling empdbcontext
//builder.Services.AddScoped<IEmployeeRepository, EmployeeDBRepository>(); // <---changing database, update
//builder.Services.AddScoped<IDepartmentRepository, DepartmentDBRepository>();

builder.Services.AddSingleton<IDepartmentRepository, DepartmentInMemoryRepository>();
builder.Services.AddSingleton<IEmployeeRepository, EmployeeInMemoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.Automigrate();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
