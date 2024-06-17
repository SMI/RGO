using Microsoft.EntityFrameworkCore;
using RGO.DataAccess;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using RGO.DataAccess.Repository;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Drawing.Text;
using RGO.Utility;
using FAnsi.Implementation;
using FAnsi.Implementations.MicrosoftSQL;
using FAnsi.Implementations.PostgreSql;


public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.
        builder.Services.AddControllersWithViews()
            .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            var dbType = builder.Configuration.GetValue(typeof(object), "DatabaseType");
            switch (dbType)
            {
                case nameof(DatabaseTypes.MicrosoftSQL):
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                    DatabaseHelper.Instance.SetDatabaseType(DatabaseTypes.MicrosoftSQL);
                    break;
                case nameof(DatabaseTypes.Postgres):
                    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
                    DatabaseHelper.Instance.SetDatabaseType(DatabaseTypes.Postgres);
                    break;
                default:
                    throw new Exception($"Unknown database type '{dbType}'");
            }
        });
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

        var app = builder.Build();
        ImplementationManager.Load<MicrosoftSQLImplementation>();
        ImplementationManager.Load<PostgreSqlImplementation>();
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            db.Database.Migrate();
        }



        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{area=Config}/{controller=Home}/{action=Index}/{id?}/{parentId?}");

        app.Run();
    }
}