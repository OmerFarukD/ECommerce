using ECommerce.WebApi.Contexts;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Repository.Concretes;
using ECommerce.WebApi.Service.Abstracts;
using ECommerce.WebApi.Service.Concretes;
using ECommerce.WebApi.Service.Mappers;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddDbContext<MsSqlContext>();
builder.Services.AddScoped<IProductRepository,EfProductRepository>();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<ProductMapper>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
