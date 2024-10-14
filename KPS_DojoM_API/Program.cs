using KPS_DojoM_API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using KPS_DojoM_models;
using KPS_DojoM_API.Repository;



// Add services to the container.

var builder = WebApplication.CreateBuilder(args);
//adicionar DbContext ao serviços
builder.Services.AddDbContext<KPS_DbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("KPS_DbContext") ?? throw new InvalidOperationException("Connection string 'KPS_DbContext' not found")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add scopes
builder.Services.AddScoped<IRepository<Association>, AssociationRepository>();
builder.Services.AddScoped<IRepository<Athletes>, AthletesRepository>();
builder.Services.AddScoped<IRepository<Categories>, CategoriesRepository>();
builder.Services.AddScoped<IRepository<Championships>, ChampionshipsRepository>();
builder.Services.AddScoped<IRepository<Events>, EventsRepository>();
builder.Services.AddScoped<IRepository<Parents>, ParentsRepository>();
builder.Services.AddScoped<IRepository<Senseis>, SenseisRepository>();
builder.Services.AddScoped<IRepository<TheResults>, TheResultsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
