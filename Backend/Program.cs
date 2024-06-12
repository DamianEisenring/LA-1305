using FeedbackApi.Models;
using FeedbackApi.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<FeedbackDatabaseSettings>(
    builder.Configuration.GetSection(nameof(FeedbackDatabaseSettings)));

builder.Services.AddSingleton<IFeedbackDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<FeedbackDatabaseSettings>>().Value);

builder.Services.AddSingleton<FeedbackService>();

builder.Services.AddControllers();
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
