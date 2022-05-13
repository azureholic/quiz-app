using Microsoft.EntityFrameworkCore;
using Quiz.Api.Data;

var builder = WebApplication.CreateBuilder(args);
var origins = builder.Configuration["AllowedOrigins"].Split(';');

//Add CORS
builder.Services.AddCors(options =>
{

    options.AddPolicy("AllowSpecificOrigins",
    //allow specific origins
    builder => builder.WithOrigins(origins)
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowCredentials());
});


// Add EF services 
builder.Services.AddDbContext<QuizContext>(options => options.UseSqlServer(builder.Configuration["SqlConnectionString"]));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigins");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

DbCreator.CreateDbIfNotExist(app);

app.Run();


