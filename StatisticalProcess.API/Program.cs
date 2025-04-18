using StatisticalProcess.API.Extension;


var builder = WebApplication.CreateBuilder(args);
var logger = builder.Services.BuildServiceProvider().GetRequiredService<ILogger<Program>>();

// Add services to the container.

builder.Services.ConfigureService(builder.Configuration, logger);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

WebApplicationExtension.ConfigureApps(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
