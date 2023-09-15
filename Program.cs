using entity_framework;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Gerenciador de Filmes",
        Description = "Uma API Web ASP.NET Core para gerenciar dados de filmes",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Examplo de Contato",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Examplo de License",
            Url = new Uri("https://example.com/license")
        }       
    });

    var xmlApiPath = Path.Combine(AppContext.BaseDirectory,$"{typeof(Program).Assembly.GetName().Name}.xml");
    options.IncludeXmlComments(xmlApiPath);
});

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI( setup => {
        setup.RoutePrefix="swagger";
        setup.SwaggerEndpoint("/swagger/v1/swagger.json","Documentation");
    });
} 

app.UseHttpsRedirection();

//app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
