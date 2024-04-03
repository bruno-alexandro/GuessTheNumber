var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
//uma altera��o denovo aham alou? testando denovo 
// nova alteração nova 2 qualquer alteração

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//altera��o 
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.Run();
