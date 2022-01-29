using ComputerStore.Controllers;

var builder = WebApplication.CreateBuilder(args);

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



/*using System;
using Microsoft.Data.Sqlite;
using static Microsoft.Data.Sqlite.SqliteDataReader;*/

/*var location = System.AppDomain.CurrentDomain.BaseDirectory;
var filename = "store_product.db";
var fullpath = System.IO.Path.Combine(location, filename);

Console.WriteLine(fullpath);
string cs = String.Format("Data Source= {0}", fullpath);
string stm = "SELECT SQLITE_VERSION()";

using var con = new SqliteConnection(cs);
con.Open();

using var cmd = new SqliteCommand(stm, con);

string version = cmd.ExecuteScalar().ToString();


cmd.CommandText = "SELECT * FROM products";
SqliteDataReader reader = cmd.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(String.Format("{0}", reader[1]));
}

*/

