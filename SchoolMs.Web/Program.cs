using SchoolMs.BLL.Students;
using SchoolMs.BLL.Teacher;
using SchoolMs.DAL.Dapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Start Services
builder.Services.AddScoped<IDapperRepo, DapperRepo>();
builder.Services.AddScoped<ITeacherServices, TeacherServices>();
builder.Services.AddScoped<IStudentServices, StudentServices>();

// End Services
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
    pattern: "{controller=Teacher}/{action=Index}/{id?}");

app.Run();
